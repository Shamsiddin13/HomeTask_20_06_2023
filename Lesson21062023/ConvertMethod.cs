using Lesson21062023;

namespace Lesson20062023
{
    public class ConvertMethod : IConvertMethod
    {

        public override void InUzsConvertToUsd(double Uzs)
        {
            const double usd = 0.000087;
            
            double sum = Uzs * usd;
            Console.WriteLine($"\n{Uzs} sum in Usd = ${sum}");
        }

        public override void InUsdConvertToUzs(double Usd)
        {
            const double uzs = 11510.00;
            double sum = uzs * Usd;
            Console.WriteLine($"\n{Usd} dollar in Uzs sum = {sum}");

        }
    }
}
