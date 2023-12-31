using System;

namespace StoryLine
{
    public class RepeatStory
    {
        public string? StoryAfterPlayerName(Player player)
        {
            var name = player.Name;
            Console.Clear();
            System.Console.WriteLine();            
            System.Console.WriteLine($"Old Man : {name}?? It's a beautiful name");            
            System.Console.WriteLine($"Old Man : Have you ever heard about Mount Sirius?");            
            System.Console.WriteLine();
            System.Console.WriteLine("1. I have heard about it");
            System.Console.WriteLine("2. No, I never heard of it");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? PrepareToGoToTheMountain(Player player)
        {            
            Console.Clear();
            System.Console.WriteLine("Your Home");            
            System.Console.WriteLine("                  When you're at home, you prepare your equipment to go to Mount Sirius");
            System.Console.WriteLine("                            Once you are ready, you see the knife and the bow");
            System.Console.WriteLine();            
            System.Console.WriteLine("1. Pick up the knife");
            System.Console.WriteLine("2. Pick up the bow");            
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? AfterDefeatHuggyWuggy(Player player)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("                                  Huggy Wuggy has died...");
            System.Console.WriteLine("             Suddenly, Your body emits light and evolves to form new skills ");                                
            System.Console.WriteLine();
            System.Console.WriteLine("Choose your skill : ");
            System.Console.WriteLine(" 1. Strength Enhance : Enhance your strength by 25 every your skill active");
            System.Console.WriteLine(" 2. Lifesteal : Heal 50% health every attacked the enemy");
            System.Console.WriteLine(" 3. Perfect Defense : Immune to every enemy attack");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? OnArendelleForest(Player player)
        {
            Console.Clear();
            System.Console.WriteLine("Arendelle Forest");
            System.Console.WriteLine();
            System.Console.WriteLine("                  You Meet With Old Man Again");
            System.Console.WriteLine();
            System.Console.WriteLine("1. Talk To Him");
            System.Console.WriteLine("2. Ignore Him");
            var stringNull = Console.ReadLine();  
            return stringNull;
        }

        public void OnArendelleForest(Player player, int yourChoice)
        {
            if(yourChoice == 1)
            {
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine("You     : Yoo... Old man, What are you doing in here?");
            }
            if(yourChoice == 2)
            {
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine("Old Man : Yoo.... Young man, Have you ever thought you should say something when old man are around?");
                Console.ReadKey();
                System.Console.WriteLine("You     : Sorry, I didn't see you");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : I thought you did it on purpose");
                Console.ReadKey();
                System.Console.WriteLine("You     : (Laugh)Hahahahaaa.....");
                Console.ReadKey();
                System.Console.WriteLine("You     : Alright old man, What are you doing in here?");
            }
            Console.ReadKey();
            System.Console.WriteLine("Old Man : Nothing, Just walking around");
            Console.ReadKey();
            System.Console.WriteLine("You     : Well, I thought you in the village");
            Console.ReadKey();
            System.Console.WriteLine("Old Man : You know, sometimes people can get bored in the village");
            Console.ReadKey();
            System.Console.WriteLine("Old Man : I see you look very good. Did your journey go well?");
            Console.ReadKey();
            System.Console.WriteLine("You     : Maybe, not bad for today");
            Console.ReadKey();
        }

        public string? AfterGoblinKingDead(Player player)
        {
            Console.Clear();
            System.Console.WriteLine("                                          You Defeat The Goblin King");
            Thread.Sleep(1000);
            System.Console.WriteLine("                                      Choose the weapon you want to claim");
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine("1. Sword");
            System.Console.WriteLine("2. Axe");
            System.Console.WriteLine("3. Polearm");
            var stringNull = Console.ReadLine();
            return stringNull;
        }

        public string? AfterChooseTheWeapon(Player player)
        {
            
            System.Console.WriteLine("                                      After that, you follow the path to Mount Sirius.");
            System.Console.WriteLine();            
            System.Console.WriteLine("You : I feel so tired");            
            System.Console.WriteLine("You : Should I take a break or continue this journey?");            
            System.Console.WriteLine();
            System.Console.WriteLine("1. Take a break");
            System.Console.WriteLine("2. Continue this journey");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            return stringNull;
        }                

        public string? GoblinKingSkillActived()
        {
            System.Console.WriteLine("Goblin King : Ack... Please!! Don't kill me!! I'll give all my valuables");
            Console.ReadKey();
            System.Console.WriteLine("                              Goblin king took out all the valuables");
            System.Console.WriteLine("                                     Do you want to take it?");
            System.Console.WriteLine();
            System.Console.WriteLine("                                       1) Yes      2) No");
            var stringNull = Console.ReadLine();
            return stringNull;
        }
    }
}