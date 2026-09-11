using Tyuiu.LeksikovKA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.LeksikovKA.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {

        [Test]
        public void CheckGetMessageValid()
        {
            var name = "Костя";
            var res = DataService.GetMessage(name);

            Assert.That(res, Is.EqualTo("Привет, Костя"));
        }

    }
}