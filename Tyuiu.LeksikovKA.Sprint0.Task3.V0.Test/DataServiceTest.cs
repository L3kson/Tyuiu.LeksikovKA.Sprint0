using Tyuiu.LeksikovKA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.LeksikovKA.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        
        [Test]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}