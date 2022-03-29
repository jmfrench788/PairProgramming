using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Program_UI
    {
        public void Run()
        {
            SeedData();
            RunApplication();
        }

    

    private void RunApplication()
    {
        bool isRunning = true;
        while(isRunning)
        {
            System.Console.WriteLine("Info: You can enter 0 to exit at any time.");
            System.Console.WriteLine("You wake up in an empty room. You seem to be in room 30. There are 2 doors labeled 6 and 17. Which one would you like to enter?");
            var input = Console.ReadLine();

            switch(input)
            {
                case "6":
                Cube6();
                break;

                case "17":
                Cube17();
                break;

                case "0":
                isRunning = CloseApplication();
                break;

                default:
                System.Console.WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                break;
            }

        }
    }

      private void Cube30()
    {
       System.Console.WriteLine("You are in room 30. There are doors labeled 6 and 17. Which would you like to enter?");
       var input = Console.ReadLine();

       
            switch(input)
            {
                case "6":
                Cube6();
                break;

                case "17":
                Cube17();
                break;

                case "0":
                CloseApplication();
                break;

                default:
                System.Console.WriteLine("Invalid Selection");
                PressAnyKeyToContinue();
                Cube30();
                break;
            }
    }

    private void Cube17()
    {
        //SPIKE TRAP
        //Lose 1 life, update player lives
        //30,100
    }

    private void Cube6()
    {
        System.Console.WriteLine("The room is safe. There are doors labeled 30, 99, and 100. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "30":
            Cube30();
            break;

            case "99":
            Cube99();
            break;

            case "100":
            Cube100();
            break;

            case "0":
            CloseApplication();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;



        }
    }

    private void Cube100()
    {
        //6, 17, 73, 97
    }

    private void Cube99()
    {
        //6,97,150
    }

  

  private void Cube150()
    {
        //99,25
    }

     private void Cube97()
    {
        //Trap reset
    }

    private void Cube25()
    {
        //150,33,97
    }

    private void Cube33()
    {
        //25,55,2
    }

    private void Cube55()
    {
        //73,97,33,44
    }

    private void Cube73()
    {
        //trap lose 1 life
        //100,15,10,55
    }

    private void Cube2()
    {
        //trap lose 1 life;
        //33,44,67
    }

    private void Cube44()
    {
        //55,10,2,86
    }

    private void Cube10()
    {
        //73,44,4,53
    }

    private void Cube4()
    {
        //15,10,29
    }

    private void Cube15()
    {
        //END, need key to exit
        //73,4,17
    }

    private void Cube67()
    {
        //Trap return to start
    }

    private void Cube86()
    {
        //key location, update player.HasKey
        //44,67,53
    }

    private void Cube53()
    {
        //Trap lose 1 life
        //29,10,86
    }

    private void Cube29()
    {
        //Trap, lose 1 life
        //4,53
    }
  
    private void PressAnyKeyToContinue()
    {
        System.Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    private void SeedData()
    {
        var player = new Player(2, 200);
    }

    private bool CloseApplication()
    {
        Console.Clear();
        System.Console.WriteLine("Thanks!!!");
        PressAnyKeyToContinue();
        return false;
    }
}
