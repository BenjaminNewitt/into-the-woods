using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Game : IGame
  {
    public IRoom CurrentRoom { get; set; }
    public IPlayer CurrentPlayer { get; set; }

    public void Setup()
    {

      Player Player = new Player("Player");
      //NOTE ROOMS
      #region
      Room Woods = new Room("The forest path", "To the north lies an abandoned structure. The path south into the forest is pitch black. If you walk down it, you may never leave the forest.", false);
      Room FrontPorch = new Room("Front porch", "The boards creak under your footsteps as you step onto the porch. To the north, the front door of the house lies open. A scrap of paper is shoved between the boards.", false);
      Room BackOfHouse = new Room("Back of the house", "As you come around to the back of the house, you notice a single shuttered window.\nOn the window sill stands a lantern. Nothing hinders you from travel along either side of the decrepit building.", false);
      Room LivingRoom = new Room("House Interior", "Inside of the house lies an empty room.\nTo the west of you lies a stairwell leading downwards, and to the north is another door, this one being shut.", false);
      Room Den = new Room("Den", "Inside the second room of the house is a surprisingly well-preserved den. Inside the den is a writing desk with a single wingback chair facing the northern wall, where a single window sits. There is a faded painting on the western wall, the only item not in decent condition.", true);
      Room Basement = new Room("Basement", "With the stairs groaning under your weight with every footstep, you descend into the darkness. It is too dark to see anything.", false);
      Room FrontYard = new Room("Front of the house", "An abandoned, single-story house lies before you, with the forest you stumbled out of at your back.\nA porch to the north leads up to the windowless house. Either side of the house looks to be accessible.", false);

      Woods.Exits.Add("north", FrontYard);
      FrontYard.Exits.Add("north", FrontPorch);
      FrontYard.Exits.Add("south", Woods);
      FrontYard.Exits.Add("east", BackOfHouse);
      FrontYard.Exits.Add("west", BackOfHouse);
      FrontPorch.Exits.Add("north", LivingRoom);
      FrontPorch.Exits.Add("south", FrontYard);
      BackOfHouse.Exits.Add("east", FrontYard);
      BackOfHouse.Exits.Add("west", FrontYard);
      LivingRoom.Exits.Add("north", Den);
      LivingRoom.Exits.Add("south", FrontPorch);
      LivingRoom.Exits.Add("west", Basement);
      Den.Exits.Add("south", LivingRoom);
      Basement.Exits.Add("east", LivingRoom);

      #endregion

      //NOTE ITEMS
      #region 
      // NOTE INVENTORY ITEMS
      // NOTE KEY ITEMS
      Item Compass = new Item("Compass", "A rusted, but usable, compass.", true);
      Item Lantern = new Item("Lantern", "Although the lantern appears the be very old, it seems to work properly once lit.", false);
      Item Map = new Item("Map", "While faded, the parchment appears to be a map of the woods. A dark red X on the map appears to mark the location of the house.", true);
      Item Note = new Item("Paper", "A note that holds a hastily-written inscription: 'I can't leave this forest, not until I can see where I'm going.\nBut even if I could, I don't know where to go. If only I could find a map to find my way out, and a compass to get my bearings. Otherwise, I fear I may never leave this place alive.", false);
      // NOTE RED HERRINGS

      // NOTE INVENTORY ITEMS ADDED TO ROOMS
      Den.Items.Add(Map);
      BackOfHouse.Items.Add(Lantern);
      Basement.Items.Add(Compass);
      FrontPorch.Items.Add(Note);

      #endregion

      #region 
      // NOTE USABLE INVENTORY ITEMS
      Basement.UsableInventoryItems.Add("lantern");
      Woods.UsableInventoryItems.Add("lantern");
      Woods.UsableInventoryItems.Add("map");
      Woods.UsableInventoryItems.Add("compass");

      // NOTE OTHER USABLE ITEMS
      Den.UsableItems.Add("painting");
      LivingRoom.UsableItems.Add("door");
      #endregion

      CurrentRoom = Woods;
      CurrentPlayer = Player;
    }

    public Game()
    {
      Setup();

    }

  }
}