using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdHunter
{
    public class BirdHunterRepository
    {
        List<string> actionList = new List<string>();

        public void DrofsnarAttacks()
        {
            string input = "Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,InvincibleBirdHunter,EveningGrosbeak,GreaterPrairieChicken,VulnerableBirdHunter,VulnerableBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,IcelandGull,CrestedIbis,GreatKiskudee,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,Bird,RedCrossbill,Red-neckedPhalarope,InvincibleBirdHunter,VulnerableBirdHunter,Orange-belliedParrot,InvincibleBirdHunter,Bird,Bird,Bird,Bird,Bird,VulnerableBirdHunter";

            string[] words = input.Split(',');

            foreach (var word in words)
            {
                actionList.Add(word);
                Console.WriteLine(word);
            }

            Drofsnar name = new Drofsnar();
            int lives = name.Lives;
            int points =  name.Points;

            int vbhCount = 0;
            int lifeBonus = 0;

            while (lives > 0)
            {
                foreach (String item in actionList)
                {
                    switch (item)
                    {
                        case "Bird":
                            points += 10;
                            break;
                        case "CrestedIbis":
                            points += 100; 
                            break;
                        case "GreatKiskudee":
                            points += 300; 
                            break;
                        case "RedCrossbill":
                            points += 500; 
                            break;
                        case "Red-neckedPhalarope":
                            points += 700; 
                            break;
                        case "EveningGrosbeak":
                            points += 1000; 
                            break;
                        case "GreaterPrairieChicken":
                            points += 2000; 
                            break;
                        case "IcelandGull":
                            points += 3000; 
                            break;
                        case "Orange-belliedParrot":
                            points += 5000; 
                            break;
                        case "VulnerableBirdHunter":
                            if (vbhCount == 0)
                            {
                                points += 200;
                                vbhCount += 1;
                            }
                            else if (vbhCount == 1)
                            {
                                points += 400;
                                vbhCount += 1;
                            }
                            else if (vbhCount == 2)
                            {
                                points += 800;
                                vbhCount += 1;
                            }
                            else if (vbhCount == 3)
                            {
                                points += 1600;
                                vbhCount = 0;
                            }
                            break;
                        case "InvincibleBirdHunter":
                            lives -= 1;
                            vbhCount = 0;
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Attacked: " + item + " " + "Points: " + points + " " + "Lives: " + lives);

                    if (points >= 10000 && lifeBonus == 0)
                    {
                        lives += 1;
                        lifeBonus += 1;
                    }
                }
            }
            Console.WriteLine("Drofsnar has 0 lives remainging. Game over.");
            Console.WriteLine("Drofsnar total points: " + points);
        }
    }

    public class Animal
    {
        public string Location { get; set; }
        public string SkinType { get; set; }
        public string TravelType { get; set; }
        public string Hint { get; set; }

        public Animal(string location, string skinType, string travelType, string hint)
        {
            Location = location;
            SkinType = skinType;
            TravelType = travelType;
            Hint = hint;
        }
    }
}
