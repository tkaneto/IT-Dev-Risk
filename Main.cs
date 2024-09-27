using System;
using System.IO;

namespace IT-DEV-Risk
{

    /// <summary>
    /// IT-DEV-RISK Program
    /// </summary>
    /// <returns>Returns 0 for success and -1 for any failure.</returns>
    public static int Main()
    {
        try
        {
            Console.WriteLine("IT-DEV-RISK started at {1:T}.", DateTime.Now);

            TradesProcess p = new TradesProcess();

            p.GetInputTrades();

            p.ProcessTradesRules();

            p.PrintTrades();

            Console.WriteLine("IT-DEV-RISK acomplished at {1:T}.", DateTime.Now());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unknown error found, program aborted.");
            return -1;
        }

        return 0;
    }
}