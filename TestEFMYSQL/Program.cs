using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TestEFMYSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            using (testEntities entities = new testEntities())
            {
                /*
                user user = new user();
                user.name = "csj1";
                user.tim = null;

                entities.user.Add(user);

                //entities.SaveChanges();

                user = new user();
                user.name = "csj2";
                user.tim = DateTime.Now;
                entities.user.Add(user);

                entities.SaveChanges();

                //entities.user.Select()
                */



                var res = from u in entities.user
                          where u.name == "csj2"
                          select new { tt = u.tim };

                foreach (var r in res)
                {
                    Console.WriteLine("1:" + r.tt);
                }

                var re = entities.user.Where(u => (u.name == "csj2" || u.name == "csj1"));

                foreach (user r in re)
                {
                    Console.WriteLine("2:" + r.tim);
                }
                re = re.OrderByDescending(u => (u.tim));

                foreach (user r in re)
                {
                    Console.WriteLine("2:" + r.tim);
                }

                user ux = re.First();

                ux.name = " csjxxx ";

                entities.SaveChanges();

                entities.user.Remove(ux);

                entities.SaveChanges();

                //Console.WriteLine("3:" + re.tim);
                

               



            }

            Console.ReadKey();
            //*/
            //using (var context = new U)
            //{
            //    var myEvents = from e in context.Events
            //                   from a in e.Attendees
            //                   where a.Person.FirstName == "Gunnar" &&
            //                   a.Person.LastName == "Peipman"
            //                   select e; Console.WriteLine("My events: ");
            //    foreach (var e in myEvents)
            //    {
            //        Console.WriteLine(e.Title);
            //    }
            //}
        }
    }
}
