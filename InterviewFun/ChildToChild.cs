using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewFun
{
    public class ChildToChild
    {
        public OutChild ConvertTypeChild<InChild, OutChild, Father>(InChild inChild) 
            where InChild : class, Father
            where OutChild : class, Father
            where Father : class
        {
            Father father = inChild as Father;
            if (father is OutChild)
            {

            }
            else
            {

            }
            return father;
        }
    }



    public class Car
    {
        public string Shape { get; set; }
        public int Length { get; set; }
        public int width { get; set; }
    }

    public class Bus : Car
    {
        public int MaximumLoad { get; set; }
    }

    public class SportsCar : Car
    {
        public string Tail { get; set; }
    }
}
