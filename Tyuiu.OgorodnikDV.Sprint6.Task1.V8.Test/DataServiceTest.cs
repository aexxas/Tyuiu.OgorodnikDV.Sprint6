using Tyuiu.OgorodnikDV.Sprint6.Task1.V8.Lib;

namespace Tyuiu.OgorodnikDV.Sprint6.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] wait = new double[] { -36.41, -22.07, 5.68, 16.72, 8.34, -0.5, 9.63, 16.29, 5.01, -22.40, -36.30 };
            double[] res = ds.GetMassFunction(start, end);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}