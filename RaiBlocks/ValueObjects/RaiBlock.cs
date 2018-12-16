using System;
using System.Collections.Generic;

namespace RaiBlocks.ValueObjects
{
    public class RaiBlock : ValueObject
    {
        public string Value { get; }

        public RaiBlock(string value)
        {
            if (!value.StartsWith("xrb_"))
                throw new ArgumentException("Illegal address - Does not start with xrb_");

            if (value.Length <= 4)
                throw new ArgumentException("Illegal address - Must be longer than 4.");

            Value = value;
        }

        private RaiBlock() { }

        public override string ToString()
            => Value;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static implicit operator string(RaiBlock x)
            => x.Value;
    }
}
