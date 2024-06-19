using System;

namespace pk3DS.Core.MathHelper
{
    public static class MathHelper
    {
        // https://stackoverflow.com/questions/5124743/algorithm-for-simplifying-decimal-to-fractions
        public static int[] FloatToFraction(float f, float err = 0.000001f)
        {
            int n = (int)MathF.Floor(f);
            f -= n;

            if (f < err)
                return new int[2] { n, 1 };
            else if (1 - err < f)
                return new int[2] { n + 1, 1 };

            int lowerN = 0;
            int lowerD = 1;
            int upperN = 1;
            int upperD = 1;

            while (true)
            {
                int middleN = lowerN + upperN;
                int middleD = lowerD + upperD;

                if (middleD * (f + err) < middleN)
                {
                    upperN = middleN;
                    upperD = middleD;
                }
                else if (middleN < (f - err) * middleD)
                {
                    lowerN = middleN;
                    lowerD = middleD;
                }
                else
					return new int[2] { n * middleD + middleN, middleD };
            }
        }
    }
}
