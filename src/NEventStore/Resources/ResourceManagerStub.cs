namespace NEventStore
{
    public class ResourceManagerStub
    {
        public static string GetString(string key, System.Globalization.CultureInfo culture)
        {
            return key;
        }
    }
}