using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitLibrary.Test
{
    public class ExampleTest
    {
        [Fact]
        public void ExampleLoadTextFile_validNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("Thisi is a valid file name");
            Assert.True(actual.Length > 0);
        }
        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFail()
        {
            Assert.Throws<FileNotFoundException>(() => Examples.ExampleLoadTextFile("sa"));
        }
        [Fact]
        public void ExampleLoadTextFile_InvalidNameShouldFailParam()
        {
            Assert.Throws<ArgumentException>("file2",() => Examples.ExampleLoadTextFileWithArgument("sa"));
        }
    }
}
