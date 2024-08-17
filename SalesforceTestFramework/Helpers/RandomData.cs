
namespace SalesforceTestFramework.Helpers
{
    public class RandomData
    {
        private static Random _random;

        public static string RandomString(int length)
        {   
            _random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
