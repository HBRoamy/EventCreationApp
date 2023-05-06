using System;
using System.Collections.Generic;
using System.Text;

namespace Book_reading_app.Core.Logger
{
    public interface ICustomLogger
    {
        public void LogToConsole(string info);
    }
}
