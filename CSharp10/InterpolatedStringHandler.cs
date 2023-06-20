using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    /*
     * To explore further, look at the System.Runtime.CompilerServices.DefaultInterpolatedStringHandler. 
     * It provides a more complete implementation than you built here. 
     * You'll see many more overloads that are possible for the Append methods.
     * https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.defaultinterpolatedstringhandler?view=net-7.0
    */

    public class InterpolatedStringHandler
    {
        public static void Play()
        {
            var logger = new Logger() { EnabledLevel = LogLevel.Warning };
            var time = DateTime.Now;

            logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time}. The time doesn't use formatting.");
            logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time:t}. This is an error. It will be printed.");
            logger.LogMessage(LogLevel.Trace, $"Trace Level. CurrentTime: {time:t}. This won't be printed.");
            logger.LogMessage(LogLevel.Warning, "Warning Level. This warning is a string, not an interpolated string expression.");


            int index = 0;
            int numberOfIncrements = 0;
            for (var level = LogLevel.Critical; level <= LogLevel.Trace; level++)
            {
                Console.WriteLine(level);
                logger.LogMessage(level, $"{level}: Increment index a few times {index++}, {index++}, {index++}, {index++}, {index++}");
                numberOfIncrements += 5;
            }
            Console.WriteLine($"Value of index {index}, value of numberOfIncrements: {numberOfIncrements}");
        }
    }

    public enum LogLevel
    {
        Off,
        Critical,
        Error,
        Warning,
        Information,
        Trace
    }

    public class Logger
    {
        public LogLevel EnabledLevel { get; init; } = LogLevel.Error;

        public void LogMessage(LogLevel level, string msg)
        {
            if (EnabledLevel < level) return;
            Console.WriteLine(msg);
        }

        public void LogMessage(LogLevel level, [InterpolatedStringHandlerArgument("", "level")] LogInterpolatedStringHandler builder)
        {
            if (EnabledLevel < level) return;
            Console.WriteLine(builder.GetFormattedText());
        }
    }

    [InterpolatedStringHandler]
    public ref struct LogInterpolatedStringHandler
    {
        // Storage for the built-up string
        StringBuilder builder;

        public LogInterpolatedStringHandler(int literalLength, int formattedCount)
        {
            builder = new StringBuilder(literalLength);
            Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
        }

        private readonly bool enabled;

        public LogInterpolatedStringHandler(int literalLength, int formattedCount, Logger logger, LogLevel logLevel)
        {
            enabled = logger.EnabledLevel >= logLevel;
            builder = new StringBuilder(literalLength);
            Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
        }

        public LogInterpolatedStringHandler(int literalLength, int formattedCount, Logger logger, LogLevel level, out bool isEnabled)
        {
            isEnabled = logger.EnabledLevel >= level;
            Console.WriteLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
            builder = isEnabled ? new StringBuilder(literalLength) : default!;
        }

        public void AppendLiteral(string s)
        {
            Console.WriteLine($"\tAppendLiteral called: {{{s}}}");
            if (!enabled) return;

            builder.Append(s);
            Console.WriteLine($"\tAppended the literal string");
        }

        public void AppendFormatted<T>(T t) where T : IFormattable
        {
            Console.WriteLine($"\tAppendFormatted called: {{{t}}} is of type {typeof(T)}");
            if (!enabled) return;

            builder.Append(t?.ToString());
            Console.WriteLine($"\tAppended the formatted object");
        }

        public void AppendFormatted<T>(T t, string format) where T : IFormattable
        {
            Console.WriteLine($"\tAppendFormatted (IFormattable version) called: {t} with format {{{format}}} is of type {typeof(T)},");
            if (!enabled) return;

            builder.Append(t?.ToString(format, null));
            Console.WriteLine($"\tAppended the formatted object");
        }

        internal string GetFormattedText() => builder.ToString();
    }
}
