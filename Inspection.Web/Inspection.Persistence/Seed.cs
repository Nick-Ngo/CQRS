using Inspection.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspection.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity {
                    Title = "A1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 1",
                    Category = "Drinks"
                },
                new Activity {
                    Title = "A2",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2",
                    Category = "Culture"
                },
                new Activity {
                    Title = "A3",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 3",
                    Category = "Film"
                },
                new Activity {
                    Title = "A4",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 4",
                    Category = "Drinks"
                },
                new Activity {
                    Title = "A5",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 5",
                    Category = "Drinks"
                },
                new Activity {
                    Title = "A6",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 6",
                    Category = "Film"
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}
