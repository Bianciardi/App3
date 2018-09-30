using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public static class OperatorHelper
    {


        public static bool Calculate(string bottone)
        {
            bool result = false;
            switch (bottone)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    result=true;
                    break;
                default:
                    result=false;
                    break;


            }
            return result;

        }


    }
}
