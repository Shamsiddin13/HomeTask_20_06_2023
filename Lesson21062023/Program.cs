using Lesson20062023;
using Lesson21062023;

ConvertMethod mathMethod = new ConvertMethod();

Action<double> inusdtouzs = mathMethod.InUsdConvertToUzs;
Action<double> inuzstousd = mathMethod.InUzsConvertToUsd;


Console.Write("Enter Usd: ");
double usd = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Uzs: ");
double uzs = Convert.ToInt32(Console.ReadLine());


inuzstousd(uzs);
inusdtouzs(usd);
