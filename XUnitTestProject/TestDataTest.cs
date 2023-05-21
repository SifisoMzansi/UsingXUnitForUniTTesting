using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitLibrary.Models;

namespace XUnitLibrary.Test
{
    public class TestDataTest
    {

        [Theory]
        [ClassData(typeof(TestData) )]
        public void CompareValuesFromInputList(int a , int b, int c)
        {
            //Prep 
            int Expected = c;
            //act 
            int Actual = a + b;
            //assert
            Assert.Equal(Expected, Actual);
        }
    }

}
