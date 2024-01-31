﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuple
{
    public class MyTuple<T1, T2>
    {
        public MyTuple(T1 t1, T2 t2)
        {
            Item1= t1;
            Item2= t2;
        }

        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }

        public override string ToString()
            => $"{Item1} -> {Item2}";
        
    }
}