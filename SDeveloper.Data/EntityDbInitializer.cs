using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SDeveloper.Data
{
    public class EntityDbInitializer : DropCreateDatabaseAlways<EfContext>
    {
        protected override void Seed(EfContext context)
        {
            context.Entities.AddRange(new List<Entity>
            {
                new Entity
                {
                    Id = 1,
                    Created = DateTime.Now,
                    Type = "type1",
                    Content = "type1 type1 type1 type1 type1 type1 type1"
                },
                new Entity
                {
                    Id = 2,
                    Created = DateTime.Now,
                    Type = "type2",
                    Content = "type2 type2 type2 type2 type2 type2 type2"
                },
                new Entity
                {
                    Id = 3,
                    Created = DateTime.Now,
                    Type = "type1",
                    Content = "type1 type1 type1 type1 type1 type1 type1 type1"
                },
                new Entity
                {
                    Id = 4,
                    Created = DateTime.Now,
                    Type = "type3",
                    Content = "type3 type3 type3 type3 type3 type3"
                },
                new Entity
                {
                    Id = 5,
                    Created = DateTime.Now,
                    Type = "type4",
                    Content = "type4 type4 type4 type4 type4 type4 type4"
                },
                new Entity
                {
                    Id = 6,
                    Created = DateTime.Now,
                    Type = "type3",
                    Content = "type3 type3 type3 type3 type3"
                },
                new Entity
                {
                    Id = 7,
                    Created = DateTime.Now,
                    Type = "type5",
                    Content = "type5 type5 type5 type5 type5 type5"
                }
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
