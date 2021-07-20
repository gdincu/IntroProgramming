using System;
using System.Collections.Generic;
using System.Text;

namespace IntroProgramming_Curs15
{
    public interface ICar:IWheels, IPaint
    {
        int Age { get; set; }
        void Build();
    }
}
