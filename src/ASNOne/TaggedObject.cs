using Org.BouncyCastle.Asn1;

namespace ASNOne
{
	public class TaggedObject : Encodable
	{
		public int TagNumber => ((Asn1TaggedObject)ASN1).TagNo;
		public Encodable Object => From(((Asn1TaggedObject)ASN1).GetObject());
		internal TaggedObject(Asn1TaggedObject taggedObject) : base(taggedObject) { }
		public override string ToString() => $"[Tagged object: {TagNumber}/{Object?.ToString() ?? "<null>"}]";
	}
}
