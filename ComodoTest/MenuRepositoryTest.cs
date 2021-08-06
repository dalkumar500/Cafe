using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComodoTest
{ 
   [TestClass]
    public class MenuRepositoryTest
    {
        private MenuRepository _repo;
        private MenuContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _content = new MenuContent();
            _repo.AddMealToList(_content);
        }
              //Add Method

        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            //Arrange---Setting up the playing field
            MenuContent content = new MenuContent();
            content.MealName = "Classic Burger";
            MenuRepository repository = new MenuRepository();

            //Act---Get/run the code we want to test
            repository.AddMealToList(content);
            MenuContent contentFromDirectory = repository.GetContentByMealNumber(1);

            //Assert--- Use the assert class to verify 
            Assert.IsNotNull(contentFromDirectory);
          }
       
        }

    }

