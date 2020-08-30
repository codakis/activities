using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Data
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.MainActivities.Any())
            {
                var activities = new List<MainActivity>
                {

                    new MainActivity
                    {
                        Title = "Past Activity 1",
                        Description = "Activity 2 months ago",
                        Category = "drinks",
                        City = "London",
                        Venue = "Pub",
                        Date = DateTime.Now.AddMonths(-2)

                    },
                    new MainActivity
                    {
                        Title = "Past Activity 2",
                        Description = "Activity 1 month ago",
                        Category = "culture",
                        City = "Paris",
                        Venue = "Louvre",
                        Date = DateTime.Now.AddMonths(-1)
                    },
                    new MainActivity
                    {
                        Title = "Future Activity 1",
                        Description = "Activity 1 month in future",
                        Category = "culture",
                        City = "London",
                        Venue = "Natural History Museum",
                        Date = DateTime.Now.AddMonths(1)

                    },
                    new MainActivity
                    {
                        Title = "Future Activity 2",
                        Description = "Activity 2 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "O2 Arena",
                        Date = DateTime.Now.AddMonths(2)

                    },
                    new MainActivity
                    {
                        Title = "Future Activity 3",
                        Description = "Activity 3 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Another pub",
                        Date = DateTime.Now.AddMonths(3),

                    },
                    new MainActivity
                    {
                        Title = "Future Activity 4",
                        Description = "Activity 4 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Yet another pub",
                        Date = DateTime.Now.AddMonths(4)

                    },
                    new MainActivity
                    {
                        Title = "Future Activity 5",
                        Description = "Activity 5 months in future",
                        Category = "drinks",
                        City = "London",
                        Venue = "Just another pub",
                        Date = DateTime.Now.AddMonths(5)

                    },
                    new MainActivity
                    {
                        Title = "Future Activity 6",
                        Description = "Activity 6 months in future",
                        Category = "music",
                        City = "London",
                        Venue = "Roundhouse Camden",
                        Date = DateTime.Now.AddMonths(6)

                    },
                    new MainActivity
                    {
                        Title = "Future Activity 7",
                        Description = "Activity 2 months ago",
                        Category = "travel",
                        City = "London",
                        Venue = "Somewhere on the Thames",
                        Date = DateTime.Now.AddMonths(7)

                    },
                    new MainActivity
                    {
                        Title = "Future Activity 8",
                        Description = "Activity 8 months in future",
                        Category = "film",
                        City = "London",
                        Venue = "Cinema",
                        Date = DateTime.Now.AddMonths(8)

                    }
                };
                context.MainActivities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}