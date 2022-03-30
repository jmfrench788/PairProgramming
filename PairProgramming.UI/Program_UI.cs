using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Program_UI
    {
        

        private readonly Player_Repo _pRepo = new Player_Repo();

        Player player = new Player(2,200, false);
        


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
            System.Console.WriteLine("Info: You can enter 0 to go back to the start at any time.");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("You wake up in an empty room. You seem to be in room 30. There are 2 doors labeled 6 and 17. Which one would you like to enter? \n" +
            "--To exit the game, press 0.--");
            

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
       //add score
    
        System.Console.WriteLine("         ");
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
        System.Console.WriteLine("         ");
        System.Console.WriteLine("You ran into a spike trap and lost a life.");
        
        UpdatePlayerInfo(player, 1, 100);

        if(player.Lives == 0)
        {
            
            System.Console.WriteLine("YOU DIED--STARTING OVER");
            PressAnyKeyToContinue();
            ReturnToStart();
            NewPlayer(player, 2, 200, false);
            
            
        }
    
      else
        {

        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

        System.Console.WriteLine("There are doors labeled 30 and 100. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "30":
            Cube30();
            break;

            case "100":
            Cube100();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;
        }

        }
        
        

        
        //SPIKE TRAP
        //Lose 1 life, update player lives
        //30,100
        //add other rooms
    }

    private void UpdatePlayerInfo(Player player, int livesLost, int scoreDown)
    {
        player.HasEnteredTrap(livesLost, scoreDown);
        
      
    }

    private void NewPlayer(Player player, int newLives, int newScore, bool keyUpdate)
    {
        player.NewPlayer(newLives, newScore, keyUpdate);
    }

    private void AddScore(Player player, int scoreUp)
    {
        player.EnteredSafeRoom(scoreUp);
    }

    private void Cube6()
    {
        System.Console.WriteLine("         ");
        AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        

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
            ReturnToStart();
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
        System.Console.WriteLine("         ");
        AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        System.Console.WriteLine("The room is safe. There are doors labeled 6, 17, 73, and 97. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "6":
            Cube6();
            break;

            case "97":
            Cube97();
            break;

            case "17":
            Cube17();
            break;

            case "73":
            Cube73();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;
         }
        //6, 17, 73, 97
    }

    private void Cube99()
    {
        System.Console.WriteLine("         ");
         AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

          System.Console.WriteLine("The room is safe. There are doors labeled 6, 97, and 150. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "6":
            Cube6();
            break;

            case "97":
            Cube97();
            break;

            case "150":
            Cube150();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;
         }
        //6,97,150
    }

    private void Cube150()
    {
        System.Console.WriteLine("         ");
        AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

        System.Console.WriteLine("The room is safe. There are doors labeled 99 and 25. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "99":
            Cube99();
            break;

            case "25":
            Cube25();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;



        }
        //99,25
    }

    private void Cube97()
    {
        System.Console.WriteLine("         ");
        System.Console.WriteLine("You fell into a trap and have been put back at the start.");
        UpdatePlayerInfo(player, 0, 400);
        Cube30();
    }

    private void Cube25()
    {
        System.Console.WriteLine("         ");
         AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        //150,33,97
        System.Console.WriteLine("The room is safe. There are doors labeled 150, 33 and 97. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "150":
            Cube150();
            break;

            case "33":
            Cube33();
            break;

            case "97":
            Cube97();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

    }
    }

    private void Cube33()
    {
        System.Console.WriteLine("         ");
         AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        //25,55,2
        System.Console.WriteLine("The room is safe. There are doors labeled 25, 55 and 2. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "25":
            Cube25();
            break;

            case "55":
            Cube55();
            break;

            case "2":
            Cube2();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

    }
       
    }

    private void Cube55()
    {
        System.Console.WriteLine("         ");
         AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        //73,97,33,44
        System.Console.WriteLine("The room is safe. There are doors labeled 73, 33, 44 and 97. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "73":
            Cube73();
            break;

            case "33":
            Cube33();
            break;

            case "97":
            Cube97();
            break;

            case "44":
            Cube44();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

    }
    }

    private void Cube73()
    {
        System.Console.WriteLine("         ");
        System.Console.WriteLine("You ran into a spike trap and lost a life.");
        
        UpdatePlayerInfo(player, 1, 100);

        if(player.Lives == 0)
        {
            
            System.Console.WriteLine("YOU DIED--STARTING OVER");
            PressAnyKeyToContinue();
            ReturnToStart();
            NewPlayer(player, 2, 200, false);
            
            
        }
    
      else
        {

        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

        System.Console.WriteLine("There are doors labeled 100, 15, 10, and 55. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "10":
            Cube10();
            break;

            case "100":
            Cube100();
            break;

            case "15":
            Cube15();
            break;

            case "55":
            Cube55();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;
        }

        }
        
        //trap lose 1 life
        //100,15,10,55
    }

    private void Cube2()
    {
        System.Console.WriteLine("         ");
        System.Console.WriteLine("You ran into a spike trap and lost a life.");
        
        UpdatePlayerInfo(player, 1, 100);

        if(player.Lives == 0)
        {
            
            System.Console.WriteLine("YOU DIED--STARTING OVER");
            PressAnyKeyToContinue();
            ReturnToStart();
            NewPlayer(player, 2, 200, false);
            
            
        }
    
      else
        {

        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

        System.Console.WriteLine("There are doors labeled 33, 44, and 67. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "33":
            Cube33();
            break;

            case "44":
            Cube44();
            break;

            case "67":
            Cube67();
            break;

            

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;
        }

        }
        
        //33,44,67
    }

    private void Cube44()
    {
        System.Console.WriteLine("         ");
        AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}"); 
        //55,10,2,86
        System.Console.WriteLine("The room is safe. There are doors labeled 55, 10, 2 and 86. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "55":
            Cube55();
            break;

            case "10":
            Cube10();
            break;

            case "2":
            Cube2();
            break;

            case "86":
            Cube86();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

    }
    }

    private void Cube10()
    {
        System.Console.WriteLine("         ");
         AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        //73,44,4,53
        System.Console.WriteLine("The room is safe. There are doors labeled 73, 44, 4 and 53. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "73":
            Cube73();
            break;

            case "44":
            Cube44();
            break;

            case "4":
            Cube4();
            break;

            case "53":
            Cube53();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

    }
    }

    private void Cube4()
    {
        System.Console.WriteLine("         ");
         AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        //15,10,29 
        System.Console.WriteLine("The room is safe. There are doors labeled 15, 10, and 29. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "15":
            Cube15();
            break;

            case "10":
            Cube10();
            break;

            case "29":
            Cube29();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

    }
    }

    private void Cube15()
    {
        System.Console.WriteLine("         ");
        AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");
        System.Console.WriteLine("                                ");
        
        if(player.HasKey)
        {
            System.Console.WriteLine("YOU FOUND THE EXIT!");
            System.Console.WriteLine("WINNER!!");
            AddScore(player, player.Lives*100);
        
            System.Console.WriteLine($"Score: {player.Score}");
            if(player.Score >=1000)
            {
                System.Console.WriteLine("Congratultions, you got a S Ranking!");
            }
            else if(player.Score>=900 && player.Score <1000)
            {
                System.Console.WriteLine("Congratultions, you got an A Ranking, but you can get a better rank.");
            }
             else if(player.Score>=800 && player.Score <900)
            {
                System.Console.WriteLine("Congratultions, you got an B Ranking, but you can get a better rank.");
            }
              else if(player.Score>=700 && player.Score <800)
            {
                System.Console.WriteLine("Congratultions, you got an C Ranking, but you can get a better rank.");
            }
             else if(player.Score>=600 && player.Score <700)
            {
                System.Console.WriteLine("You got an D Ranking, but you can get a better rank.");
            }
            else
            {
                System.Console.WriteLine("You got an F ranking (the lowest ranking). You can do better . . . or, you are just trash. Git gud.");
            }

            
            PressAnyKeyToContinue();
        }
        else
        {
        System.Console.WriteLine("You found the exit, but you do not have the key to unlock it.");
        System.Console.WriteLine("The room is safe. There are doors labeled 73, 4, and 17. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "73":
            Cube73();
            break;

            case "4":
            Cube4();
            break;

            case "17":
            Cube17();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

            }
        }
        //END, need key to exit
        //73,4,17
    }

    private void Cube67()
    {
        System.Console.WriteLine("         ");
        System.Console.WriteLine("You fell into a trap and have been put back at the start.");
        UpdatePlayerInfo(player, 0, 400);
        Cube30();
    }

    private void Cube86()
    {
        System.Console.WriteLine("         ");
        AddScore(player, 50 );
        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

        AddKey(player, true);
        //key location, update player.HasKey
        //44,67,53
        System.Console.WriteLine("YOU FOUND THE EXIT KEY!");
        System.Console.WriteLine("The room is safe. There are doors labeled 44, 67, and 53. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "44":
            Cube44();
            break;

            case "67":
            Cube67();
            break;

            case "53":
            Cube53();
            break;

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;

    }
    }

    private void AddKey(Player player, bool gotKey)
    {
        player.HasKey = gotKey;
    }

    private void Cube53()
    {
      System.Console.WriteLine("         ");
        //Trap lose 1 life
        //29,10,86
        System.Console.WriteLine("You ran into a spike trap and lost a life.");
        
        UpdatePlayerInfo(player, 1, 100);

        if(player.Lives == 0)
        {
            
            System.Console.WriteLine("YOU DIED--STARTING OVER");
            PressAnyKeyToContinue();
            ReturnToStart();
            NewPlayer(player, 2, 200, false);
            
            
        }
    
      else
        {

        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

        System.Console.WriteLine("There are doors labeled 29, 10, and 86. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "29":
            Cube29();
            break;

            case "10":
            Cube10();
            break;

            case "86":
            Cube86();
            break;

            

            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;
        }

        }
    }

    private void Cube29()
    {
        System.Console.WriteLine("         ");
        System.Console.WriteLine("You ran into a spike trap and lost a life.");
        
        UpdatePlayerInfo(player, 1, 100);

        if(player.Lives == 0)
        {
            
            System.Console.WriteLine("YOU DIED--STARTING OVER");
            PressAnyKeyToContinue();
            ReturnToStart();
            NewPlayer(player, 2, 200, false);
            
            
        }
    
      else
        {

        System.Console.WriteLine($"Lives: {player.Lives} Score: {player.Score}");

        System.Console.WriteLine("There are doors labeled 4 and 53. Which one would you like to enter?");
        var input = Console.ReadLine();

        switch(input)
        {
            case "4":
            Cube4();
            break;

            case "53":
            Cube53();
            break;

        
            case "0":
            ReturnToStart();
            break;

            default:
            System.Console.WriteLine("Invalid Selection");
            PressAnyKeyToContinue();
            Cube6();
            break;
        }

        }
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
        var player = new Player(2, 200, false);
        _pRepo.AddPlayerToDB(player);

        
        

    }

    private bool CloseApplication()
    {
        Console.Clear();
        System.Console.WriteLine("Thanks for playing.");
        PressAnyKeyToContinue();
        return false;
    }

    private bool ReturnToStart()
    {
        Console.Clear();
        System.Console.WriteLine("You have returned to the start.");
        PressAnyKeyToContinue();
        return false;
    }
}