using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EngineerLife.Study
{
    public class LazyStudy
    {
        static Lazy<LargeObject> lazyLargeObject = null;

        static LargeObject InitLargeObject()
        {
            LargeObject large = new LargeObject(Thread.CurrentThread.ManagedThreadId);
            // Perform additional initialization here.
            return large;
        }
    }

    class LargeObject
    {
        public int InitializedBy { get { return initBy; } }

        int initBy = 0;
        public LargeObject(int initializedBy)
        {
            initBy = initializedBy;
            Console.WriteLine("LargeObject was created on thread id {0}.", initBy);
        }

        public long[] Data = new long[100000000];
    }
}
