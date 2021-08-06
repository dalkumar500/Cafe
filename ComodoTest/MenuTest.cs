using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;

namespace ComodoTest
{
    [TestClass]
    public class MenuTest
    {
        [TestMethod]
       public void SetTitle_ShouldSetCorrectString()
            {
                 //Arrange
                MenuContent content = new MenuContent();

                content.MealName = "Classic Burger";
                 //Act
                String expected = "Classic Burger";
                string actual = content.MealName;
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }



   