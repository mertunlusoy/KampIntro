using System;

namespace Day_2_QUIZ_Basit_Basketbolcu_Takip_Sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Basketballer player1 = new Basketballer { Name = "Ahmet", Age = 21, Size = 1.86 };
            Basketballer player2 = new Basketballer { Name = "Mehmet", Age = 27, Size = 1.83 };
            Basketballer player3 = new Basketballer { Name = "Can", Age = 32, Size = 1.79 };
            Basketballer player4 = new Basketballer { Name = "Özgür", Age = 24, Size = 1.89 };

            Basketballer[] players = new Basketballer[] { player1, player2, player3, player4 };

            foreach (Basketballer player in players)
            {
                if (player.Size >= 1.85)
                {
                    Console.WriteLine("Ad:" + player.Name + "Yaş:" + player.Age + "Boy:" + player.Size + "Boy Grubu: Uzun");
                }
                else
                {
                    Console.WriteLine("Ad:" + player.Name + "Yaş:" + player.Age + "Boy:" + player.Size + "Boy Grubu: Kısa");
                }
            }

            }
        }
    }

    class Basketballer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public double Size { get; set; }
    }
