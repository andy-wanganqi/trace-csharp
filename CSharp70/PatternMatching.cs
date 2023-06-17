using static System.Console;

namespace CSharp70
{
    public class PatternMatching
    {
        public static void Play()
        {
            int? maybe = 12;
            if (maybe is int number)
            {
                WriteLine($"The nullable int 'maybe' has the value {number}");
            }

            string? message = "This is not the null string";
            if (message is not null)
            {
                WriteLine(message);
            }
        }

        public static T MidPoint<T>(IEnumerable<T> sequence)
        {
            if (sequence is IList<T> list)
            {
                return list[list.Count / 2];
            }
            else if (sequence is T[] array)
            {
                return array[array.Length / 2];
            }
            else if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "Sequence can't be null.");
            }
            else
            {
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0) halfLength = 0;
                return sequence.Skip(halfLength).First();
            }
        }

        public State PerformOperation(string command) =>
           command switch
           {
               "SystemTest" => RunDiagnostics(),
               "Start" => StartSystem(),
               "Stop" => StopSystem(),
               "Reset" => ResetToReady(),
               _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
           };

        public State RunDiagnostics() => new State.RunDiagnostics();
        public State StartSystem() => new State.StartSystem();
        public State StopSystem() => new State.StopSystem();
        public State ResetToReady() => new State.ResetToReady();

        public string WaterState(int tempInFahrenheit) =>
            tempInFahrenheit switch
            {
                (> 32) and (< 212) => "liquid",
                < 32 => "solid",
                > 212 => "gas",
                32 => "solid/liquid transition",
                212 => "liquid / gas transition",
            };
        public string WaterState2(int tempInFahrenheit) =>
            tempInFahrenheit switch
            {
                < 32 => "solid",
                32 => "solid/liquid transition",
                < 212 => "liquid",
                212 => "liquid / gas transition",
                _ => "gas",
            };

        public decimal CalculateDiscount(Order order) =>
            order switch
            {
                { Items: > 10, Cost: > 1000.00m } => 0.10m, // AND logic
                { Items: > 5, Cost: > 500.00m } => 0.05m,
                { Cost: > 250.00m } => 0.02m,
                null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
                _ => 0m,
            };

        /* CS8652	The feature 'list pattern' is currently in Preview and *unsupported*. To use Preview features, use the 'preview' language version. */
        /* CSV example
        04-01-2020, DEPOSIT,    Initial deposit,            2250.00
        04-15-2020, DEPOSIT,    Refund,                      125.65
        04-18-2020, DEPOSIT,    Paycheck,                    825.65
        04-22-2020, WITHDRAWAL, Debit,           Groceries,  255.73
        05-01-2020, WITHDRAWAL, #1102,           Rent, apt, 2100.00
        05-02-2020, INTEREST,                                  0.65
        05-07-2020, WITHDRAWAL, Debit,           Movies,      12.57
        04-15-2020, FEE,                                       5.55
        */
        //string[][] ReadRecords()
        //{
        //    return new string[0][];
        //}
        //public void CalculateBalance()
        //{
        //    decimal balance = 0m;
        //    foreach (string[] transaction in ReadRecords())
        //    {
        //        balance += transaction switch
        //        {
        //            [_, "DEPOSIT", _, var amount] => decimal.Parse(amount),
        //            [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
        //            [_, "INTEREST", var amount] => decimal.Parse(amount),
        //            [_, "FEE", var fee] => -decimal.Parse(fee),
        //            _ => throw new InvalidOperationException($"Record {string.Join(", ", transaction)} is not in the expected format!"),
        //        };
        //        Console.WriteLine($"Record: {string.Join(", ", transaction)}, New balance: {balance:C}");
        //    }
        //}
    }

    public class State
    {
        public class RunDiagnostics : State { }
        public class StartSystem : State { }
        public class StopSystem : State { }
        public class ResetToReady : State { }
    }

    public record Order(int Items, decimal Cost);
}
