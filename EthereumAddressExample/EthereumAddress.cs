using System;

namespace EthereumAddressExample
{
    public class EthereumAddress : IComparable<EthereumAddress>
    {
        private readonly string _address;

        public EthereumAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
                throw new ArgumentException("address is empty'", nameof(address));

            var addressWithoutPrefix = address.RemoveHexPrefix();

            if (addressWithoutPrefix.Length != 40)
                throw new ArgumentException($"address has wrong length '{address}'", nameof(address));

            _address = EthereumUtils.ToCheckSumAddress(addressWithoutPrefix);
        }

        public string ExtractWithPrefix()
        {
            return _address;
        }

        public string ExtractWithoutPrefix()
        {
            return _address.RemoveHexPrefix();
        }

        protected bool Equals(EthereumAddress other)
        {
            return string.Equals(_address, other._address);
        }

        public static bool operator ==(EthereumAddress left, EthereumAddress right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EthereumAddress left, EthereumAddress right)
        {
            return !Equals(left, right);
        }

        public int CompareTo(EthereumAddress other)
        {
            return string.Compare(_address, other._address, StringComparison.Ordinal);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EthereumAddress) obj);
        }

        public override int GetHashCode()
        {
            return (_address != null ? _address.GetHashCode() : 0);
        }

    }
}