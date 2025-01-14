namespace Haunted_House
{
    public class Program
    {
        static void Main(string[] args)
        {
                 // DECLARATIONS 
                //  SECRET ROOMS 
            Rooms ballRoomBonus = new Rooms("Painting in the Ballroom", "You see the painting is a little crooked.\nYou pull it away from the wall, revealing a wall safe.\n" +
                "You cautiously input the code from the paper, which responds with a beep and a green light.\nThe safe is now open.\n" + 
                "1) Search 2) Leave", new string[] { "Necklace" }, false, 0, null);
            Rooms studyRoomBonus = new Rooms("Study (unlocked)", "The old key clicks into place and the doorknob turn revealing the study.\nIt is a claustrophobic room filled with the scent of leather and tobacco.\n" +
                "A large desk, its surface cluttered with yellowed papers and broken quills,\nAn oil lamp flickers faintly, though no one is there to light it,\n" +
                "and the faint scratching of an invisible pen seems to echo from the walls.\n" +
                "1) Search 2) Leave", new string[] { "Statue" }, false, 80, null);
            Rooms ghostBonus = new Rooms("Nursery", "The ghost looks as you hold out her little doll.\n" + 
                "\"Oh my goodness, you found it!\" she exclaims, with a deathly shrill.\n" + "\"Here, I'll give you this weird old jar to trade.\", she hands you a large urn.\n" + 
                "1) Take Item 2) Leave", new string[] { "Urn" }, false, 22, null);

                // HOUSE/ROOMS
            Rooms[] house = new Rooms[] {
  
                new Rooms("Library", "The library smells of aged paper and mildew,\nits walls lined with towering bookshelves that seem to stretch into darkness.\n" +
                    "Dust motes dance in the faint light from a cracked stained-glass window,\nwhile an ancient globe in the corner spins ever so slightly,\n" +
                    "though no breeze stirs.\nA ladder rests against the shelves, its rungs worn smooth,\nas if by ghostly hands seeking forbidden knowledge.\n" + 
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Book" }, false, 0, null),
                new Rooms("Kitchen", "The kitchen is a stark contrast to the rest of the house,\nwith rusted pots hanging from the ceiling and a sink filled with stagnant water.\n" + 
                    "The once-grand oven stands cold, its door slightly ajar,\nas if something unseen has recently emerged.\nKnives hang on the wall, some missing," + 
                    "leaving only their outlines,\n and a faint metallic smell lingers in the air.\n\n\n" +
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Herring" }, false, 0, null),
                new Rooms("Dining Room", "The dining room is dominated by a long mahogany table set for a feast that never happened.\nTarnished silverware glints under the flicker of a lone candelabra" + 
                    "its candles melting into grotesque shapes.\nA massive mirror on one wall reflects the room—but something about the reflection feels off,\n" +
                    "as if the figures seated at the table are waiting for you to join them.\n" +
                    "1) Search Room      2) Leave Room", 
                    null, false, 0, null),
                new Rooms("Ballroom", "The ballroom is cavernous and eerily quiet, the only sound the creak of your footsteps on the parquet floor.\nA massive painting dominates one wall," +
                    "depicting a grand ball frozen in time,\nthe figures’ faces smudged or missing entirely.\nChandeliers above sway slightly, though the air is still, and the faint sound of music seems to hum from nowhere.\n" +
                    "1) Search Room      2) Leave Room      3) Use Item", 
                    null, false, 11, ballRoomBonus),
                new Rooms("Den", "The den has shadows clinging to every surface.\nThe faded velvet armchairs sit askew, their cushions slashed as if by unseen claws.\nA cold, gray light filters through cracked blinds," + 
                    "casting warped shapes on the walls.\nA soot-covered fireplace holds no warmth, its grate choked with brittle, half-burnt logs and charred bones.\nThe air smells faintly of damp leather and burnt wood," + 
                    "with an underlying metallic tang.\nOn the wall, a portrait hangs crooked, its once-dignified subject now defaced,\neyes gouged out, leaving empty, accusing hollows.\nAn oppressive silence lingers," + 
                    "broken only by the faint echo of muffled whispers\nthat seem to emanate from nowhere and everywhere at once.\n1) Search Room      2) Leave Room", 
                    new string[] { "Paper" }, false, 0, null),
                new Rooms("Study (locked)", "The study is locked.\n" + 
                    "1) Search 2) Leave 3) Use Item", 
                    null, false, 00, studyRoomBonus),
                new Rooms("Nursery", "The nursery, once a haven of innocence, now exudes an unsettling stillness.\nFaded pastel wallpaper peels from the walls, revealing dark stains beneath.\n" + 
                    "A shattered mobile dangles precariously over a decrepit crib,\nits remaining pieces tinkling faintly in unseen drafts.\nBroken toys litter the floor, their lifeless eyes seeming to follow every movement.\n" + 
                    "In the corner, a small rocking chair sways gently on its own,\ncreaking with an eerie rhythm that matches the faint, ghostly lullaby whispered by unseen voices.\nThe air is thick with a cloying, sweet smell,\n" + 
                    "as though time has trapped the scent of old milk and powder beneath decades of decay.\n" + 
                    "You see the ghost of a small child, softly weeping in the corner.\nShe mumbles over and over again\n\"My doll, my doll, oh where is my doll\"" +
                    "1) Search Room      2) Leave Room      3) Use Item", 
                    null, false, 22, ghostBonus),
                new Rooms("Guest Room", "The guest room is cold and unwelcoming\nwith wallpaper peeling from the walls in grotesque patterns.\nA wardrobe dominates one corner, its doors slightly ajar,\n" + 
                    "revealing darkness deeper than it should be.\nThe bed is unmade, its sheets tangled as if someone—or something—left in haste.\nA music box sits on the nightstand,\nits lid open," +
                    "playing a tune slowed to a haunting crawl.\n" +
                    "1) Search Room      2) Leave Room", 
                    null, false, 80, null),
                new Rooms("Master Bedroom", "The master bedroom is a shrine to faded opulence.\nA four-poster bed draped in moth-eaten velvet dominates the room, its once-plush mattress now sagging.\nA vanity sits nearby," + 
                    "its cracked mirror reflecting not only you but also faint outlines of others, watching.\nThe air carries a faint perfume, sweet but sickly,\nand the sound of labored breathing fills the silence.\n" +
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Key" }, false, 00, null),
                new Rooms("Attic", "The attic is a labyrinth of forgotten relics cloaked in cobwebs.\nBroken furniture and crates filled with unidentifiable trinkets create looming shadows in the dim light from a single," + 
                    "flickering bulb.\nA decrepit rocking chair sways gently in one corner, as if disturbed by an unseen presence,\nand the faint whisper of a child’s laughter echoes just out of reach.\n" +
                    "1) Search Room      2) Leave Room", 
                    new string[] { "Doll", "Satchel" }, false, 80, null)

            };

            //  ITEMS
            Items key = new Items("Key", "Shiny", 00, false);
            Items paperCode = new Items("Scrap piece of paper", "Paper", 11, false);
            Items doll = new Items("Slightly damaged porcelin doll", null, 22, false);
            Items book = new Items("A worn and dusty tome", null, 3, true);
            Items necklace = new Items("Silver necklace", null, 4, true);
            Items satchel = new Items("Small satchel with punget contents", null, 5, true);
            Items smallStatue = new Items("Small statute of a Grecian woman", null, 6, true);
            Items urn = new Items("Finely deocrated urn", null, 7, true);
            Items herring = new Items("A smelly red fish", null, 88, false);

            Dictionary<string, Items> AllItems = new Dictionary<string, Items>
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
            
            //      INTRODUCTION
            Console.WriteLine("Might we start with your name? (enter name in console)");
            string playerName = Console.ReadLine();
            Player player = new Player(playerName, new Items[10], PLAYER_SANITY, 0, true);
            Console.WriteLine($"Hello, {player.Name}\n");
            Console.WriteLine();
            Console.WriteLine("I know why you have come, and perhaps I welcome it. I have haunted this house for centuries." + 
                "I have grown weary of the screams. I'll tell you exactly how to vanquish me, but to win you must " +
                "be courageous. I am not the only ghost you may encounter. If you can find my relics, you will be able to " +
                "exorcise my spirit. You must find:\n1) My Grimoire\n2) My Mother's necklace\n3) A satchel of herbs and incense\n4) Hecate's Statue\n5) The Urn holding my remains\n" +
                $"Good Luck {player.Name}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            //      MAIN MENU
            while (player.GameInProgress)
            {
                Random rand = new Random();
                int choice = PrintMenu();
                Rooms chosenRoom = house[choice - 1];
                if (rand.Next(100) > 50) {
                    Haunt(player);
                }
                if (choice > 0 && choice <= house.Length)
                {
                    chosenRoom.DescribeRoom();
                } else
                {
                    Console.WriteLine("Invalid choice. Please select again.");
                }
                while (true) {
                    int actionChoice = PrintActionMenu();
          
                    if (actionChoice == 1)
                    {
                        chosenRoom.Search(AllItems, player);
                        Console.WriteLine("        2) Leave Room");
                    } else if (actionChoice == 2) {
                        break;
                    } else if (actionChoice == 3)
                    {
                        if (chosenRoom.SecretRoom != null)
                        {
                            while (true)
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
                                    while (true)
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
                            return;
                        }
                    }
                }
            }
        }
        public static void Haunt(Player player)
        {
            Console.WriteLine();
            player.Sanity -= 10;
            Console.WriteLine("****************************************\nBefore you can make it to the room, an apparition appears before you.\nIt screams a blood curdling scream that you feel echo through your bones.\n" +
                $"Then it disappears.\nYour current sanity level is {player.Sanity}\n****************************************");
            Console.WriteLine();
            Console.WriteLine();
            if (player.Sanity  <= 0)
            {
                Console.WriteLine("Run ragged from the terrifying house, you slip into madness, \nspending the rest of your days, \nboth living and dead, \nrocking back and forth on the floor");
                player.GameInProgress = false;
                return;
            }
        }

        public static int PrintMenu()
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

        public static int PrintActionMenu()
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
