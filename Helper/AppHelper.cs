
namespace _15lab.Helper
{
    internal class AppHelper
    {
        public static double  CalculateAverage( params double[] numbers)
        {
            
            if ( numbers.Length == 0 ) return 0;
            return numbers.Sum() / numbers.Length;
        }
    }
}
