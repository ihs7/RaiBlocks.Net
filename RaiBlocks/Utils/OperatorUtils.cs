using System;

namespace RaiBlocks.Utils
{
    public class OperatorUtils
    {
        public static TType TryExplicitCast<TType, TValue>(Func<TType> castOperation, TValue value)
        {
            try
            {
                return castOperation();
            }
            catch (Exception ex)
            {
                throw new InvalidCastException($"Could not cast the value '{value}' to an instance of {typeof(TType)}", ex);
            }
        }
    }
}
