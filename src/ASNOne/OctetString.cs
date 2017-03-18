using Org.BouncyCastle.Asn1;
using System.Linq;

namespace ASNOne
{
	public class OctetString : Encodable
	{
		public byte[] Value => ((Asn1OctetString)ASN1).GetOctets();
		internal OctetString(Asn1OctetString value) : base(value) { }
		public override string ToString() => $"[Octet string: {string.Join(":", Value.Select(_ => _.ToString("X2")))}]";
	}
}
