using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitLibrary.Models;

namespace XUnitLibrary.Test
{   
    public class ConvertModelsToCSVTest
    {
        [Fact]
        public void AddModelsToCSVShouldWork()
        {
            List<PersonModel> models = new List<PersonModel>() { new PersonModel() { FirstName="Sifiso" , LastName = "Khoza" }  };


            var Results =  DataAccess.ConvertModelsToCSV(models);

            Assert.True(Results.Count() == 1);
            Assert.True("Sifiso" == Results[0].Split(',')[0]);
            Assert.Contains<string>("Sifiso", Results[0].Split(','));

            Assert.True("Khoza" == Results[0].Split(',')[1]);
            Assert.Contains<string>("Khoza", Results[0].Split(','));

        }
    }
}
