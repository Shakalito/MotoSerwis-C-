using MotoSerwis.Data.Entities;

namespace MotoSerwis.Data.Seed
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Clients.Any())
            {
                var clients = new List<Client>()
                {
                    new Client() { FirstName = "Jan", LastName = "Kowalski", PhoneNumber = "123323123", Address = "Rzeszów, Kopisto 1" },
                    new Client() { FirstName = "Mariusz", LastName = "Testowy", PhoneNumber = "321123412", Address = "Lublin, Powstańców 2" },
                    new Client() { FirstName = "Adam", LastName = "Nowak", PhoneNumber = "512123542", Address = "Kraków, Rynek 3" }
                };
                context.Clients.AddRange(clients);

            }

            if (!context.Makes.Any())
            {
                var makes = new List<Make>
            {
                new Make { Name = "Yamaha", Models = new List<Model>
                {
                    new() { Name = "MT-07" },
                    new() { Name = "MT-09" },
                    new() { Name = "R1" },
                    new() { Name = "Tracer 9" },
                    new() { Name = "XSR900" }
                }},
                new Make { Name = "Honda", Models = new List<Model>
                {
                    new() { Name = "CBR500R" },
                    new() { Name = "CB650R" },
                    new() { Name = "Africa Twin" },
                    new() { Name = "Rebel 500" },
                    new() { Name = "NC750X" }
                }},
                new Make { Name = "Kawasaki", Models = new List<Model>
                {
                    new() { Name = "Z650" },
                    new() { Name = "Z900" },
                    new() { Name = "Ninja 650" },
                    new() { Name = "Versys 1000" },
                    new() { Name = "Vulcan S" }
                }},
                new Make { Name = "Suzuki", Models = new List<Model>
                {
                    new() { Name = "GSX-R600" },
                    new() { Name = "SV650" },
                    new() { Name = "V-Strom 650" },
                    new() { Name = "Boulevard M109R" },
                    new() { Name = "GSX-S750" }
                }},
                new Make { Name = "BMW", Models = new List<Model>
                {
                    new() { Name = "R1250GS" },
                    new() { Name = "S1000RR" },
                    new() { Name = "F900R" },
                    new() { Name = "G310R" },
                    new() { Name = "R nineT" }
                }},
                new Make { Name = "Ducati", Models = new List<Model>
                {
                    new() { Name = "Panigale V4" },
                    new() { Name = "Monster 937" },
                    new() { Name = "Multistrada V4" },
                    new() { Name = "Scrambler Icon" },
                    new() { Name = "Diavel V4" }
                }},
                new Make { Name = "Harley-Davidson", Models = new List<Model>
                {
                    new() { Name = "Iron 883" },
                    new() { Name = "Street Bob" },
                    new() { Name = "Fat Bob" },
                    new() { Name = "Sportster S" },
                    new() { Name = "Road Glide" }
                }},
                new Make { Name = "KTM", Models = new List<Model>
                {
                    new() { Name = "Duke 390" },
                    new() { Name = "Duke 890" },
                    new() { Name = "1290 Super Duke R" },
                    new() { Name = "790 Adventure" },
                    new() { Name = "450 EXC-F" }
                }},
                new Make { Name = "Triumph", Models = new List<Model>
                {
                    new() { Name = "Street Triple" },
                    new() { Name = "Tiger 900" },
                    new() { Name = "Bonneville T120" },
                    new() { Name = "Rocket 3" },
                    new() { Name = "Speed Twin" }
                }},
                new Make { Name = "Aprilia", Models = new List<Model>
                {
                    new() { Name = "RS 660" },
                    new() { Name = "Tuono V4" },
                    new() { Name = "Tuareg 660" },
                    new() { Name = "Shiver 900" },
                    new() { Name = "Dorsoduro 900" }
                }}};

                context.Makes.AddRange(makes);
            }

            context.SaveChanges();
        }
    }
}
