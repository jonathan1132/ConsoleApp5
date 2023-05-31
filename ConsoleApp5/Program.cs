using System.Xml.Serialization;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali kas 1 ( Average ), 2 ( Any ), 3 ( If ja else faili loomine ) või 4 ( Püramiid )");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    AverageLINQ();
                    break;
                case 2:
                    AnyLINQ();
                    break;
                case 3:
                    IfjaElse();
                    break;
                case 4:
                    Pyramiid();
                    break;
            }
        }

        static void AverageLINQ()
        {
            Console.WriteLine("Average LINQ");
            var averageResult = PeopleList.peoples
                .Average(x => x.Age);

            Console.WriteLine(averageResult);
        }
        public class People
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Guid GenderId { get; set; }
        }
        public class PeopleList
        {
            public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
                        new People()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
                }
            };
        }
        static void AnyLINQ()
        {
            Console.WriteLine("Any LINQ");
            bool isAnyPersonTeenager = PeopleList.peoples
                .Any(x => x.Age > 18);
            //kasvõi üks  andmerida vastab tingimustele, siis tuelb vastus
            Console.WriteLine(isAnyPersonTeenager);
        }
        static void IfjaElse()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
                "veateate. Kui on õige, siis ütleb, " +
                "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/Ingvar/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/opilane/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }

        }
        static void Pyramiid()
        {

            {
                int i, j, rows;

                Console.WriteLine("Numbri püramiid");

                Console.WriteLine("Sisesta ridade arv");

                rows = Convert.ToInt32(Console.ReadLine());


                for (i = 0; i <= rows; i++)
                {
                    for (j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        //Console.Write("{0} ", t++);
                        Console.Write("*"); //kui paned selle, siis saad püramiidi
                    }
                    Console.Write("\n");
                }

                for (i = rows - 1; i >= 1; i--)
                {
                    for (j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}

