using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBDemo.Data.Tables
{
    [Table("Classroom")]
    public partial class Classroom
    {
        public Classroom()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int ClassroomID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
