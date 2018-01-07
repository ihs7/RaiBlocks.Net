using System;
using System.Numerics;

namespace RaiBlocks
{
    public class RaiUnits
    {
        public class RaiRaw : IEquatable<RaiRaw>
        {
            public BigInteger Value { get; private set; }

            public RaiRaw(string value)
            {
                if (!BigInteger.TryParse(value, out var x)) throw new InvalidCastException($"Can not convert {value} to RAW.");

                Value = x;
            }

            public bool Equals(RaiRaw other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Equals(Value, other.Value);
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
