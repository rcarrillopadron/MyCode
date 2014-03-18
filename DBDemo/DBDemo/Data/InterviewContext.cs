using System.Data.Entity;
using DBDemo.Data.Tables;

namespace DBDemo.Data
{
    public partial class InterviewContext : DbContext
    {
        public InterviewContext() : base("name=InterviewDB")
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>()
                .HasMany(e => e.Attendances)
                .WithRequired(e => e.Classroom)
                .HasForeignKey(e => e.ClassroomFK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Attendances)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonFK)
                .WillCascadeOnDelete(false);
        }
    }
}
