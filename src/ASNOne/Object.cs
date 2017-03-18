namespace ASNOne
{
	public class Object : Encodable
	{
		internal Object(Org.BouncyCastle.Asn1.Asn1Object value) : base(value) { }
		public override string ToString() => "[Object]";
	}
}
