using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core
{
    public interface IValue
    {
        //public T Value { get; set; }
    }

    public class SingleValue<T> : IValue
    {
        public T Value
        {
            get; set;
        }

        public SingleValue(T value) { this.Value = value; }

    }

    public class MultiValue<T> : IValue
    {
        public T[] Value
        {
            get; set;
        }

        public MultiValue(T[] value) { this.Value = value; }

    }
}
