using System;
using System.Globalization;
using System.IO;
using DevRisk;

namespace DevRisk
{
    public class ITDevRisk {

        
        /// <summary>
        /// IT-DEV-RISK Program
        /// </summary>
        public static void Main()
        {
            try
            {
                Console.WriteLine("IT-DEV-RISK started at {0:T}.", DateTime.Now);

                TradeProcess p = new TradeProcess();

                p.GetInputTrades();

                p.AssignRiskCategory();

                p.PrintTradesRiskCategory();

                Console.WriteLine("IT-DEV-RISK acomplished at {0:T}.", DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error found, program aborted.");
                Console.WriteLine("Technical Error Description: ", ex.Message);
            }

            return;
        }

    }
}