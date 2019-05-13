namespace EthereumAddressExample
{
    public static class EthereumUtils
    {
        public static string ToCheckSumAddress(string addressWithoutPrefix)
        {
            return addressWithoutPrefix;
        }

        public static string RemoveChecksum(this string value)
        {
            return value;
        }
                        
    }
}