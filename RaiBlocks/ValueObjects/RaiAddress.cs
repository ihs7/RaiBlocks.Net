using RaiBlocks.Utils;
using System;

namespace RaiBlocks.ValueObjects
{
    public class RaiAddress : IEquatable<RaiAddress>
    {
        public string Value { get; private set; }

        public RaiAddress(string value)
        {
            if (!value.StartsWith("xrb_"))
                throw new ArgumentException("Illegal address - Does not start with xrb_");

            if (value.Length <= 4)
                throw new ArgumentException("Illegal address - Must be longer than 4.");

            Value = value;
        }

        private RaiAddress() { }

        public bool Equals(RaiAddress other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return obj is RaiAddress && Equals((RaiAddress)obj);
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(Value);
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(RaiAddress x)
        {
            return x.Value;
        }

        public static explicit operator RaiAddress(string x)
        {
            return OperatorUtils.TryExplicitCast(() => new RaiAddress(x), x);
        }

        public static bool operator ==(RaiAddress a, RaiAddress b)
        {
            return ReferenceEquals(a, b) ? true : (a is null) || (b is null) ? false : a.Equals(b);
        }

        public static bool operator !=(RaiAddress a, RaiAddress b)
        {
            return !(a == b);
        }
    }
}
