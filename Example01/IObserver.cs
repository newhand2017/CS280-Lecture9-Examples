using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public interface IObserver
    {
        //-------------------------------------------------
        //
        //-------------------------------------------------
        // sender : 通知者
        // EventArgs : .NET, 事件
        void UpdateView(object sender, EventArgs e);

        //-------------------------------------------------
    }
}