using System;
using Xunit;
using Datastructures.Lists;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            SLinkedList<int> slist = new SLinkedList<int>();
            for(int i = 0; i <=10 ; i++)
                slist.AddNode(i);

            Console.WriteLine(slist.ToString());

            Console.WriteLine("middle node is");
            Console.WriteLine(slist.FindMid().Value.ToString());
        }
    }
}
