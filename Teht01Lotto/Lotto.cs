using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01Lotto
{
    class Lotto
    {
        private int number1;
        private int number2;
        private int number3;

        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
            }
        }

        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
        }

        public int Number3
        {
            get
            {
                return number3;
            }
            set
            {
                number3 = value;
            }
        }

        public override string ToString()
        {
            return Number1 + " " + Number2;
        }
    }
}
