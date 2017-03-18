using Org.BouncyCastle.Asn1;
using System.Linq;

namespace ASNOne
{
	public class BitString : Encodable
	{
		public byte[] Value => ((DerBitString)ASN1).GetOctets();
		internal BitString(DerBitString value) : base(value) { }
		public override string ToString() => $"[Bit string: {string.Join(":", Value.Select(_ => _.ToString("X2")))}]";
	}
}
