using Model.DBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbInit : CreateDatabaseIfNotExists<GCContext>
    {
        protected override void Seed(GCContext context)
        {
            Person p1 = new Person()
            {
                Name = "Espen Nordli"
            };
            Person p2 = new Person()
            {
                Name = "Daniel Dysjeland"
            };
            Person p3 = new Person()
            {
                Name = "Knut Åge Hofseth"
            };
            Person p4 = new Person()
            {
                Name = "Kristine Helle"
            };

            Level l1 = new Level() {
                LevelNumber = 1,
                XPBreakPoint = 100

            };
            Level l2 = new Level()
            {
                LevelNumber = 2,
                XPBreakPoint = 200

            };
            Level l3 = new Level()
            {
                LevelNumber = 3,
                XPBreakPoint = 400

            };
            Level l4 = new Level()
            {
                LevelNumber = 4,
                XPBreakPoint = 800 

            };

            PersonGameStats pgs1 = new PersonGameStats() {
                Person = p1,
                XP = 0,
                Coins = 0,
                Level = l1
            };

            PersonGameStats pgs2 = new PersonGameStats()
            {
                Person = p2,
                XP = 0,
                Coins = 0,
                Level = l1
            };

            PersonGameStats pgs3 = new PersonGameStats()
            {
                Person = p3,
                XP = 0,
                Coins = 0,
                Level = l1
            };

            PersonGameStats pgs4 = new PersonGameStats()
            {
                Person = p4,
                XP = 0,
                Coins = 0,
                Level = l1
            };

            context.Persons.Add(p1);
            context.Persons.Add(p2);
            context.Persons.Add(p3);
            context.Persons.Add(p4);

            context.Levels.Add(l1);
            context.Levels.Add(l2);
            context.Levels.Add(l3);
            context.Levels.Add(l4);

            context.PersonGameStats.Add(pgs1);
            context.PersonGameStats.Add(pgs2);
            context.PersonGameStats.Add(pgs3);
            context.PersonGameStats.Add(pgs4);
               


            base.Seed(context);
        }
    }
}