using Microsoft.VisualStudio.TestTools.UnitTesting;
using CityInfo.Data;
using CityInfo.service;

namespace CityInfoTest
{
    [TestClass]
    public class CityInfoServiceTest
    {
        [TestMethod]
        public void Adding_New_City_Sends_An_Email()
        {
            //test setup
            var inMemoryRepo = new InMemoryDataRepositoy();
            var mailingService = new SendingMail(inMemoryRepo);
            int initialCount = inMemoryRepo.Count();


            // test service
            mailingService.Send(
                "Diwali Vacation",
                "I will be on vacation for next two weeks",
                "Kapil.bhudhia@klingelnberg.com",
                "Shweta.Jain@klingelnberg.com");

            // assert 
            Assert.AreEqual(initialCount + 1, inMemoryRepo.Count());
        }
    }
}
