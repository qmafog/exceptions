namespace Exceptions
{
#pragma warning disable
    public static class ThrowingArgumentOutOfRange
    {
        public static bool CheckParameterAndThrowException1(int i)
        {
            if (i <= -5 || i >= 5)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }

            return true;
        }

        public static bool CheckParameterAndThrowException2(ulong l)
        {
            if (l < 0)
            {
                return false;
            }
            else if (l <= 7)
            {
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(l));
            }
        }

        public static bool CheckParametersAndThrowException3(uint i, double d)
        {
            bool cond1 = false, cond2 = false;
            if (i >= 0 && i < 5)
            {
                cond1 = true;
            }

            if (d >= -1.0 && d <= 1.0)
            {
                cond2 = true;
            }

            if (i >= 5)
            {
                throw new ArgumentOutOfRangeException(nameof(i), "i should be in [0, 5) interval.");
            }

            if (d < -1.0 || d > 1.0)
            {
                throw new ArgumentOutOfRangeException(nameof(d), "d should be in [-1.0, 1.0] interval.");
            }

            return cond1 && cond2;
        }

        public static bool CheckParametersAndThrowException4(long l, float f)
        {
            bool cond1 = false, cond2 = false;
            if ((l >= -9 && l < -3) || (l >= 3 && l < 9))
            {
                cond1 = true;
            }

            if (f > -0.3 && f < 0.3)
            {
                cond2 = true;
            }

            if (!cond1)
            {
                throw new ArgumentOutOfRangeException(nameof(l), "l should be in [-9, -3) or [3, 9) intervals.");
            }

            if (!cond2)
            {
                throw new ArgumentOutOfRangeException(nameof(f), "f should be in the (-0.3, 0.3) interval.");
            }

            return cond1 && cond2;
        }
    }
}
