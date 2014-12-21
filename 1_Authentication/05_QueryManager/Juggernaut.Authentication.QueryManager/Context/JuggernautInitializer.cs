using System;
using System.Collections.Generic;
using System.Data.Entity;
using Juggernaut.Authentication.Common;
using Juggernaut.Authentication.EntityModel;

namespace Juggernaut.Authentication.QueryManager.Context
{
    public class JuggernautInitializer : DropCreateDatabaseIfModelChanges<JuggernautContext>
    {
        protected override void Seed(JuggernautContext context)
        {
            AddDefaultUsers(context);
        }

        private void AddDefaultUsers(JuggernautContext db)
        {
            var applications = new List<JuggernautApplication>
            {
                new JuggernautApplication
                {
                    ApplicationName = "Django",
                    ActiveFrom = DateTime.Parse("1 Dec 2014")
                },
                new JuggernautApplication
                {
                    ApplicationName = "Kris Kringle",
                    ActiveFrom = DateTime.Parse("1 Aug 2015")
                },
                new JuggernautApplication
                {
                    ApplicationName = "Perscribo",
                    ActiveFrom = DateTime.Parse("1 Jan 2015")
                }
            };
            applications.ForEach(a => db.JuggernautApplications.Add(a));

            var users = new List<JuggernautUser>
            {
                new JuggernautUser
                {
                    GivenName = "Rob",
                    Surname = "Pocklington",
                    UserName = "pocko",
                    PasswordSaltedHash = PasswordProtector.PasswordToHash("123456"),
                    ActiveFrom = DateTime.Parse("1 December 2014")
                },
                new JuggernautUser
                {
                    GivenName = "Janette",
                    Surname = "Pocklington",
                    UserName = "jnetp",
                    PasswordSaltedHash = PasswordProtector.PasswordToHash("123456"),
                    ActiveFrom = DateTime.Parse("1 December 2014")
                }
            };
            users.ForEach(u => db.JuggernautUsers.Add(u));

            var roles = new List<JuggernautRole>
            {
                new JuggernautRole { Role = "Super User"},
                new JuggernautRole { Role = "Administrator"},
                new JuggernautRole { Role = "User"},
                new JuggernautRole { Role = "Guest"}
            };
            roles.ForEach(r => db.JuggernautRoles.Add(r));

            applications[0].Roles.Add(roles[0]);
            applications[1].Roles.Add(roles[1]);
            applications[1].Roles.Add(roles[2]);
            applications[2].Roles.Add(roles[1]);
            applications[2].Roles.Add(roles[2]);
            applications[2].Roles.Add(roles[3]);

            //db.SaveChanges();

            var userApplications = new List<JuggernautUserApplication>
            {
                new JuggernautUserApplication 
                { 
                    User = users[0], 
                    Application = applications[0],
                    UserRoles = new List<JuggernautUserApplicatonRole>
                    {
                        new JuggernautUserApplicatonRole { Role = roles[0]}
                    }
                },
                new JuggernautUserApplication 
                { 
                    User = users[0], 
                    Application = applications[1],
                    UserRoles = new List<JuggernautUserApplicatonRole>
                    {
                        new JuggernautUserApplicatonRole { Role = roles[2]}
                    }
                },
                new JuggernautUserApplication 
                { 
                    User = users[0], 
                    Application = applications[2],
                    UserRoles = new List<JuggernautUserApplicatonRole>
                    {
                        new JuggernautUserApplicatonRole { Role = roles[1]},
                        new JuggernautUserApplicatonRole { Role = roles[2]}
                    }
                },
                new JuggernautUserApplication 
                { 
                    User = users[1], 
                    Application = applications[1],
                    UserRoles = new List<JuggernautUserApplicatonRole>
                    {
                        new JuggernautUserApplicatonRole { Role = roles[1]},
                        new JuggernautUserApplicatonRole { Role = roles[2]}
                    }
                }
            };
            userApplications.ForEach(ua => db.JuggernautUserApplications.Add(ua));
            db.SaveChanges();
        }
    }
}
