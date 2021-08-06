using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolecafe
{
    class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();


        //Method that Runs/Start the Application
        public void Run()
        {
            SeedItemsList();
            Menu();
        }
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                //Display our option to the user
                Console.WriteLine("Select a menu option:\n" +
                   "1. Add meal to menu\n" +
                   "2. View All Meals\n" +
                   "3. view meal by number\n" +
                   "4. Delete Exiciting meal\n" +
                   "5.Exit");
                //Get the user's input
                string input = Console.ReadLine();

                //Evaluate the user's input and act acoordingly
                switch (input)
                {
                    case "1":
                        //Create new Meal
                        CreateNewMeal();
                        break;
                    case "2":
                        //View All Meals
                        DisplayAllMeals();
                        break;

                    case "3":
                        //View Meals by Number
                        DisplayMealByNumber();
                        break;
                    case "4":
                        //Delete a Meal
                        DeleteMeals();
                        break;

                    case "5":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("please enter a valid number");
                        break;
                }
                Console.WriteLine("please press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // create new MenuContent
        private void CreateNewMeal()
        {

            Console.Clear();
            MenuContent newMeal = new MenuContent();

            
            //MealName
            Console.WriteLine("Enter the mealname:");
            newMeal.MealName = Console.ReadLine();

            //MealNumber
            Console.WriteLine("Enter the mealnumber:");
            
           
            string mealNumberASString = Console.ReadLine();
            newMeal.MealNumber = int.Parse(mealNumberASString);


            //Description
            Console.WriteLine("Enter the description for the meal:");
            newMeal.Description = Console.ReadLine();

            //Ingredients
            Console.WriteLine("Enter the ingredients for the meal:");
            newMeal.Ingredients = Console.ReadLine();
            Console.WriteLine("Enter the price of  the meal:");
            string priceASString = Console.ReadLine();
            newMeal.Price = double.Parse(priceASString);

            _menuRepo.AddMealToList(newMeal);


        }

        //view Current MenuContent that is saved
        private void DisplayAllMeals()
        {
            Console.Clear();
            List<MenuContent> listofMenu = _menuRepo.GetMealList();
            foreach (MenuContent meal in listofMenu)
            {
                Console.WriteLine($"Meal Number:{meal.MealNumber}\n" +
                    $"Meal Name:{meal.MealName}\n");
            }


        }
        //view existing Content by Number
        private void DisplayMealByNumber()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of the meal:");
            string numberAsString = Console.ReadLine();
            int mealNumber = int.Parse(numberAsString);
            MenuContent menuContent = new MenuContent(); 
            menuContent = _menuRepo.GetContentByMealNumber(mealNumber);
            
            if (mealNumber!= 0)
            {
                Console.WriteLine($"Meal Number:{menuContent.MealNumber}\n" +
                    $"Meal Name:{menuContent.MealName}\n" +
                    $"Meal Description:{menuContent.Description}\n" +
                    $"Meal Ingredients:{menuContent.Ingredients}\n" +
                    $"Meal Price:{menuContent.Price}");

            }
            else
            {
                Console.WriteLine("No meal by that Number!");


        }
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadLine();


        }

        // Deleate Exiciting Meal

        private void DeleteMeals()
        {
            DisplayAllMeals();

            // Get the meal they want to remove
            Console.WriteLine("\nEnter the Meal number you'd like to remove:");

            int input = int.Parse(Console.ReadLine());

            // call  the delete method
            bool wasDeleted = _menuRepo.RemoveContentFromList(input);

            //If the meal was deleated, say so
            // Otherwise say it could not be deleated
            if (wasDeleted)
            {
                Console.WriteLine("The meal was successfully deleated");
            }
            else
            {
                Console.WriteLine("the meal Could not be delated.");

            }

        }   //See Method

        private void SeedItemsList()
        {
            MenuContent ClassicBurger = new MenuContent("ClassicBurger", 1, "Not so basic burger topped with lettece tomato and red onion", "one and half pounds 80% lean 20% fat ground beef or ground chuck,four hamburger buns,one tablespoon Worcestershire sauce,one spoon garlic,one spoon salt,half spoon black pepper, four slices of cheese", 7.95);
            MenuContent HickoryBurger = new MenuContent("HickoryBurger", 2, "topped with cheddar cheese,hickory-smoked bacon and smacky barbecue sauce", "one teaspoon hickory liquid smoke,fourhamburger buns,one pound ground beef,cups iceberg lettuce, sliced into hamburger-sized leaves,Pickle slices,Mayonnaise", 9.95);
            MenuContent OnionBurger = new MenuContent("OnionBurger", 3, " onions and garlic mayo, topped with chopped green onions", "1 pound finely ground venison or beef,one onion,salt,black pepper,pickle,burgerBuns",9.95);
            MenuContent GreekBurger = new MenuContent("GreekBurger", 4, "ground lamb, minced red onions ,fresh oregano and feta cheese","one pound chicken,one onion,black pepper,buns,1/2 garlic ,one tomato,2 cheese", 10.95);
            MenuContent MushroomBurger = new MenuContent("MasroomBurger", 1, "swiss, three type of mushrooms and carmelized onions", "four buns ,1/2 cup Mushroom, 1 tomoto,1 onion,1/2 teaspoon blackpepper,1/2 garlic",9.95);
            _menuRepo.AddMealToList(ClassicBurger);
            _menuRepo.AddMealToList(HickoryBurger);
            _menuRepo.AddMealToList(OnionBurger);
            _menuRepo.AddMealToList(GreekBurger);
            _menuRepo.AddMealToList(MushroomBurger);
        }

    }
}



