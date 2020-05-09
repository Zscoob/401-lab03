
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
            string food = "I need: nutella, salad, milk, eggs, bacon";
            string[] foodArray = new string[5] { "nutella", "salad", "milk", "eggs", "bacon" };
            File.WriteAllLines(path, foodArray);
            string expected = "nutella\r\nsalad\r\nmilk\r\neggs\r\nbacon\r\n";

            //act
            string result = NomsList.ViewList(path);

            // File.WriteAllText(path, lists);

            Assert.Equal(expected,result);
        }


        [Fact]
        public void CanWriteGood()
        {
            string path = @"Assets/append.txt";
            string[] lists = new string[] { "ayyyy" };
            File.WriteAllLines(path, lists);
            string[] woo = new string[] { "pies" };
            NomsList.AddItem(path, woo);
            string[] lolol = new string[] { "ayyyy", "pies" };
            string[] result = File.ReadAllLines(path);
            Assert.Equal(lolol, result);
        }
        
        //public void CanEraseGood()

    }
}
