using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    public static class SystemUnderTest
    {
        public static int MyMax(this IEnumerable<int> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int num;
            using (IEnumerator<int> enumerator = source.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                {
                    throw new ArgumentException("No max defined for an empty list");
                }

                num = enumerator.Current;
                while (enumerator.MoveNext())
                {
                    int current = enumerator.Current;
                    if (current > num)
                        num = current;
                }
            }

            return num;
        }

        //bad implementation number 1 ;-)

//        public static int MyMax(this IEnumerable<int> source)
//        {
//            var enumerable = source.ToList();
//            if (enumerable.Count < 2)
//            {
//                return Int32.MaxValue;
//            }
//
//            return enumerable.Skip(1).First();
//        }


//bad implementation number 2 ;-)

//        public static int MyMax(this IEnumerable<int> source)
//        {
//            return Int32.MaxValue;
//        }
    }
}