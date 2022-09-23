using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadaTest
{
    public class App
    {


        public void Run() {
        }

        public void zadani()
        {
            var line = string.Empty;
            StreamReader a = new StreamReader("input.txt.");
            List<Api> ListikBlato = new List<Api>();

            while ((line = a.ReadLine()) != null)
            {
                var splitted = line.Split(";");
                ListikBlato.Add(new Api
                {
                    Id = int.Parse(splitted[0]),
                    User = int.Parse(splitted[1]),
                    Type = splitted[2],
                    Map = splitted[3],
                    score = int.Parse(splitted[4]),
                    Winlose = int.Parse(splitted[5]),
                    kd = int.Parse(splitted[6]),
                    scorePerMinute = int.Parse(splitted[7]),

                });



            }

            while (true)
            {
                Console.WriteLine("Ahoj zadej user id a pokud jsi srac tak zmackni 0 abys odesel");
                var ahmed = int.Parse(Console.ReadLine());

                foreach (var ListItem in ListikBlato)
                {
                    if (ListItem.User == ahmed)
                    {
                        var mathLadaFrajer = ListItem.score / ListItem.scorePerMinute;
                        Console.WriteLine($"Type {ListItem.Type}, score {ListItem.score} and lenght of match {mathLadaFrajer}");
                    }

                    if (ahmed == 0)
                    {
                        break;
                    }
                }

            }


        }
    }


    
    public class Api
    {
        public int Id { get; set; } 
        public int User { get; set; }
        public string Type { get; set; }
        public string Map { get; set; }
        public int score { get; set; }
        public int Winlose { get; set; }
        public int kd { get; set; }
        public int scorePerMinute { get; set; }

    }
}
