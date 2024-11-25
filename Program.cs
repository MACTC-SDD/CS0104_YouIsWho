namespace CS0104_YouIsWho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Complete the code in the methods to print out the truth tables
            // Look for where it says "Your Code Goes Here"
            Console.WriteLine("----- Truth Tables -----");
            PrintAndTruthTable();
            PrintOrTruthTable();
            PrintNotTruthTable();

            // Complete the code in the methods to return the correct boolean value
            // Look for where it says "Your Code Goes Here"
            Console.WriteLine("----- Can Go To Movie -----");
            Console.WriteLine(CanGoToMovie(16, false, 20, 10, "PG-13")); // True
            Console.WriteLine(CanGoToMovie(12, false, 15, 10, "R")); // False
            Console.WriteLine(CanGoToMovie(12, true, 20, 10, "R")); // True
            Console.WriteLine(CanGoToMovie(19, false, 8, 10, "R")); // False
            Console.WriteLine("\n\n");

            Console.WriteLine("----- Can Tame Animal -----");
            Console.WriteLine(CanTameAnimal(true, 10, 5, false)); // True
            Console.WriteLine(CanTameAnimal(false, 10, 5, false)); // False
            Console.WriteLine(CanTameAnimal(true, 10, 5, true)); // False
            Console.WriteLine("\n\n");

            Console.WriteLine("----- Can Sleep In Bed -----");
            Console.WriteLine(CanSleepInBed(true, false, true, false)); // True
            Console.WriteLine(CanSleepInBed(false, true, true, false)); // True
            Console.WriteLine(CanSleepInBed(true, false, false, false)); // False
            Console.WriteLine("\n\n");

            Console.WriteLine("----- Can Settle In Village -----");
            Console.WriteLine(CanSettleInVillage(20, true, false, false)); // True
            Console.WriteLine(CanSettleInVillage(20, true, true, false)); // False
            Console.WriteLine(CanSettleInVillage(10, false, false, false)); // False
            Console.WriteLine("\n\n");

            Console.WriteLine("----- Can Rescue Captive Villager -----");
            Console.WriteLine(CanRescueCaptiveVillager(true, true, true, false, true, false)); // True
            Console.WriteLine(CanRescueCaptiveVillager(false, false, false, true, true, false)); // False
            Console.WriteLine(CanRescueCaptiveVillager(true, true, true, false, false, true)); // True
            Console.WriteLine("\n\n");

        }

        /// <summary>
        /// Show the outcome of each combination for the AND operator
        /// There will be four lines, the first line should look like:
        /// 'true' and 'true' = 'true'
        /// </summary>
        public static void PrintAndTruthTable()
        {
            Console.WriteLine("AND Truth Table");
            
            // Your Code Goes Here

            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Show the outcome of each combination for the OR operator
        /// There will be four lines, the first line should look like:
        /// 'true' and 'true' = 'true'
        /// </summary>
        public static void PrintOrTruthTable()
        {
            Console.WriteLine("OR Truth Table");

            // Your Code Goes Here

            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// Show the outcome of each combination for the NOT operator
        /// There will be two lines, the first line should look like:
        /// not 'true'  = 'false'
        /// </summary>
        public static void PrintNotTruthTable()
        {
            Console.WriteLine("NOT Truth Table");

            // Your Code Goes Here

            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// To go to a movie, the following conditions must be met:
        /// If the movie is rated 'R', the person must be at least 17 years old or have a parent with them
        /// If the movie is rated 'PG-13', the person must be at least 13 years old or have a parent with them
        /// If the movie is rated 'PG', the person must be at least 8 years old or have a parent with them
        /// If the movie is rated 'G', the person must be at least 5 years old or have a parent with them
        /// You must have more cash than the cost of the movie
        /// </summary>
        public static bool CanGoToMovie(int age, bool hasParent, int cash, int movieCost, string movieRating)
        {
            // Your Code Goes Here

            return false;
        }

        /// <summary>
        /// Are you able to tame an animal in Minecraft
        /// You must have the materials to tame the animal
        /// The range to the animal must be less than or equal to the taming range
        /// The animal must not already be tamed
        /// </summary>
        public static bool CanTameAnimal(bool hasMaterials, int range, int tamingRange, bool isTamed)
        {
            // Your Code Goes Here

            return false;
        }

        /// <summary>
        /// Can you sleep in a bed in Minecraft
        /// It must be night time or storming
        /// Must be in bed
        /// There must not be mobs nearby
        /// </summary>
        public static bool CanSleepInBed(bool isNight, bool isStorming, bool inBed, bool mobsNearby)
        {
            // Your Code Goes Here

            return false;
        }

        /// <summary>
        /// Can you settle in a village in Minecraft? 
        /// Requires at least 20 emeralds and to be friendly with the villagers
        /// Requires to have not raided the village before or have trade goods
        /// </summary>
        public static bool CanSettleInVillage(int emeralds, bool isFriendlyWithVillagers, bool hasRaidedBefore, bool hasTradeGoods)
        {
            // Your Code Goes Here

            return false;
        }

        /// <summary>
        /// Can you rescue a captive villager in Minecraft?
        /// Requires armor, sword, and shield or sneaking skill
        /// Requires it to be daytime or have distracted pillagers
        /// </summary>
        public static bool CanRescueCaptiveVillager(bool hasArmor, bool hasSword, bool hasShield, bool hasSneakingSkill, bool isDaytime, bool hasDistractedPillagers)
        {
            // Your Code Goes Here

            return false;
        }


    }



}
