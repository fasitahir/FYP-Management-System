using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMidProject
{
    class Validation
    {
        public static bool NameValidation(string name)
        {
            bool flag = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            foreach (char c in name)
            {
                if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }


        public static bool IntValidation(string value)
        {

            if (int.TryParse(value.ToString(), out int intValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool IntValidation(string value, int lowerLimit, int upperLimit)
        {

            if (int.TryParse(value.ToString(), out int intValue))
            {
                if (intValue >= lowerLimit && intValue <= upperLimit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static bool DoubleValidation(string value)
        {

            if (double.TryParse(value.ToString(), out double intValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool DoubleValidation(string value, int lowerLimit, int upperLimit)
        {

            if (double.TryParse(value.ToString(), out double intValue))
            {
                if (intValue >= lowerLimit && intValue <= upperLimit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

}
