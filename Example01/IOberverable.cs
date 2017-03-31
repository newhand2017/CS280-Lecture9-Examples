using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public interface IOberverable
    {
        //-------------------------------------------------
        //
        //-------------------------------------------------
        void Register(IOberverable o);

        void RemoveObserver(IOberverable o);

        void Notify();

        //-------------------------------------------------
    }
}