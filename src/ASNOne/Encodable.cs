namespace ASNOne
{
	public abstract class Encodable
	{
		internal Org.BouncyCastle.Asn1.Asn1Encodable ASN1 { get; private set; }

		private Encodable() { }
		internal Encodable(Org.BouncyCastle.Asn1.Asn1Encodable asn1) => ASN1 = asn1;

		internal static Encodable From(Org.BouncyCastle.Asn1.Asn1Object asn1)
		{
			if(asn1 is Org.BouncyCastle.Asn1.Asn1Sequence sequence) {
				return new Sequence(sequence);
			} else if(asn1 is Org.BouncyCastle.Asn1.Asn1Set set) {
				return new Set(set);
			} else if(asn1 is Org.BouncyCastle.Asn1.Asn1TaggedObject taggedObject) {
				return new TaggedObject(taggedObject);
			} else if(asn1 is Org.BouncyCastle.Asn1.Asn1OctetString octetString) {
				return new OctetString(octetString);
			} else if(asn1 is Org.BouncyCastle.Asn1.DerInteger derInteger) {
				return new Integer(derInteger);
			} else if(asn1 is Org.BouncyCastle.Asn1.DerUtcTime derUtcTime) {
				return new UTCDateTime(derUtcTime);
			} else if(asn1 is Org.BouncyCastle.Asn1.DerUtf8String derUtf8String) {
				return new UTF8String(derUtf8String);
			} else if(asn1 is Org.BouncyCastle.Asn1.DerObjectIdentifier derOID) {
				return new Oid(derOID);
			} else if(asn1 is Org.BouncyCastle.Asn1.DerBitString derBits) {
				return new BitString(derBits);
			} else {
				return new Object(asn1);
			}
		}
		public static Encodable FromBytes(byte[] bytes) => From(Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(bytes));
		public override string ToString() => "[Entity]";
	}
}
