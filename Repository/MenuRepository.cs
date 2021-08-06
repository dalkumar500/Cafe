using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class MenuRepository
    {

        public List<MenuContent> _listOfMenu = new List<MenuContent>();

        //create
        public void AddMealToList(MenuContent newmeal)
        {
            _listOfMenu.Add(newmeal);

        }

        //Read
        public List<MenuContent> GetMealList()
        {
            return _listOfMenu;
        }


        //Delete
        public bool RemoveContentFromList(int mealnumber)
        {
            MenuContent content = GetContentByMealNumber(mealnumber);
          
            if (content == null)
            {
                return false;

            }
               int intialCount = _listOfMenu.Count;
                 _listOfMenu.Remove(content);
            
            if (intialCount > _listOfMenu.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method 

        public MenuContent GetContentByMealNumber(int mealnumber)

        {
            foreach (MenuContent content in _listOfMenu)
            {
                if (content.MealNumber == mealnumber)
                {
                    return content;
                }

            }

            return null;

        }
    }

}




