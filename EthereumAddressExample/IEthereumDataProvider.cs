namespace EthereumAddressExample
{
    public interface IEthereumDataProvider
    {
        ulong GetBalance(EthereumAddress address);
    }
}