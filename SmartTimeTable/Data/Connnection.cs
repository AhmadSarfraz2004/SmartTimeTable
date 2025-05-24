using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SmartTimeTable.Business;

namespace SmartTimeTable.Data
{
    public static class Connection
    {

        private static readonly string connectionString = "Data Source=DESKTOP-ADPH47V\\SQLEXPRESS;Initial Catalog=SmartTimeTable;Integrated Security=True;Encrypt=False";
        #region Methods
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Connection Error: " + ex.Message);
                return null;
            }
        }

        public static void RegisterUser(User user)
        {
            using (SqlConnection conn = GetConnection())
            {
                // 1. Insert into Users table
                string query = @"INSERT INTO Users (FirstName, LastName, UserName, Email, Department, Role, Password, DateOfBirth) 
                         VALUES (@FirstName, @LastName, @UserName, @Email, @Department, @Role, @Password, @DateOfBirth);
                         SELECT SCOPE_IDENTITY();";   // <-- IMPORTANT: Get the inserted User's Id

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Department", user.Department);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);

                // 2. Execute and get newly inserted Id
                int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                // 3. Insert into Students or Teachers based on Role
                if (user.Role == "Student")
                {
                    string studentQuery = "INSERT INTO Students (Id) VALUES (@StudentId)";
                    SqlCommand studentCmd = new SqlCommand(studentQuery, conn);
                    studentCmd.Parameters.AddWithValue("@StudentId", newUserId);
                    studentCmd.ExecuteNonQuery();
                }
            }
        }

        public static User LoginUser(string userInput, string password)
        {
            SqlConnection conn = GetConnection();
            if (conn == null)
            {
                return null;
            }

            try
            {
                string query = "SELECT * FROM Users WHERE (UserName = @Input OR Email = @Input) AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Input", userInput);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User user = new User
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        UserName = reader["UserName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Department = reader["Department"].ToString(),
                        Role = reader["Role"].ToString(),
                        Password = reader["Password"].ToString(),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"])
                    };

                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Login Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void SaveUser(User user)
        {
            using (SqlConnection conn = GetConnection())
            {
                if (conn == null) return;

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert into Users table, auto-generating ID
                    string userQuery = @"
                    INSERT INTO Users 
                    (FirstName, LastName, UserName, Email, Department, Role, Password, DateOfBirth)
                    OUTPUT INSERTED.Id
                    VALUES 
                    (@FirstName, @LastName, @UserName, @Email, @Department, @Role, @Password, @DateOfBirth);";

                    using (SqlCommand userCmd = new SqlCommand(userQuery, conn, transaction))
                    {
                        userCmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                        userCmd.Parameters.AddWithValue("@LastName", user.LastName);
                        userCmd.Parameters.AddWithValue("@UserName", user.UserName);
                        userCmd.Parameters.AddWithValue("@Email", user.Email);
                        userCmd.Parameters.AddWithValue("@Department", user.Department ?? (object)DBNull.Value);
                        userCmd.Parameters.AddWithValue("@Role", user.Role);
                        userCmd.Parameters.AddWithValue("@Password", user.Password);
                        userCmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);

                        // Get the new auto-generated ID
                        int newUserId = (int)userCmd.ExecuteScalar();

                        // If user is Teacher or Student, insert into corresponding table
                        string roleTable = user.Role == "Teacher" ? "Teachers" :
                                           user.Role == "Student" ? "Students" : null;

                        if (roleTable != null)
                        {
                            string roleQuery = $"INSERT INTO {roleTable} (Id) VALUES (@Id)";
                            using (SqlCommand roleCmd = new SqlCommand(roleQuery, conn, transaction))
                            {
                                roleCmd.Parameters.AddWithValue("@Id", newUserId);
                                roleCmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Save User Error: " + ex.Message);
                    transaction.Rollback();
                }
            }
        }

        public static DataTable GetTeachersTable()
        {
            var dt = new DataTable();

            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                SELECT 
                Id,
                FirstName + ' ' + LastName AS FullName,
                Department
                FROM Users
                WHERE Role = 'Teacher'
                ORDER BY FirstName, LastName;";

                using (var rdr = cmd.ExecuteReader())
                {
                    dt.Load(rdr);
                }
            }

            return dt;
        }

        public static string GetTeacherDepartment(int teacherId)
        {
            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                SELECT Department 
                  FROM Users
                 WHERE Id = @Id
                   AND Role = 'Teacher';";
                cmd.Parameters.AddWithValue("@Id", teacherId);

                object result = cmd.ExecuteScalar();
                return result == null || result == DBNull.Value
                       ? String.Empty
                       : result.ToString();
            }
        }

        public static void InsertTimeTable(
            int teacherId,
            string teacherName,
            string department,
            int roomNumber,
            string day,
            string CourseCode,
            string courseName,
            DateTime date,
            string lecture,
            TimeSpan startTime,
            TimeSpan endTime)
        {
            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            INSERT INTO TimeTables
            (
                TeacherId, TeacherName, Department,
                RoomNumber, Day,
                CourseCode, CourseName,
                Date, Lecture, StartTime, EndTime
            )
            VALUES
            (
                @TeacherId, @TeacherName, @Department,
                @Room,      @Day,
                @CourseCode,  @CourseName,
                @Date,  @Lecture,    @Start,     @End
            );";

                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.Parameters.AddWithValue("@TeacherName", teacherName);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@Room", roomNumber);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@CourseCode", CourseCode);
                cmd.Parameters.AddWithValue("@CourseName", courseName);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Lecture", lecture);
                cmd.Parameters.AddWithValue("@Start", startTime);
                cmd.Parameters.AddWithValue("@End", endTime);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllTimeTableDetails()
        {
            var dt = new DataTable();

            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT
                TimeTableId,
                Department,
                TeacherId,
                TeacherName,
                RoomNumber,
                Day,
                CourseCode,
                CourseName,
                Lecture, 
                Date,
                StartTime,
                EndTime
            FROM TimeTables
            ORDER BY Date, StartTime;";

                using (var rdr = cmd.ExecuteReader())
                {
                    dt.Load(rdr);
                }
            }

            return dt;
        }

        public static DataTable GetStudentTimeTable()
        {
            var dt = new DataTable();
            // Create the columns: the first column is the day name ("SR#"),
            // then one column per lecture slot.
            dt.Columns.Add("SR#", typeof(string));
            var lectures = new[] { "1st", "2nd", "3rd", "4th", "5th", "6th" };
            foreach (var lec in lectures)
                dt.Columns.Add(lec, typeof(string));

            // Seed one row per weekday:
            var days = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            foreach (var day in days)
            {
                var row = dt.NewRow();
                row["SR#"] = day;
                dt.Rows.Add(row);
            }

            // Load every entry from TimeTables and slot it
            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT Day, Lecture, CourseCode, CourseName, RoomNumber, StartTime, EndTime, TeacherName
            FROM TimeTables;";
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string day = rdr.GetString(rdr.GetOrdinal("Day"));
                        string lecture = rdr.GetString(rdr.GetOrdinal("Lecture"));
                        string courseCode = rdr.GetString(rdr.GetOrdinal("CourseCode"));
                        string courseName = rdr.GetString(rdr.GetOrdinal("CourseName"));
                        int room = rdr.GetInt32(rdr.GetOrdinal("RoomNumber"));
                        TimeSpan start = rdr.GetTimeSpan(rdr.GetOrdinal("StartTime"));
                        TimeSpan end = rdr.GetTimeSpan(rdr.GetOrdinal("EndTime"));
                        string teacher = rdr.GetString(rdr.GetOrdinal("TeacherName"));

                        string info =
                            $"Course Code: {courseCode}\r\n" +
                            $"Course Name: {courseName}\r\n" +
                            $"Room: {room}\r\n" +
                            $"StartTime: {start:h\\:mm}\r\n " +
                            $"EndTime: {end:h\\:mm}\rTeacher: {teacher}";

                        // Find the row for this day
                        var found = dt.Rows.Cast<DataRow>()
                                          .FirstOrDefault(r => r["SR#"].ToString() == day);
                        if (found != null && dt.Columns.Contains(lecture))
                        {
                            found[lecture] = info;
                        }
                    }
                }
            }

            return dt;
        }

        public static DataTable GetTeacherTimeTable()
        {
            var dt = new DataTable();
            // Create the columns: the first column is the day name ("SR#"),
            // then one column per lecture slot.
            dt.Columns.Add("SR#", typeof(string));
            var lectures = new[] { "1st", "2nd", "3rd", "4th", "5th", "6th" };
            foreach (var lec in lectures)
                dt.Columns.Add(lec, typeof(string));

            // Seed one row per weekday:
            var days = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            foreach (var day in days)
            {
                var row = dt.NewRow();
                row["SR#"] = day;
                dt.Rows.Add(row);
            }

            // Load every entry from TimeTables and slot it
            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT Day, Lecture, CourseCode, CourseName, RoomNumber, StartTime, EndTime
            FROM TimeTables;";
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        string day = rdr.GetString(rdr.GetOrdinal("Day"));
                        string lecture = rdr.GetString(rdr.GetOrdinal("Lecture"));
                        string courseCode = rdr.GetString(rdr.GetOrdinal("CourseCode"));
                        string courseName = rdr.GetString(rdr.GetOrdinal("CourseName"));
                        int room = rdr.GetInt32(rdr.GetOrdinal("RoomNumber"));
                        TimeSpan start = rdr.GetTimeSpan(rdr.GetOrdinal("StartTime"));
                        TimeSpan end = rdr.GetTimeSpan(rdr.GetOrdinal("EndTime"));

                        string info =
                            $"Course Code: {courseCode}\r\n" +
                            $"Course Name: {courseName}\r\n" +
                            $"Room: {room}\r\n" +
                            $"StartTime: {start:h\\:mm}\r\n " +
                            $"EndTime: {end:h\\:mm}\r\n";

                        // Find the row for this day
                        var found = dt.Rows.Cast<DataRow>()
                                          .FirstOrDefault(r => r["SR#"].ToString() == day);
                        if (found != null && dt.Columns.Contains(lecture))
                        {
                            found[lecture] = info;
                        }
                    }
                }
            }

            return dt;
        }

        #endregion
    }
}