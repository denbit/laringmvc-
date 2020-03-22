using learningmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace learningmvc
{
    public class Seeder : System.Data.Entity.DropCreateDatabaseIfModelChanges<Model1>
    {
        protected override void Seed(Model1 context)
        {
            var passwords = new List<Passwords> { new Passwords { login="lodry",site="github.com"} };
              passwords.ForEach(p => context.passwords.Add(p));
            System.Diagnostics.Debug.WriteLine(passwords.ToArray());
            context.SaveChanges();
        }
    }
}