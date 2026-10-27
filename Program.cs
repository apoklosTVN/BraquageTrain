
using System.Security.Cryptography;

namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */


        int carriages = 0;
        int coins;
        int coinsinchest;
        int totalcoins = 0;

        Random rand = new Random();
        

         Console.WriteLine("You have been dropped on top of a moving train, you have been ordered to search through all the carriages. ");
         System.Console.WriteLine("Press any key...");
         Console.ReadKey();
         System.Console.WriteLine("How many carriages are you going to look through? (1 to 16)");
        while (true)
        {
           try
           {
            carriages = Convert.ToInt32(Console.ReadLine());
           }
            catch (FormatException)
            {
                System.Console.WriteLine("This isn't a number");
            }
                if(carriages <= 16 || carriages > 0)
            {
                break;
            }

        }
         Console.WriteLine("You are now inspecting the storage containers");
         for(int i = 1; i < carriages+1; i++)
        {
            System.Console.WriteLine($"Inspecting carriage {i}");
            for(int j = 1; j < 5; j++)
            {
                coinsinchest = rand.Next(0,5);
                System.Console.WriteLine($"Opening chest {j}");
                coins = coinsinchest;
                totalcoins = Math.Abs(totalcoins + coins);
            }
            System.Console.WriteLine($"You have found {totalcoins}");
        }
            System.Console.WriteLine($"You have looked through {carriages*4} chests.");
            System.Console.WriteLine($"You have escaped with {totalcoins} coins.");
    }
}   
