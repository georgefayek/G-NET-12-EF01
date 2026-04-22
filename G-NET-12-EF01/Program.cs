using G_NET_12_EF01.Data;

namespace G_NET_12_EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Create Database
                context.Database.EnsureCreated();

                Console.WriteLine("Database Created Successfully!");
            }

            Console.ReadKey();
        }
    }
    }

