using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
        //Plain Old c# Object---POCO
        public class MenuContent
        {
            
            public string  MealName { get; set; }
            
            public int  MealNumber { get; set; }
            
            public string  Description  { get; set; }

             
            public string  Ingredients{ get; set; }
            
            public double Price { get; set; }

            public  MenuContent() { }

        public MenuContent( string mealname, int mealnumber, string description, string ingredients,double price)
            {
                     
                   MealName = mealname;
                   MealNumber = mealnumber;
                   Description =description ;
                   Ingredients = ingredients;
                   Price = price;
               

            }





        }
    }




