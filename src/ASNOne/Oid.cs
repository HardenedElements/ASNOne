using Org.BouncyCastle.Asn1;

namespace ASNOne
{
	public class Oid : Encodable
	{
		public string OID => ((DerObjectIdentifier)ASN1).Id;
		internal Oid(DerObjectIdentifier asn1) : base(asn1) { }
		public override string ToString() => $"[OID: {OID}]";
	}
}
