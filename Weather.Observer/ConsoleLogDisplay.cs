using System;

namespace Weather.Observer
{
    public abstract class ConsoleLogDisplay : ILoggableDisplayElement
    {
        public void Display()
        {
            Console.WriteLine(GetLogOutput());
        }

        public abstract string GetLogOutput();
    }
}