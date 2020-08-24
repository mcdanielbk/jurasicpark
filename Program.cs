using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Jurassic park!");
      Console.WriteLine("here are your current dinosaurs");
      var directory = new DinosaursDirectory();

      var isRunning = true;
      while (isRunning)
      {

        foreach (var dinosaur in directory.dinos)
        {
          Console.WriteLine($"{dinosaur.Name} is a {dinosaur.DietType} and weighs {dinosaur.Weight} in {dinosaur.EnclosureNumber}. It was aquired at {dinosaur.DateAquired}.");
        }

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("(ADD), (REMOVE), (TRANSFER), (VIEW) or (QUIT)");
        var input = Console.ReadLine().ToLower();
        if (input == "add")
        {
          Console.WriteLine("What dinosaur would you like to add");
          var name = Console.ReadLine();
          Console.WriteLine("What type of diet?");
          var diet = Console.ReadLine();
          Console.WriteLine("How much does it weigh?");
          int weight = int.Parse(Console.ReadLine());
          Console.WriteLine("what enclosure number would you like to add this dinosaur to?");
          int enclosure = int.Parse(Console.ReadLine());

          directory.AddANewDino(name, diet, weight, enclosure);
        }
        else if (input == "remove")
        {
          Console.WriteLine("what do you want remove");
          var Dino = Console.ReadLine();
          directory.RemoveDino(Dino);
        }
        else if (input == "transfer")
        {
          Console.WriteLine("which dinosaur would you like to transfer?");
          var dinoToTrans = Console.ReadLine();
          Console.WriteLine("from which pen?");
          var currentEnclosure = int.Parse(Console.ReadLine());
          Console.WriteLine($"where do you want to put{dinoToTrans}?");
          var newEnclosure = int.Parse(Console.ReadLine());
        }
        else if (input == "view")
        {
          Console.WriteLine("would you like to view (ALL),by (DIET) or by (HEAVIEST)?");
          var view = Console.ReadLine();
          if (view == "all")
          {
            foreach (var dinosaur in directory.dinos)
            {
              Console.WriteLine($"{dinosaur.Name} is a {dinosaur.DietType} and weighs {dinosaur.Weight} in enclosure {dinosaur.EnclosureNumber}");
            }
          }
          if (view == "diet")
          {
            Console.WriteLine("herbivore or carnivore?");
            var herbOrCarn = Console.ReadLine();
            if (herbOrCarn == "herbivore")
            {
              Console.WriteLine($"these are your herbivores {directory.ViewDinoDietH()}");
            }
            else if (herbOrCarn == "carnivore")
            {
              Console.WriteLine($"these are your carnivores {directory.ViewDinoDietC()}");
            }
          }
          if (view == "heaviest")
          {
            Console.WriteLine("these are the 3 heaviest dinos?");
          }
        }
        else if (input == "quit")
        {
          isRunning = false;
        }
      }
    }
  }
}