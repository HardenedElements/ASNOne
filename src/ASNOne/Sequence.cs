using Org.BouncyCastle.Asn1;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ASNOne
{
	public class Sequence : Encodable, IEnumerable<Encodable>
	{
		private class SequenceEnumerator : IEnumerator<Encodable>
		{
			private Asn1Sequence Sequence;
			private int Index = -1;
			public Encodable Current => Index < 0 || Index > Sequence.Count - 1 ? null : From(Sequence?[Index]?.ToAsn1Object());
			object IEnumerator.Current => Current;

			internal SequenceEnumerator(Asn1Sequence sequence) => Sequence = sequence;
			public void Dispose() { }

			public bool MoveNext()
			{
				Index++;
				return Index > Sequence.Count - 1 ? false : true;
			}
			public void Reset() => Index = -1;
		}
		internal Sequence(Asn1Sequence sequence) : base(sequence) { }

		public IEnumerator<Encodable> GetEnumerator() => new SequenceEnumerator((Asn1Sequence)ASN1);
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		public override string ToString() => $"[Sequence ({this.Count()} elements)]";
	}
}
