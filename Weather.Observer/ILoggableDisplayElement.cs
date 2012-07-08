using System;
using System.Linq;
using System.Text;

namespace Weather.Observer
{
    public interface ILoggableDisplayElement
    {
        void Display();
        string GetLogOutput();
    }
}
