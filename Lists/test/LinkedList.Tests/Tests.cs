using System;
using Xunit;
using Lists;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            SLinkedList s = new SLinkedList();
            Assert.Equal(10, s.add(3,2));
        }
    }
}
