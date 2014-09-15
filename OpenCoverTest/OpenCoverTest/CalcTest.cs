using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OpenCoverTest
{
     [TestFixture]
    public class CalcTest
    {
         [Test]
         public void TestAdd()
         {
             //Arrange
             var calc = new Calc();

             //Act
             var result = calc.DoAdd(2, 3);

             //Assert
             Assert.AreEqual(result,5);
         }        

         [Test]
         public void TestSub()
         {
             //Arrange
             var calc = new Calc();

             //Act
             var result = calc.DoSub(5, 3);

             //Assert
             Assert.AreEqual(result, 2);
         }
    }
}
