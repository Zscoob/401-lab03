
using Lab03;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
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

        /*
        [Fact]
        public void CanWriteGood()
        {
            string path = "Assets/list.txt";
            string lists = "joy to the lab";
            string result = File.ReadAllText(path);
            NomsList.AddItem(path, lists);
            Assert.Equal(lists, result);
        }
        */
        //public void CanEraseGood()

    }
}
