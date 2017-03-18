using Org.BouncyCastle.Asn1;
using System.Numerics;

namespace ASNOne
{
	public class Integer : Encodable
	{
		public BigInteger Value => ToBigInteger(((DerInteger)ASN1).Value);
		public BigInteger PositiveValue => ToBigInteger(((DerInteger)ASN1).PositiveValue);
		internal Integer(DerInteger value) : base(value) { }
		private BigInteger ToBigInteger(Org.BouncyCastle.Math.BigInteger value) => new BigInteger(value.ToByteArray());
		public override string ToString() => $"[Integer: {Value}]";
	}
}
