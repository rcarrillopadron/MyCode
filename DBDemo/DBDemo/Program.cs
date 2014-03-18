using System.Linq;
using DBDemo.Data;
using DBDemo.Data.Tables;

namespace DBDemo
{
    class Program
    {
        static void Main()
        {
            using (var db = new InterviewContext())
            {
                Person person = db.People.Single(x => x.PersonID == 1);
                person.FullName = "Esmirna";
                db.SaveChanges();
            }
        }
    }
}
