using System;
using Linearstar.Windows.RawInput;

namespace ConsoleAppFramework1
{
    class RawInputEventArgs : EventArgs
    {
        public RawInputEventArgs(RawInputData data)
        {
            Data = data;
        }

        public RawInputData Data { get; }
    }
}
