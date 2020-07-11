﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExerciseCuration.Core
{
    public static class staticRandom
    {
        private static int seed;

        private static readonly ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
            (() => new Random(Interlocked.Increment(ref seed)));

        static staticRandom()
        {
            seed = Environment.TickCount;
        }

        public static Random Instance { get { return threadLocal.Value; } }
    }
}
