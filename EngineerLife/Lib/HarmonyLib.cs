using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerLife.Lib
{
    public class HarmonyLib
    {
        private bool isRunning;
        private int counter;

        private int DoSomething()
        {
            if (isRunning)
            {
                counter++;
                return counter * 10;
            }
            return 0;
        }

        public int DoSomethingUsingOther(int input)
        {
            return HarmonyLibUsing.DoSomething(input);
        }
    }

    public class HarmonyLibUsing
    {
        private bool isRunning;
        private int counter;

        public static int DoSomething(int input)
        {
            return input * 10 ;
        }
    }
}
