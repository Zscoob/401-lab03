
using Lab03;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Lab03Tests
{
    public class Noms
    {
        [Fact]
        public void CanReadGood()
        {
            //Arrange
            string path = @"Assets/readTest.txt";
            string[] foodArray = new string[5] { "nutella", "salad", "milk", "eggs", "bacon" };
            File.WriteAllLines(path, foodArray);
            string expected = "nutella, salad, milk, eggs, bacon,";

            //act
            string result = NomsList.ViewList(path);

            // File.WriteAllText(path, lists);

            Assert.Equal(expected,result);
        }


        [Fact]
        //testing to see if the method can add an item
        public void CanWriteGood()
        {
            //Arrange
            string path = @"Assets/append.txt";
            string[] lists = new string[] { "ayyyy" };
            File.WriteAllLines(path, lists);
            string woo = "pies";

            //Act
            NomsList.AddItem(path, woo);
            string[] lolol = new string[] { "ayyyy", "pies" };
            string[] result = File.ReadAllLines(path);
            string result2 = NomsList.ViewList(path);
            string expected2 = "ayyyy, pies,";

            //Assert
            Assert.Equal(lolol, result);
            Assert.Equal(expected2, result2);
        }

        [Fact]
        public void CanEraseGood()
        {
            //Arrange
            string path = @"Assets/deleteTest.txt";
            string[] foodArray = new string[5] { "nutella", "salad", "milk", "eggs", "bacon" };
            File.WriteAllLines(path, foodArray);
            string expected = "nutella, milk, eggs, bacon,";

            //Act
            NomsList.DelItem(path, "salad");
            string result = NomsList.ViewList(path);


            //Assert
            Assert.Equal(expected, result);
        }

    }
}
