using System.Collections.Generic;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class PropertyBased
    {
        [FsCheck.NUnit.Property]
        public bool MyMaxIsInTheCollection(List<int> ints)
        {
            if (ints.Count == 0) return true;

            return ints.Contains(ints.MyMax());
        }

        [FsCheck.NUnit.Property]
        public bool MyMax(List<int> ints)
        {
            if (ints.Count == 0) return true;

            var myMax = ints.MyMax();
            return ints.TrueForAll(x => x <= myMax);
        }
    }
}