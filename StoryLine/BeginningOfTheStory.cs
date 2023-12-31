using System;

namespace StoryLine
{
    public class BeginningOfTheStory
    {        
        public void Start(Player player)
        {
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("                                              Welcome To StoryLine");
            System.Console.WriteLine();
            System.Console.WriteLine("                                             Press Start To Continue");
            Console.ReadKey();
            Prolog(player);            
        }

        public void Prolog(Player player)
        {
            Console.Clear();
            System.Console.WriteLine("One day, there was a mountain called Mount Sirius which there were many treasures, but there is a dragon guarding the mountain");
            System.Console.WriteLine("          Many warrior have try to get the treasure, but they never come back after go to the mountain");
            System.Console.WriteLine();
            Thread.Sleep(1000);            
            System.Console.WriteLine("            You are a very poor person who has been frustrated. One day, you hear about Mount Sirius.");
            System.Console.WriteLine("                               Because you want to be rich, you go to the mountains");
            Console.ReadKey();
            Main(player);
        }

        public void Main(Player player)
        {                       
            Console.Clear();
            System.Console.WriteLine("Morning");
            Thread.Sleep(1000);
            System.Console.WriteLine();
            System.Console.WriteLine("    You have wake up and go to road. There is a old man that ask your name");
            System.Console.Write("         Enter Your Name : ");            
            var name = Console.ReadLine();
            if(name == null)
                Main(player);
            else if(name == "")
                Main(player);
            else
            {
                player.Name = name;
                StoryAfterPlayerName(player);                              
            }
        }

