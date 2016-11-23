using System;
using Xunit;
using CalcService.Service;


namespace Tests
{
    public class Tests
    {
        [Fact]
        public void AddTest() 
        {
            Calc c = new Calc();             
            Assert.Equal(30, c.add(10,10) );
        }
    }
}

