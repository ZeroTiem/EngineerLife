using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion
{
    public class Defanging_an_IP_Address_No1108
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
