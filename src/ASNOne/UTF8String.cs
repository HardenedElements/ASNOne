using Org.BouncyCastle.Asn1;

namespace ASNOne
{
	public sealed class UTF8String : Encodable
	{
		public string Value => ((DerUtf8String)ASN1).GetString();
		internal UTF8String(DerUtf8String value) : base(value) { }
		public override string ToString() => $"[UTF8 string: {Value}]";
	}
}
