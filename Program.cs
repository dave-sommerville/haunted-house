namespace Haunted_House
{
    public class Program
    {
        static void Main(string[] args)
        {                          //  In retrospect, I think room should be a class with subclasses for rooms with secrets. This would open up more 
                                   //   interaction with ghosts (you could have haunted rooms and secret rooms with different effects)
                                   //   I was just too far in executing the below method to turn back at the time
                 // DECLARATIONS 
                //  SECRET ROOMS 
            Room ballRoomBonus = new Room("Painting in the Ballroom", "You see the painting is a little crooked.\nYou pull it away from the wall, revealing a wall safe.\n" +
                "You cautiously input the code from the paper, which responds with a beep and a green light.\nThe safe is now open.\n" + 
                "1) Search 2) Leave", new string[] { "Necklace" }, 0, null);
            Room studyRoomBonus = new Room("Study (unlocked)", "The old key clicks into place and the doorknob turn revealing the study.\nIt is a claustrophobic room filled with the scent of leather and tobacco.\n" +
                "A large desk, its surface cluttered with yellowed papers and broken quills,\nAn oil lamp flickers faintly, though no one is there to light it,\n" +
                "and the faint scratching of an invisible pen seems to echo from the walls.\n" +
                "1) Search 2) Leave", new string[] { "Statue" }, 80, null);
            Room ghostBonus = new Room("Nursery", "The ghost looks as you hold out her little doll.\n" + 
                "\"Oh my goodness, you found it!\" she exclaims, with a deathly shrill.\n" + "\"Here, I'll give you this weird old jar to trade.\", she hands you a large urn.\n" + 
                "1) Take Item 2) Leave", new string[] { "Urn" }, 22, null);

                // HOUSE/ROOMS
            Room[] house = new Room[] {
  
                new Room("Library", "The library smells of aged paper and mildew,\nits walls lined with towering bookshelves that seem to stretch into darkness.\n" +
                    "Dust motes dance in the faint light from a cracked stained-glass window,\nwhile an ancient globe in the corner spins ever so slightly,\n" +
                    "though no breeze stirs.\nA ladder rests against the shelves, its rungs worn smooth,\nas if by ghostly hands seeking forbidden knowledge.\n" + 
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Book" }, 0, null),
                new Room("Kitchen", "The kitchen is a stark contrast to the rest of the house,\nwith rusted pots hanging from the ceiling and a sink filled with stagnant water.\n" + 
                    "The once-grand oven stands cold, its door slightly ajar,\nas if something unseen has recently emerged.\nKnives hang on the wall, some missing," + 
                    "leaving only their outlines,\nand a faint metallic smell lingers in the air.\n\n\n" +
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Herring" }, 0, null),
                new Room("Dining Room", "The dining room is dominated by a long mahogany table set for a feast that never happened.\nTarnished silverware glints under the flicker of a lone candelabra" + 
                    "its candles melting into grotesque shapes.\nA massive mirror on one wall reflects the room—but something about the reflection feels off,\n" +
                    "as if the figures seated at the table are waiting for you to join them.\n" +
                    "1) Search Room      2) Leave Room", 
                    null, 0, null),
                new Room("Ballroom", "The ballroom is cavernous and eerily quiet, the only sound the creak of your footsteps on the parquet floor.\nA massive painting dominates one wall," +
                    "depicting a grand ball frozen in time,\nthe figures’ faces smudged or missing entirely.\nChandeliers above sway slightly, though the air is still, and the faint sound of music seems to hum from nowhere.\n" +
                    "1) Search Room      2) Leave Room      3) Use Item", 
                    null, 11, ballRoomBonus),
                new Room("Den", "The den has shadows clinging to every surface.\nThe faded velvet armchairs sit askew, their cushions slashed as if by unseen claws.\nA cold, gray light filters through cracked blinds," + 
                    "casting warped shapes on the walls.\nA soot-covered fireplace holds no warmth, its grate choked with brittle, half-burnt logs and charred bones.\nThe air smells faintly of damp leather and burnt wood," + 
                    "with an underlying metallic tang.\nOn the wall, a portrait hangs crooked, its once-dignified subject now defaced,\neyes gouged out, leaving empty, accusing hollows.\nAn oppressive silence lingers," + 
                    "broken only by the faint echo of muffled whispers\nthat seem to emanate from nowhere and everywhere at once.\n1) Search Room      2) Leave Room", 
                    new string[] { "Paper" }, 0, null),
                new Room("Study (locked)", "The study is locked.\n" + 
                    "1) Search 2) Leave 3) Use Item", 
                    null, 00, studyRoomBonus),
                new Room("Nursery", "The nursery, once a haven of innocence, now exudes an unsettling stillness.\nFaded pastel wallpaper peels from the walls, revealing dark stains beneath.\n" + 
                    "A shattered mobile dangles precariously over a decrepit crib,\nits remaining pieces tinkling faintly in unseen drafts.\nBroken toys litter the floor, their lifeless eyes seeming to follow every movement.\n" + 
                    "In the corner, a small rocking chair sways gently on its own,\ncreaking with an eerie rhythm that matches the faint, ghostly lullaby whispered by unseen voices.\nThe air is thick with a cloying, sweet smell,\n" + 
                    "as though time has trapped the scent of old milk and powder beneath decades of decay.\n" + 
                    "You see the ghost of a small child, softly weeping in the corner.\nShe mumbles over and over again\n\"My doll, my doll, oh where is my doll\"\n" +
                    "1) Search Room      2) Leave Room      3) Use Item", 
                    null, 22, ghostBonus),
                new Room("Guest Room", "The guest room is cold and unwelcoming\nwith wallpaper peeling from the walls in grotesque patterns.\nA wardrobe dominates one corner, its doors slightly ajar,\n" + 
                    "revealing darkness deeper than it should be.\nThe bed is unmade, its sheets tangled as if someone—or something—left in haste.\nA music box sits on the nightstand,\nits lid open," +
                    "playing a tune slowed to a haunting crawl.\n" +
                    "1) Search Room      2) Leave Room", 
                    null, 80, null),
                new Room("Master Bedroom", "The master bedroom is a shrine to faded opulence.\nA four-poster bed draped in moth-eaten velvet dominates the room, its once-plush mattress now sagging.\nA vanity sits nearby," + 
                    "its cracked mirror reflecting not only you but also faint outlines of others, watching.\nThe air carries a faint perfume, sweet but sickly,\nand the sound of labored breathing fills the silence.\n" +
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Key" }, 00, null),
                new Room("Attic", "The attic is a labyrinth of forgotten relics cloaked in cobwebs.\nBroken furniture and crates filled with unidentifiable trinkets create looming shadows in the dim light from a single," + 
                    "flickering bulb.\nA decrepit rocking chair sways gently in one corner, as if disturbed by an unseen presence,\nand the faint whisper of a child’s laughter echoes just out of reach.\n" +
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Doll", "Satchel" }, 80, null)

            };

            //  ITEMS
            Item key = new Item("Key", "Shiny", 00, false);
            Item paperCode = new Item("Scrap piece of paper", "Paper", 11, false);
            Item doll = new Item("Slightly damaged porcelin doll", null, 22, false);
            Item book = new Item("A worn and dusty tome", null, 3, true);
            Item necklace = new Item("Silver necklace", null, 4, true);
            Item satchel = new Item("Small satchel with punget contents", null, 5, true);
            Item smallStatue = new Item("Small statute of a Grecian woman", null, 6, true);
            Item urn = new Item("Finely deocrated urn", null, 7, true);
            Item herring = new Item("A smelly red fish", null, 88, false);

            Dictionary<string, Item> AllItems = new Dictionary<string, Item>
            {
                { "Key", key },
                { "Paper", paperCode },
                { "Doll", doll },
                { "Book", book },
                { "Necklace", necklace },
                { "Satchel", satchel },
                { "Statue", smallStatue },
                { "Urn", urn },
                { "Herring", herring }
            };

            const int PLAYER_SANITY = 100;
            const int HAUNT_CHANCE = 50; // out of 100
            //      INTRODUCTION
            Console.WriteLine("Might we start with your name? (enter name in console)");    // Player name could be integrated more into game play 
            string playerName = Console.ReadLine();
            Player player = new Player(playerName, new Item[10], PLAYER_SANITY, 0, true);
            Console.WriteLine($"Hello, {player.Name}\n");
            Console.WriteLine();
            Console.WriteLine("I know why you have come, and perhaps I welcome it.\nI have haunted this house for centuries and " + 
                "I grow weary of the screams.\nI'll tell you exactly how to vanquish me, but to win you must " +
                "be courageous.\nI am not the only ghost you may encounter.\nIf you can find my relics, you will be able to " +
                "exorcise my spirit.\nYou must find:\nMy Grimoire, My Mother's necklace, A satchel of herbs and incense, Hecate's Statue,\nand finally the Urn holding my remains\n" +
                $"Good Luck {player.Name}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            //      MAIN MENU
            while (player.GameInProgress)
            {
                Random rand = new Random(); //  I would like more complex ghosts encounters, likely creating a ghost class
                int choice = PrintMenu();   //  I think there could be a player interaction instead of simply a chance encounter 
                Room chosenRoom = house[choice - 1];    //  As well ghosts should have dialogue options
                if (rand.Next(100) > HAUNT_CHANCE) {
                    Haunt(player);
                }
                if (!player.GameInProgress)
                {
                    return;
                }
                if (choice > 0 && choice <= house.Length)
                {
                    chosenRoom.DescribeRoom();
                } else
                {
                    Console.WriteLine("Invalid choice. Please select again.");
                }
                while (player.GameInProgress) {
                    int actionChoice = PrintActionMenu();
          
                    if (actionChoice == 1)
                    {
                        chosenRoom.Search(AllItems, player);
                    } else if (actionChoice == 2) {
                        break;
                    } else if (actionChoice == 3)
                    {
                        if (chosenRoom.SecretRoom != null)
                        {
                            while (player.GameInProgress)
                            {
                                for (int i = 0; i < player.Inventory.Length; i++)
                                {
                                    if (player.Inventory[i] != null)
                                    {
                                        Console.WriteLine($"{i + 1}) {player.Inventory[i].Name}");
                                    }
                                }
                                Console.WriteLine("0) Leave");
                                int itemChoice = player.PrintInventory() - 1;
                                if (itemChoice == -1)
                                {
                                    Console.WriteLine("1) Search 2) Leave 3) Use Item");
                                    break;
                                }
                                bool canOpen = player.UseItem(itemChoice, chosenRoom);
                                if (canOpen)
                                {
                                    chosenRoom.SecretRoom.DescribeRoom();
                                    while (player.GameInProgress)
                                    {
                                        int secretChoice = PrintActionMenu();
                                        if (secretChoice == 1)
                                        {
                                            chosenRoom.SecretRoom.Search(AllItems, player);
                                        }
                                        else if (secretChoice == 2 || secretChoice == 3)
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You can't use that item here");
                                }
                            }

                        } else
                        {
                            break;
                        }
                    }
                }
            }
        }
        private static void Haunt(Player player)
        {
            Console.WriteLine();
            player.Sanity -= 10;
            Console.WriteLine("****************************************\nBefore you can make it to the room, an apparition appears before you.\nIt screams a blood curdling wail that you feel echo through your bones.\n" +
                $"Then it disappears.\nYour current sanity level is {player.Sanity}\n****************************************");
            Console.WriteLine();
            Console.WriteLine();
            if (player.Sanity  <= 0)
            {
                Console.WriteLine($"Run ragged from the terrifying house, you slip into madness,\nspending the rest of your days, \nboth living and dead, \nrocking back and forth on the floor\nFarewell, {player.Name}");
                player.GameInProgress = false;
                return;
            }
        }

        private static int PrintMenu()
        {
            int intDecision;
            while (true)
            {
                Console.Write("Select a room to explore:\n1)  Library\n2)  Kitchen\n3)  Dining Room\n4)  Ballromm\n5)  Den\n6)  Study\n7)  Nursery\n8)  Guest Bedroom\n9)  Master Bedroom\n10) Attic\n");
                string decision = Console.ReadLine();

                if (int.TryParse(decision, out intDecision))
                {
                    if (intDecision >= 0 && intDecision <= 10)

                    {
                        return intDecision;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1 - 10");
                    }
                }
                else
                {
                    Console.WriteLine("That is an invalid character.");
                }

            }
        }

        private static int PrintActionMenu()
        {
            int intDecision;
            while (true)
            {
                string decision = Console.ReadLine();

                if (int.TryParse(decision, out intDecision))
                {
                    if (intDecision >= 0 && intDecision <= 3)

                    {
                        return intDecision;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 1- 2");
                    }
                }
                else
                {
                    Console.WriteLine("That is an invalid character.");
                }

            }
        }
    }
}
