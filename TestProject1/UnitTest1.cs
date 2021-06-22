using Ejercicio42;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestPositivo()
        {
            ClassOperator service = new ClassOperator();

            int character = service.result("a || b && !c");
            Assert.Equal(3, character);

        }
        [Fact]
        public void TestNegativo()
        {
            ClassOperator service = new ClassOperator();

            int character = service.result("a || b && !c");
            Assert.Equal(0, character);

        }
    }
}
