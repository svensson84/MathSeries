using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSeries.Services;

internal class MathService
{

    private const int THREAD_SIZE = 8;
    private static double[] partialSums = new double[THREAD_SIZE];

    internal static void computeAsync(out double asyncResult)
    {
        Stopwatch watch = new Stopwatch();
        watch.Start();

        Tuple<long, long>[] computeRanges = new Tuple<long, long>[8];
        computeRanges[0] = Tuple.Create<long, long>(0, 125000000);
        computeRanges[1] = Tuple.Create<long, long>(125000000, 250000000);
        computeRanges[2] = Tuple.Create<long, long>(250000000, 375000000);
        computeRanges[3] = Tuple.Create<long, long>(375000000, 500000000);
        computeRanges[4] = Tuple.Create<long, long>(500000000, 625000000);
        computeRanges[5] = Tuple.Create<long, long>(625000000, 750000000);
        computeRanges[6] = Tuple.Create<long, long>(750000000, 875000000);
        computeRanges[7] = Tuple.Create<long, long>(870000000, 1000000000);

        AutoResetEvent[] resetEvents = new AutoResetEvent[THREAD_SIZE];

        for (int i = 0; i < THREAD_SIZE; i++)
        {
            AutoResetEvent resetEvent = new AutoResetEvent(false);
            resetEvents[i] = resetEvent;

            long from = computeRanges[i].Item1;
            long to = computeRanges[i].Item2;
            int partialSumArrayIndex = i;

            Thread t = new Thread(() => { compute(from, to, partialSumArrayIndex, resetEvent); });
            t.IsBackground = true;
            t.Priority = ThreadPriority.Highest;
            t.Start();
        }

        WaitHandle.WaitAll(resetEvents);

        asyncResult = partialSums.ToList().Sum();

        watch.Stop();
        string output = String.Format("Time: {0}h {1}m {2}s {3}ms", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);
        Debug.WriteLine(output);
        Debug.WriteLine(asyncResult.ToString("G17"));
    }

    private static void compute(long from, long to, int partialSumIndex, AutoResetEvent autoReset)
    {
        try
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Debug.WriteLine(String.Format("  Thread {0} started [state={1} background={2} threadpool={3}]", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.ThreadState, Thread.CurrentThread.IsBackground, Thread.CurrentThread.IsThreadPoolThread));
            //partialSums[partialSumIndex] = Series.pi(from, to);
            watch.Stop();
            string output = String.Format("Time: {0}h {1}m {2}s {3}ms", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds);
            Debug.WriteLine(String.Format("  Thread {0} finished [{1}]", Thread.CurrentThread.ManagedThreadId, output));
        }
        catch
        {
        }
        finally
        {
            autoReset.Set();
        }
    }
}