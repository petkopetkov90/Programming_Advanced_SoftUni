using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodString;

public class Box<T> where T : IComparable<T> 
{
    private T value;

    public Box(T value)
    {
        this.value = value;
    }

    public T Value { get { return value; } }

    public override string ToString()
    {
        return $"{typeof(T)}: {value}";
    }
}
