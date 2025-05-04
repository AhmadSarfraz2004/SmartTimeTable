using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTimeTable.Business
{
    public class TimeTable
    {
        public int TimeTableId { get; set; }
        public int RoomNumber { get; set; }
        public string Day { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
