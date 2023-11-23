namespace TimeZone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var utcDate = DateTime.UtcNow;

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones )
            {
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("-------");
            }
        }
    }
}