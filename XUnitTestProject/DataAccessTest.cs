using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnitLibrary.Models;

namespace XUnitLibrary.Test
{
    public class DataAccessTest
    {
        [Fact]
        public void AddPersonToList_ShouldWork()
        {
            PersonModel NewPerson = new PersonModel()
            {
                FirstName = "Sifiso", LastName="Khoza"
            };

            PersonModel NewPerson2 = new PersonModel()
            {
                FirstName = "Sifiso",
                LastName = "Khoza"
            };
            List<PersonModel> NewList = new List<PersonModel>();
             

            DataAccess.AddPersonToPeopleList(NewList , NewPerson);
            Assert.True(NewList.Count ==1);
            Assert.Contains<PersonModel>(NewPerson, NewList);
        }


        [Theory]
       // [InlineData("Sifiso", "Khoza", "LastName")]
        [InlineData("Sifiso", "", "LastName")]
        //[InlineData("Sifiso", "", "")]
        public void AddPersonToList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel NewPerson = new PersonModel()
            {
                FirstName = firstName,
                LastName = lastName
            };

            List<PersonModel> People = new List<PersonModel>();
            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(People, NewPerson));
        }
    }
}
