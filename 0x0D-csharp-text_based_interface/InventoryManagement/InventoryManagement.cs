using System;
using System.Collections.Generic;
using InventoryLibrary;
namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            JSONStorage myStorage = new JSONStorage();
            myStorage.Load();
            string[] testColection = {"part", "computer part", "fragile"};
            Item testItem = new Item("testItem1", "Just a Test",6.0f, new List<String>(testColection));
            //Console.WriteLine(testItem.name);
            myStorage.New(testItem);
            myStorage.Save();
            Dictionary<String, String> myDict;
            String myIO(string propt)
            {
                Console.Write(propt);
                return(Console.ReadLine().ToLower().Trim());
            }
            bool getBegining(string wholeString)
            {
                String first = wholeString.Split('.')[0];
                if (first == "Item")
                    return (true);
                return (false);
            }
            string getEnd(string wholeString)
            {
                String first = wholeString.Split('.')[1];
                return (first.ToLower());
            }
            string getType(string wholeString)
            {
                String first = wholeString.Split('.')[0];
                return (first.ToLower());
            }
            void ShowAll(int x)
            {
                myDict = myStorage.All();
                switch (x)
                {
                    case 0:
                        foreach(var entry in myDict)
                        {
                            Console.WriteLine($"{entry.Value} ID:{getEnd(entry.Key)}");
                        }
                        break;
                    case 1:
                        foreach(var entry in myDict)
                        {
                            if (!getBegining(entry.Key))
                            {
                                Console.WriteLine($"{entry.Value} ID:{getEnd(entry.Key)}");
                            }
                        }
                        break;
                    case 2:
                        foreach(var entry in myDict)
                        {
                            if (getBegining(entry.Key))
                            {
                                Console.WriteLine($"{entry.Value} ID:{getEnd(entry.Key)}");
                            }
                        }
                        break;
                }
            }
            void Create()
            {
                string classType = myIO("Would you like to create a <User> or <Item>?\n:");
                if ((classType != "user") && (classType != "item"))
                {
                    myIO($"<{classType}> is not a valid object type... please enter <User> or <Item>\n Press enter to try again...");
                    Create();
                }
                string newName = myIO("Please enter the name:");
                if (newName == "")
                {
                    myIO("You must enter a name...\n Press enter to try again...");
                    Create();
                }
                if (classType == "user")
                {
                    User newUser = new User(newName);
                    myStorage.New(newUser);
                    myStorage.Save();
                    myIO($"User {newName} Created!\nPress Enter to continue...\n");
                }
                else
                {
                    string description = myIO("Please enter a discription of the item if you would like one stored\n:");
                    float price = float.Parse(myIO("Please enter a price of the item if you would like one stored\n:"));
                    float priceReal = (float)Math.Round(price * 100f) / 100f;
                    string tagsEnterd = myIO("Please enter any tags (in one line separated by spaces) for the item if you would like any stored\n:");
                    List<string> tags = new List<string>(tagsEnterd.Split(' '));
                    Item newItem = new Item(newName, description, priceReal, tags);
                    myStorage.New(newItem);
                    myStorage.Save();
                    myIO($"Item {newName} Created!\nPress Enter to continue...\n");
                }
            }
            void Show()
            {
                string classType = myIO("Would you like to create a <User> or <Item>?\n:");
                if ((classType != "user") && (classType != "item"))
                {
                    myIO($"<{classType}> is not a valid object type... please enter <User> or <Item>\n Press enter to try again...");
                    Show();
                }
                string enterdID = myIO("Please enter the id of the item you would like to show\n:");
                myDict = myStorage.All();
                foreach(var entry in myDict)
                {
                    if (getEnd(entry.Key.ToLower()) == enterdID)
                    {
                        Console.WriteLine(entry.Value);
                        return;
                    }
                }
                myIO($"Object <id> could not be found...\n Press enter to try again...");
                Show();
            }
            void Delete()
            {
                string classType = myIO("Would you like to delete a <User> or <Item>?\n:");
                if ((classType != "user") && (classType != "item"))
                {
                    myIO($"<{classType}> is not a valid object type... please enter <User> or <Item>\n Press enter to try again...");
                    Delete();
                }
                string enterdID = myIO("Please enter the id of the item you would like to show\n:");
                myDict = myStorage.All();
                foreach(var entry in myDict)
                {
                    if (getEnd(entry.Key.ToLower()) == enterdID)
                    {
                        myStorage.objects.Remove(entry.Key);
                        myStorage.Save;
                        return;
                    }
                }
                myIO($"Object <id> could not be found...\n Press enter to try again...");
                Delete();
            }
            while(true)
            {
                string responce = myIO($"Inventory Manager\n{"-------------------------"}\n<ClassNames> show all ClassNames of objects\n<All> show all objects\n<All Users> show all Users\n<All Items> show all Items\n<Create> a new object\n<Show> an object\n<Update> an object\n<Delete> an object\n<Exit>\nPlease enter a command from the list above: ");
                switch (responce)
                {
                    case "classnames":
                        myIO("Avalible class names are: Item, User\nPress Enter to continue...\n");
                        break;
                    case "all":
                        Console.WriteLine("Here is a list of all entries:");
                        ShowAll(0);
                        myIO("Press Enter to continue...\n");
                        break;
                    case "all users":
                        Console.WriteLine("Here is a list of all Users:");
                        ShowAll(1);
                        myIO("Press Enter to continue...\n");
                        break;
                    case "all items":
                        Console.WriteLine("Here is a list of all Items:");
                        ShowAll(2);
                        myIO("Press Enter to continue...\n");
                        break;
                    case "create":
                        Create();
                        break;
                    case "show":
                        Create();
                        break;
                    default:
                        myIO("Command not recognized...\nPress Enter to try again...\n");
                        break;


                }
            }
        }
    }
}
