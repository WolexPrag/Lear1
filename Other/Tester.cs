using Learn1.Other.Chararcteristics;
using System.Diagnostics;

namespace Learn1.Other.Tester
{
    public delegate void TestDelegate();
    public static class Tester
    {

        public static long Test(TestDelegate delegatForTest)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            delegatForTest.Invoke();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        public static long MultipleTest(TestDelegate delegatForTest ,int count = 10)
        {
            long[] times = new long[count];
            for (int i = 0; i < count; i++)
            {
                times[i] = Test(delegatForTest:delegatForTest);
            }
            long midleTime = 0;
            foreach(long time in times)
            {
                midleTime += time;
            }
            midleTime = midleTime / count;
            return midleTime;
        }
    }
}
