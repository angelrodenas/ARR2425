namespace FECHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
           foreach (var d in dateList)
           {
                Console.WriteLine(d.GetDateString());
                d.AddSeconds(5);
                Console.WriteLine("Despues de sumarle" + 5 + "segundos queda asi:" + d.GetDateString());
           }
        }
    }
}
