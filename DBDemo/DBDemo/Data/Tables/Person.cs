using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBDemo.Data.Tables
{
    public partial class Person
    {
        public Person()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
