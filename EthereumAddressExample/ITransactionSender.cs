namespace EthereumAddressExample
{
    public interface ITransactionSender
    {
        string Send(string privateKeyHex, RawTransaction transaction);
        string Send(byte[] privateKey, RawTransaction transaction);
    }

    public class RawTransaction
    {
        public string ToAddress { get; set; }
        public string Amount { get; set; }
    }
}