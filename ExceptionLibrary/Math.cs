using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionLibrary {
    public class Math {

        public static int Add(int i1, int i2) {

            return i1 + i2;
        }

        public static int Sub(int i1, int i2) {

            return i1 - i2;
        }
        public static int Mult(int i1, int i2) {

            var ans = i1 * i2;
            if (ans >= 100)
            {

                var exMore = new Ex100orMoreException("In Math.Multi()");
                exMore.i1 = i1;
                exMore.i2 = i2;
                throw exMore;
            }

            return i1 * i2;
        }

        public static int Div(int i1, int i2) {
            if (i1 == 1783)
            {

                var ex = new Ex17183Exception("Test Exception");
                ex.AdditonalData = " In the DIV Method";
                throw ex;
            }
        
           
            return i1 / i2;
        }
    }
}

