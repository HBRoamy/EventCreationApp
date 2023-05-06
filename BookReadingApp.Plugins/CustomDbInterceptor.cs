using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Data.Common;

namespace BookReadingApp.Plugins
{
    public class CustomDbInterceptor : DbCommandInterceptor
    {
        public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command,
        CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
        {
            Console.WriteLine(command.CommandText);
            return result;
        }
    }
}
