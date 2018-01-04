using System.Collections.Generic;
using BBS.Util;

namespace BBS.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BBS.Domain.BbsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BBS.Domain.BbsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            #region Role Initializer

            var roles = new List<Role>
            {
                new Role { Name = Constants.RoleConstants.Unknown},
                new Role { Name = Constants.RoleConstants.Admin},
                new Role { Name = Constants.RoleConstants.Worker},
                new Role { Name = Constants.RoleConstants.Guest}
            };

            roles.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();

            #endregion

            #region Gender Initializer

            var genders = new List<Gender>
            {
                new Gender { Name = Constants.GenderConstants.Unknown},
                new Gender { Name = Constants.GenderConstants.Male},
                new Gender { Name = Constants.GenderConstants.Female}
            };

            genders.ForEach(g => context.Genders.Add(g));
            context.SaveChanges();

            #endregion

            #region User Initializer

            var jevgenij = new User { Name = "Jevgenij", RoleId = Constants.RoleConstants.AdminId, GenderId = Constants.GenderConstants.MaleId };
            var raimundas = new User { Name = "Raimundas", RoleId = Constants.RoleConstants.AdminId, GenderId = Constants.GenderConstants.MaleId };
            var aybars = new User { Name = "Aybars", RoleId = Constants.RoleConstants.WorkerId, GenderId = Constants.GenderConstants.MaleId };

            var users = new List<User>
            {
                jevgenij, raimundas, aybars
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            #endregion

        }
    }
}
