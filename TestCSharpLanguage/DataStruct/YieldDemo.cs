using System;
using System.Collections.Generic;
using System.Threading;

namespace TestCSharpLanguage.DataStruct
{
    public class YieldDemo
    {
        public IEnumerable<int> Power()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return Get(i);
            }
            
        }

        private int Get(int i)
        {
            Thread.Sleep(2000);
            return DateTime.Now.Second * i;
        }
    }
}
