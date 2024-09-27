using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using DevRisk;

namespace DevRisk
{

    public class TradeProcess()
    {
        protected DateTime referenceDate;
        protected List<Trade> tradesList = new List<Trade>();

        public void GetInputTrades()
        {
            // Get the reference date
            referenceDate = GetReferenceDate();

            // Get the list of trades
            tradesList = GetTrades();
        }
        
        protected DateTime GetReferenceDate () {
            DateTime referenceDate = Convert.ToDateTime(Console.ReadLine());
            return referenceDate;
        }

        protected List<Trade> GetTrades() {

            int expectedNumberOfTrades = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < expectedNumberOfTrades; i++) {
                tradesList.Add(GetTradeInput());
            }

            return tradesList;
        }

        protected Trade GetTradeInput() {

            Trade itemResult;

            try {
                string? entry = Console.ReadLine();
                
                string[] parameters = entry.Split(' ');

                double ammountValue = Convert.ToDouble(parameters[0]);

                string clientSector = (string) parameters[1];

                // FORMAT REQUIREMENT (MM/dd/yyyy)
                DateTime nextPendingPaymentDate = DateTime.ParseExact(parameters[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);

                itemResult = new Trade(ammountValue, clientSector, nextPendingPaymentDate);

            }
            catch {
                throw new FormatException("Argumentos de Input são inválidos, favor verificar.");
            }

            return itemResult;
        }

        public void AssignRiskCategory() {
            
            foreach (ITrade i in tradesList) {

                if (DateTime.Compare(i.NextPaymentDate, referenceDate.AddDays(30)) < 0) {
                    i.TradeStatus = TradeStatus.EXPIRED;
                }
                
                if (i.Value > 1000000) {

                    if (i.ClientSector.Equals(ClientSector.Private.ToString())) {
                        i.TradeStatus = TradeStatus.HIGHRISK;
                    }

                    if (i.ClientSector.Equals(ClientSector.Public.ToString())) {
                        i.TradeStatus = TradeStatus.MEDIUMRISK;
                    }
                }

                i.TradeStatus = TradeStatus.UNKNOWN;
            }
        }

        public void PrintTradesRiskCategory() {

            foreach (ITrade item in tradesList)
            {
                Console.WriteLine(item.TradeStatus);
            }
        }
    }
}
