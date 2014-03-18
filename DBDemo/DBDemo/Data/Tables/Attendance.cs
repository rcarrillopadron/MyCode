using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBDemo.Data.Tables
{

    [Table("Attendance")]
    public partial class Attendance
    {
        public int AttendanceID { get; set; }
        public int PersonFK { get; set; }
        public int ClassroomFK { get; set; }
        public DateTime CheckInTime { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Person Person { get; set; }
    }
}