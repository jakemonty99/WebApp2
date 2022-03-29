using WebApp2.Models;

namespace WebApp2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Inventory context)
        {
            // Look for any students.
            if (context.Chemicals.Any())
            {
                return;   // DB has been seeded
            }

            var chemicals = new Chemical[]
            {
                new Chemical{ID=001,ame="Carson",vendor="Alexander",sds=true},
                new Chemical{ID=002,ame="Meredith",vendor="Alonso",sds=false}
            };

            context.Chemicals.AddRange(chemicals);
            context.SaveChanges();
        }
    }
}