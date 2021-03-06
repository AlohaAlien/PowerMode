﻿namespace BigEgg.Tools.PowerMode.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class RandomUtils
    {
        private static Random random = new Random(DateTime.Now.Millisecond);


        public static Random Random { get { return random; } }


        public static string NextString(IList<string> stringList)
        {
            return stringList[random.Next(0, stringList.Count)];
        }

        public static int NextSignal()
        {
            return random.Next(0, 2) == 1 ? 1 : -1;
        }

        public static Color NextColor()
        {
            var bytes = new byte[3];
            random.NextBytes(bytes);

            return Color.FromArgb(bytes[0], bytes[1], bytes[2]);
        }
    }
}
