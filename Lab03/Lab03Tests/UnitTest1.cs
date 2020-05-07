
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
            string path = "NomsList.txt";
            string lists = "joy to the lab";
           // File.WriteAllText(path, lists);
            string result = NomsList.ViewList(path);
            Assert.Equal(lists,result);
        }
        [Fact]
        public void CanWriteGood()
        {
            string path = "NomsList.txt";
            string lists = "joy to the lab";
            string result = File.ReadAllText(path);
            NomsList.AddItem(path, lists);
            Assert.Equal(lists, result);
        }

    }
}