        public void StoryAfterPlayerName(Player player)
        {
            var name = player.Name;
            RepeatStory repeat = new RepeatStory();

            Console.Clear();   
            System.Console.WriteLine();
            System.Console.WriteLine($"Old Man : {name}?? It's a beautiful name");
            Console.ReadKey();
            System.Console.WriteLine($"Old Man : Have you ever heard about Mount Sirius?");
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("1. I have heard about it");
            System.Console.WriteLine("2. No, I never heard of it");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            while(stringNull == "" || stringNull != "2" && stringNull != "1")
            {
                stringNull = repeat.StoryAfterPlayerName(player);
            }            
            Console.Clear();                    
            var yourChoice = Convert.ToInt32(stringNull);
            if(yourChoice == 1)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Old Man : I will give you some pointers if you want to go there");
                Console.ReadKey();
                System.Console.WriteLine("You     : What is the pointers?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : Never be greedy");
                Console.ReadKey();
                System.Console.WriteLine("You     : What do you mean? You said that is a clue?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : you'll know what I mean soon");
                Console.ReadKey();
                PrepareToGoToTheMountain(player);
            }
            if(yourChoice == 2)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Old Man : There is a mountain that called Mount Sirius which there were many treasure and there is a dragon guarding the mountain");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : Many warrior have try to the treasure, but they never come back after go to the mountain");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : So, What do you think about Mount Sirius?");
                Console.ReadKey();
                System.Console.WriteLine("You     : Very Interesting");     
                Console.ReadKey();            
                System.Console.WriteLine("Old Man : I will give you some pointers if you want to go there");
                Console.ReadKey();
                System.Console.WriteLine("You     : What is the pointers?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : Never be greedy");
                Console.ReadKey();
                System.Console.WriteLine("You     : What do you mean? You said that is a clue?");
                Console.ReadKey();
                System.Console.WriteLine("Old Man : you'll know what I mean soon");
                Console.ReadKey();           
                PrepareToGoToTheMountain(player);
            }
        }

        public void PrepareToGoToTheMountain(Player player)
        {
            RepeatStory repeat = new RepeatStory();
            Console.Clear();
            System.Console.WriteLine("Your Home");
            Thread.Sleep(1000);
            System.Console.WriteLine();
            System.Console.WriteLine("                  When you're at home, you prepare your equipment to go to Mount Sirius");
            System.Console.WriteLine("                            Once you are ready, you see the knife and the bow");
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine("1. Pick up the knife");
            System.Console.WriteLine("2. Pick up the bow");            
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            while(stringNull == "" || stringNull != "2" && stringNull != "1")
            {
                stringNull = repeat.PrepareToGoToTheMountain(player);
            }
            var yourChoice = Convert.ToInt32(stringNull);            
            if(yourChoice == 1)
            {
                player.Weapon = "Knife";                                                                
                System.Console.WriteLine($"                               You pick the {player.Weapon}");
                player.Damage = 10;
                Thread.Sleep(2000);
                GoToTheForest(player);
            }
            if(yourChoice == 2)
            {
                player.Weapon = "Bow";
                System.Console.WriteLine($"                               You pick the {player.Weapon}");
                player.Damage = 15;
                Thread.Sleep(2000);
                GoToTheForest(player);
            }            
        }

        public void GoToTheForest(Player player)
        {
            Enemy huggywuggy = new Enemy("Huggy Wuggy", 100, "Every hit human will increase his damage by 1", "Wooden Sword", 4);                        

            Console.Clear();
            System.Console.WriteLine("Arendelle Forest");
            Thread.Sleep(1000);
            System.Console.WriteLine();
            System.Console.WriteLine($"      When you are in the forest, you meet a {huggywuggy.Name}");
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine("Huggy Wuggy : (laugh) ekk.. ekh.. ");
            Console.ReadKey();
            System.Console.WriteLine("You         : Who the hell are you?");
            Console.ReadKey();
            System.Console.WriteLine("Huggy Wuggy : I'm Huggy Wuggy");
            Console.ReadKey();
            System.Console.WriteLine("Huggy Wuggy : It's a long time no see human in this forest");
            Console.ReadKey();
            System.Console.WriteLine("Huggy Wuggy : Have you ready to died in here? (laugh)");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("Your Mision : Defeated Huggy Wuggy");            
            System.Console.WriteLine("Huggy Wuggy :");
            System.Console.WriteLine($"   Damage dealt : {huggywuggy.Damage}");
            System.Console.WriteLine($"   Skill : {huggywuggy.Skill}");
            Console.ReadKey();

            FightWithHuggyWuggy fight = new FightWithHuggyWuggy();
            fight.FightHuggyWuggy(huggywuggy, player);
        }

        public void AfterDefeatHuggyWuggy(Player player)
        {
            RepeatStory repeat = new RepeatStory();

            Console.Clear();
            Console.WriteLine("Huggy Wuggy : What happened to me? I was defeated by you?");
            Console.ReadKey();
            Console.WriteLine("Huggy Wuggy : I'm Huggy Wuggy. Why an ordinary human like you can beat me?");
            Console.ReadKey();            
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine("                                  Huggy Wuggy has died...");
            System.Console.WriteLine("             Suddenly, Your body emits light and evolves to form new skills ");                    
            Thread.Sleep(2000);
            System.Console.WriteLine();
            System.Console.WriteLine("Choose your skill : ");
            System.Console.WriteLine(" 1. Strength Enhance : Enhance your strength by 25 every your skill active");
            System.Console.WriteLine(" 2. Lifesteal : Heals 50% of current health after attack the enemy");
            System.Console.WriteLine(" 3. Perfect Defense : Immune to every enemy attack");
            System.Console.Write("");
            var stringNull = Console.ReadLine();
            while(stringNull == "" || stringNull != "2" && stringNull != "1" && stringNull != "3")
            {
                stringNull = repeat.AfterDefeatHuggyWuggy(player);
            }
            var yourChoice = Convert.ToInt32(stringNull);
            if(yourChoice == 1)
            {
                player.Skill = "Strength Enhance : Enhance your strength by 25 every your skill active";
                System.Console.WriteLine();
                System.Console.WriteLine($"          Your choice is {player.Skill}");
            }
            if(yourChoice == 2)
            {
                player.Skill = "Lifesteal : Heals 50% of current health after attack the enemy";
                System.Console.WriteLine();
                System.Console.WriteLine($"          Your choice is {player.Skill}");
            }    
            if(yourChoice == 3)
            {
                player.Skill = "Perfect Defense : Immune to every enemy attack";
                System.Console.WriteLine();
                System.Console.WriteLine($"          Your choice is {player.Skill}");
            }                
        }                        
    }   
}