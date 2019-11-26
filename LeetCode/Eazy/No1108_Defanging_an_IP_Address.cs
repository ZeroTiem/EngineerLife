using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion
{
    public class No1108_Defanging_an_IP_Address
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
