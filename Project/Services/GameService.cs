using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;

namespace ConsoleAdventure.Project
{
  public class GameService : IGameService
  {
    private IGame _game { get; set; }

    public List<string> Messages { get; set; }
    public GameService()
    {
      _game = new Game();
      Messages = new List<string>();
    }

    // NOTE Utility Messages
    // TODO move messages to utils
    #region
    public void PrintTitle()
    {
      Messages.Add(@"


                     ▄█  ███▄▄▄▄            ███        ▄█    █▄       ▄████████       ▄█     █▄   ▄██████▄   ▄██████▄  ████████▄     ▄████████ 
                    ███  ███▀▀▀██▄      ▀█████████▄   ███    ███     ███    ███      ███     ███ ███    ███ ███    ███ ███   ▀███   ███    ███ 
                    ███▌ ███   ███         ▀███▀▀██   ███    ███     ███    █▀       ███     ███ ███    ███ ███    ███ ███    ███   ███    █▀  
                    ███▌ ███   ███          ███   ▀  ▄███▄▄▄▄███▄▄  ▄███▄▄▄          ███     ███ ███    ███ ███    ███ ███    ███   ███        
                    ███▌ ███   ███          ███     ▀▀███▀▀▀▀███▀  ▀▀███▀▀▀          ███     ███ ███    ███ ███    ███ ███    ███ ▀███████████ 
                    ███  ███   ███          ███       ███    ███     ███    █▄       ███     ███ ███    ███ ███    ███ ███    ███          ███ 
                    ███  ███   ███          ███       ███    ███     ███    ███      ███ ▄█▄ ███ ███    ███ ███    ███ ███   ▄███    ▄█    ███ 
                    █▀    ▀█   █▀          ▄████▀     ███    █▀      ██████████       ▀███▀███▀   ▀██████▀   ▀██████▀  ████████▀   ▄████████▀  
                                                                                                                                               
");
    }
    public void PrintCredit()
    {
      Messages.Add(@"
                                               _                       _        o                                  
                                         _    (_| _ __  _    |_  \/   |_) _ __  |  _ __  o __    |\| _     o _|__|_
                                        (_|   __|(_||||(/_   |_) /    |_)(/_| |_| (_|||| | | |   | |(/_\^/ |  |_ |_
");
    }

    public void PrintCongrats()
    {
      Messages.Add(@"
                     _____ _____ _   _ _____ ______  ___ _____ _   _ _       ___ _____ _____ _____ _   _  _____ 
                    /  __ \  _  | \ | |  __ \| ___ \/ _ \_   _| | | | |     / _ \_   _|_   _|  _  | \ | |/  ___|
                    | /  \/ | | |  \| | |  \/| |_/ / /_\ \| | | | | | |    / /_\ \| |   | | | | | |  \| |\ `--. 
                    | |   | | | | . ` | | __ |    /|  _  || | | | | | |    |  _  || |   | | | | | | . ` | `--. \
                    | \__/\ \_/ / |\  | |_\ \| |\ \| | | || | | |_| | |____| | | || |  _| |_\ \_/ / |\  |/\__/ /
                     \____/\___/\_| \_/\____/\_| \_\_| |_/\_/  \___/\_____/\_| |_/\_/  \___/ \___/\_| \_/\____/ 
                                                                                                                
                                                                                                                
");
    }
    public void PrintGameOver()
    {
      Messages.Add(@"
                                                                                                                                
                                          @@@@@@@@   @@@@@@   @@@@@@@@@@   @@@@@@@@      @@@@@@   @@@  @@@  @@@@@@@@  @@@@@@@   
                                         @@@@@@@@@  @@@@@@@@  @@@@@@@@@@@  @@@@@@@@     @@@@@@@@  @@@  @@@  @@@@@@@@  @@@@@@@@  
                                         !@@        @@!  @@@  @@! @@! @@!  @@!          @@!  @@@  @@!  @@@  @@!       @@!  @@@  
                                         !@!        !@!  @!@  !@! !@! !@!  !@!          !@!  @!@  !@!  @!@  !@!       !@!  @!@  
                                         !@! @!@!@  @!@!@!@!  @!! !!@ @!@  @!!!:!       @!@  !@!  @!@  !@!  @!!!:!    @!@!!@!   
                                         !!! !!@!!  !!!@!!!!  !@!   ! !@!  !!!!!:       !@!  !!!  !@!  !!!  !!!!!:    !!@!@!    
                                         :!!   !!:  !!:  !!!  !!:     !!:  !!:          !!:  !!!  :!:  !!:  !!:       !!: :!!   
                                         :!:   !::  :!:  !:!  :!:     :!:  :!:          :!:  !:!   ::!!:!   :!:       :!:  !:!  
                                          ::: ::::  ::   :::  :::     ::    :: ::::     ::::: ::    ::::     :: ::::  ::   :::  
                                          :: :: :    :   : :   :      :    : :: ::       : :  :      :      : :: ::    :   : :  
                                                                                                                                
");
    }

    // TODO Rewrite PrintIntroMessage
    public void PrintIntroMessage()
    {
      Messages.Add($"{_game.CurrentRoom.Description}");
    }

    public void PrintChooseAny()
    {
      Messages.Add("press any key to continue");
    }

    public void PrintInvalidInput()
    {
      Messages.Add("action not recognized");
    }

    public void PrintCurrentRoomDes()
    {
      Messages.Add($"{_game.CurrentRoom.Description}");
    }

    public void PrintQuitMessage()
    {
      Messages.Add(@"
                                   ▄█▄    ████▄ █▀▄▀█ ▄███▄       ███   ██   ▄█▄    █  █▀        ▄▄▄▄▄   ████▄ ████▄    ▄            
                                   █▀ ▀▄  █   █ █ █ █ █▀   ▀      █  █  █ █  █▀ ▀▄  █▄█         █     ▀▄ █   █ █   █     █           
                                   █   ▀  █   █ █ ▄ █ ██▄▄        █ ▀ ▄ █▄▄█ █   ▀  █▀▄       ▄  ▀▀▀▀▄   █   █ █   █ ██   █          
                                   █▄  ▄▀ ▀████ █   █ █▄   ▄▀     █  ▄▀ █  █ █▄  ▄▀ █  █       ▀▄▄▄▄▀    ▀████ ▀████ █ █  █          
                                   ▀███▀           █  ▀███▀       ███      █ ▀███▀    █                              █  █ █ ██ ██ ██ 
                                                  ▀                       █          ▀                               █   ██          
                                                                         ▀                                                           
");
    }

    #endregion

    // NOTE Actions
    #region
    public bool Go(string direction)
    {
      bool IsEndOfGame = false;
      if (direction != "north" && direction != "south" && direction != "east" && direction != "west")
      {
        PrintInvalidInput();
        return true;
      }
      else
      {
        IRoom newRoom = _game.CurrentRoom.ChangeRoom(direction);
        if (newRoom == null)
        {
          if (_game.CurrentRoom.Name == "The forest path" && direction == "south")
          {
            Endgame();
            IsEndOfGame = true;
          }
          else
          {
            Messages.Add("You can't travel in that direction");
          }
        }
        else if (newRoom != null)
        {
          _game.CurrentRoom = newRoom;
          PrintCurrentRoomDes();
        }
      }
      if (IsEndOfGame == true)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public void Help()
    {
      Messages.Add(@"
~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~{Actions}~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~

    go (direction) ~~~~~~~~~~~~~~~ input your cardinal direction to move about the environment
    look           ~~~~~~~~~~~~~~~ check your surroundings
    inventory      ~~~~~~~~~~~~~~~ view your inventory
    take (item)    ~~~~~~~~~~~~~~~ attempt to move an item from the environment to add it to your inventory
    use (item)     ~~~~~~~~~~~~~~~ attempt to use an item from your inventory with the environment
    quit           ~~~~~~~~~~~~~~~ quit the game
      ");
    }

    public void Inventory()
    {
      Messages.Add(@"~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~{Inventory}~~~^(|)^~~~^(|)^~~~^(|)^~~~^(|)^~~~");
      int index = 0;
      foreach (Item item in _game.CurrentPlayer.Inventory)
      {
        Messages.Add($"{_game.CurrentPlayer.Inventory[index].Name} ~~~~~ {_game.CurrentPlayer.Inventory[index].Description}");
        index++;
      }
    }

    public void Look()
    {
      PrintCurrentRoomDes();
    }

    public void Quit()
    {
      PrintQuitMessage();
    }
    public void TakeItem(string itemName)
    {
      Item foundItem = _game.CurrentRoom.Items.Find(i => i.Name.ToLower() == itemName);
      if (foundItem == null)
      {
        if (itemName == "painting")
        {
          UseItem(itemName);
        }
        else
        {
          PrintInvalidInput();
        }
      }
      else
      {
        if (foundItem.IsHidden == false)
        {
          _game.CurrentRoom.RemoveItem(foundItem);
          _game.CurrentPlayer.AddItem(foundItem);
          Messages.Add($"You added the {itemName} to your inventory");
          OnTaken(itemName);
        }
        else
        {
          PrintInvalidInput();
        }
      }
    }


    public void FilterItemUse(string itemName)
    {
      // Check player inventory for item
      Item foundItem = _game.CurrentPlayer.Inventory.Find(i => i.Name.ToLower() == itemName);
      if (foundItem == null)
      {
        // if not found in inventory, check if usable item is in the room
        string usableItem = _game.CurrentRoom.UsableItems.Find(i => i == itemName);
        if (usableItem == null)
        {
          // if neither true, print invalid input
          PrintInvalidInput();
        }
        else
        {
          UseItem(usableItem);
          // If item exists in room, pass it to UseItem
        }
      }
      else
      {
        // On use inventory item
        switch (itemName)
        {
          case "lantern":
            Messages.Add("You light the lantern.");
            Messages.Add("");
            CheckInventoryItemUse(itemName);
            break;
          case "compass":
            Messages.Add("You bring out the compass.");
            break;
          case "map":
            Messages.Add("You unfurl the map.");
            break;
          default:
            PrintInvalidInput();
            break;
        }
      }
    }
    #endregion

    // NOTE 

    public void UseItem(string itemName)
    {
      if (_game.CurrentRoom.UsableItems.Contains(itemName))
      {

        // Use item that exists in the room
        switch (itemName)
        {
          case "painting":
            Messages.Add("Removing the painting from the wall reveals a very old map, one that looks like it could fall apart at any moment.");
            RevealHiddenItem("Map");
            RemoveUsableItem(itemName);
            UpdateDesc("Inside the second room of the house is a surprisingly well-preserved den. Inside the den is a writing desk with a single wingback chair facing the northern wall, where a single window sits. A fragile map hangs on the wall.");
            break;
          default:
            break;
        }
      }
      else
      {
        PrintInvalidInput();
      }
    }

    public void CheckInventoryItemUse(string itemName)
    {
      bool isItemUsable = _game.CurrentRoom.CheckItemUse(itemName);
      if (isItemUsable == true)
      {

        switch (_game.CurrentRoom.Name)
        {
          case "Basement":
            if (itemName == "lantern")
            {
              UpdateDesc("With lantern in hand, you descend the stairway. The air is musty and thick, oppressing your senses. Only the lantern's dim light gives you some semblance of comfort. A single table lies against the western-most wall.");
              RemoveUsableItem(itemName);
              PrintCurrentRoomDes();
              UpdateDesc("Reigniting your lantern, you take in your surroundings once more. The table set up against the wall to the west remains as the only notable feature.");
            }
            else
            {
              Messages.Add($"The {itemName} has no use here.");
            };
            break;
          default:
            Messages.Add($"bringing out the {itemName} does nothing here.");
            break;
        }
      }
      else
      {
        Messages.Add($"Using the {itemName} has no affect.");
      }
    }

    public void OnTaken(string itemName)
    {
      switch (itemName)
      {
        case "map":
          UpdateDesc("Inside the second room of the house is a surprisingly well-preserved den. Inside the den is a writing desk with a single wingback chair facing the northern wall, where a single window sits.");
          break;
        default:
          break;
      }
    }

    public void UpdateDesc(string desc)
    {
      _game.CurrentRoom.ChangeDesc(desc);
    }


    public void RemoveUsableItem(string itemName)
    {
      _game.CurrentRoom.RemoveUsableItem(itemName);
    }
    public void RevealHiddenItem(string itemName)
    {
      _game.CurrentRoom.RevealHiddenItem(itemName);
    }

    // NOTE WIN/LOSE CONDITION
    public void Endgame()
    {
      List<string> Inventory = new List<string>();
      int index = 0;
      foreach (Item item in _game.CurrentPlayer.Inventory)
      {
        Inventory.Add(_game.CurrentPlayer.Inventory[index].Name.ToLower());
      }
      if (Inventory.Contains("map") && Inventory.Contains("lantern") && Inventory.Contains("compass"))
      {
        YouWin();
      }
      else
      {
        YouLose();
      }
    }

    public void YouWin()
    {
      PrintCongrats();
    }

    public void YouLose()
    {
      PrintGameOver();
    }

    // NOTE Unused Actions
    // TODO Remove if never used + remove from IGameService
    #region
    public void Reset()
    {
      throw new System.NotImplementedException();
    }

    public void Setup(string playerName)
    {
      throw new System.NotImplementedException();
    }
    #endregion
  }
}