using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_C_Sharp
{
    public class Replacement
    {
        private int _num;
        private int _SIZE = 6;
        public void SetNums(int num)
        {
            if (num < 100000 || num > 999999)
                throw new Exception("Error/ SetNums");
            else
            {
                _num = num;
            }

        }
        public int GetNums()
        {
            return _num;
        }
        public void ChangePlaces(int firstIndex, int secondIndex)
        {
            if (firstIndex < 1 || firstIndex > 6 || secondIndex < 1 || secondIndex > 6)
                throw new Exception("Error / ChangePlaces");
            string numberString = _num.ToString();
            char[] charArray = numberString.ToCharArray();

            char temp = charArray[firstIndex - 1];
            charArray[firstIndex - 1] = charArray[secondIndex - 1];
            charArray[secondIndex - 1] = temp;

            _num = int.Parse(new string(charArray));

        }
    }
}
