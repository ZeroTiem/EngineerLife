using System;
using System.Collections.Generic;
using System.Text;

namespace EngineerLife
{
    public class MyDelegate
    {
        public object Result;
        public void DemoFuncHaveReturn()
        {
            Func<int, int> func = (input) =>
            {
                return input + 1;
            };
            Result = func(2);
        }

        public void DemoFuncHaveReturn_Resharper()
        {
            int Func(int name) => name;
            Result = Func(2);
        }

        public void DemoFuncHaveReturn_Resharper1()
        {
            int Func(int name)
            {
                return name;
            }
            var adder = new Adder();
            Result = Func(2);
        }

        public void DemoFuncNotReturn()
        {
            Func<int> func = () => { return 1; };
            var adder = new Adder();
            Result = func();
        }

        public void DemoActionNoParameters()
        {
            Action action = () => { Result = "DemoActionNoParameters"; };
            var adder = new Adder();
            adder.PlusOneActionNoParameters(action);
        }

        public void DemoActionNoParameters_Resharper()
        {
            void WriteLineDemoActionOk()
            {
                Result = "DemoActionNoParameters_Resharper";
            }
            var adder = new Adder();
            adder.PlusOneActionNoParameters(WriteLineDemoActionOk);
        }

        public void DemoAction()
        {
            void WriteLine(string input)
            {
                Result = input;
            }
            var adder = new Adder();
            adder.PlusOneAction(WriteLine, "DemoAction");
        }
    }

    public class Adder
    {
        //宣告委派型別
        public delegate int MyDel();

        public void PlusOneActionNoParameters(Action action)
        {
            action.Invoke();
        }

        public void PlusOneAction(Action<string> action, string input)
        {
            action.Invoke(input);
        }
    }
}
