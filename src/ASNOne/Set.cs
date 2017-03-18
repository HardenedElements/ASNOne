using Org.BouncyCastle.Asn1;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ASNOne
{
	public class Set : Encodable, IEnumerable<Encodable>
	{
		private class SetEnumerator : IEnumerator<Encodable>
		{
			private Asn1Set Set;
			private int Index = -1;
			public Encodable Current => Index < 0 || Index > Set.Count - 1 ? null : From(Set?[Index]?.ToAsn1Object());
			object IEnumerator.Current => Current;

			internal SetEnumerator(Asn1Set set) => Set = set;
			public void Dispose() { }

			public bool MoveNext()
			{
				Index++;
				return Index > Set.Count - 1 ? false : true;
			}
			public void Reset() => Index = -1;
		}
		internal Set(Asn1Set set) : base(set) { }

		public IEnumerator<Encodable> GetEnumerator() => new SetEnumerator((Asn1Set)ASN1);
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		public override string ToString() => $"[Set ({this.Count()} elements)]";
	}
}
