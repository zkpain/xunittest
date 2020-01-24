using Xunit;
using System;

namespace xunittest
{
   
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Console.Write("----------------------------------------------------xunit------------------");
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Console.Write("-------------------------xunit2------------------");
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
