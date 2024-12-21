using Tyuiu.OgorodnikDV.Sprint6.Task5.V3.Lib;

namespace Tyuiu.OgorodnikDV.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint6\Tyuiu.OgorodnikDV.Sprint6.Task5.V3\InPutDataFileTask5V3.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 2.5, -2.6, 5.7, -6.8, 9.9 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}