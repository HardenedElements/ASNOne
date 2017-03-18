using Org.BouncyCastle.Asn1;
using System;

namespace ASNOne
{
	public class UTCDateTime : Encodable
	{
		public DateTime Value => ((DerUtcTime)ASN1).ToDateTime();
		internal UTCDateTime(DerUtcTime value) : base(value) { }
	}
}
