using System;

namespace sample_dotnet_application
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = new DateTime(2021, 12, 10, 07, 10, 10);

            var id = TZConvert.GetTimeZoneInfo("America/Los_Angeles");
            var id2 = TZConvert.GetTimeZoneInfo("America/Phoenix");
            try
            {
          
                Console.WriteLine("{0}", TimeZoneInfo.ConvertTimeToUtc(time1, id));
                Console.WriteLine("{0}", TimeZoneInfo.ConvertTimeToUtc(time1, id2));
            }



            catch (TimeZoneNotFoundException)
            {
                Console.WriteLine("Unable to find the zone");
            }
        }
    }
}
