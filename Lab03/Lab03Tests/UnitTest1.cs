
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
            string path = @"Assets/list.txt";
            string food = "I need: nutella, salad, milk, eggs, bacon";

            //act

           // File.WriteAllText(path, lists);
            string result = NomsList.ViewList(path);
            Assert.Equal(food,result);
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
