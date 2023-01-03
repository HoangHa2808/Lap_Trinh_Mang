using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Bai2
{
    public interface ILogger
    {
        void Write(ArrayList entry);
        void Write(String entry);
    }
}
