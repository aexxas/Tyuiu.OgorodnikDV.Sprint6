using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.OgorodnikDV.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue + 1);
            double[] result = new double[len];
            int indx = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = ((Math.Cos(x) / (x - 0.4)) + Math.Sin(x) * 8 * x + 2);
                result[indx] = Math.Round(y, 2);
                indx++;

            }
            return result;
        }
    }
}
