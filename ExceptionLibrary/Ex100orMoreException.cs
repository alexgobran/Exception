using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionLibrary {
    class Ex100orMoreException : Exception {

        public int i1 { get; set; }
        public int i2 { get; set; }
        public Ex100orMoreException() : base() {

        }
        public Ex100orMoreException(string message) : base(message) {
        }
        public Ex100orMoreException(string message, Exception innerException)
            : base(message, innerException) {
        }
    }
}
