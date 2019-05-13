namespace EthereumAddressExample
{
    public class Service
    {
        public void CompareStringExample(string address, string otherAddress)
        {
            bool areSame = IsAddressEqual(address, otherAddress);

            bool areSame2 = address.RemoveHexPrefix().RemoveChecksum() ==
                           otherAddress.RemoveChecksum();

            // StringComparision type
        }

        private static bool IsAddressEqual(string address, string otherAddress)
        {
            return address.RemoveHexPrefix().RemoveChecksum() ==
                   otherAddress.RemoveHexPrefix().RemoveChecksum();
        }


        public void AfterEthereumAddress()
        {
            EthereumAddress address = new EthereumAddress(new string('a', 40));
            EthereumAddress otherAddress = new EthereumAddress(new string('b', 40));

            bool areSame = address == otherAddress;

            // StringComparision type?

        }
    }
}