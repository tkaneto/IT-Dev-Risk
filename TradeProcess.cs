using System;
using System.IO;


namespace IT-DEV-Risk
{

    public internal class TradeProcess()
    {
        protected internal DateTime referenceDate;
        protected internal List<ITrade> tradesList;

        public internal GetInputTrades()
        {
            // Get the reference date
            referenceDate = GetTradesReferenceDate();

            // Get the list of trades
            tradesList = GetTrades();
        }

        protected internal DateTime GetTradesReferenceDate () {
            this.referenceDate = DateTime.Parse(Console.ReadLine());
            return referenceDate;
        }

        private static List<ITrade> GetTrades() {

            List<Itrade> list = new List<Trade>();

            int expectedNumberOfTrades = int.Parse(Console.ReadLine());

            for (int i; i < expectedNumberOfTrades; i++) {
                list.Add(GetTradeInput());
            }

            return list;
        }

        public static Trade GetTradeInput() {

            string entrada = Console.ReadLine();

            string[] parameters = entrada.Split(' ');

            decimal ammountValue = decimal.Parse(parameters[0]);

            string clientSector = parameters[1];

            // FORMAT REQUIREMENT (MM/dd/yyyy)
            DateTime nextPendingPaymentDate = DateTime.ParseExact(parameters[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);

            Trade itemResult = new Trade(ammountValue, clientSector, nextPendingPaymentDate);

            return itemResult;
        }

        public static List<ITrade> CheckTradeRules() {
            
            foreach (ITrade i in tradesList) {

                if (DateTime.Diff(i.NextPaymentDate, referenceDate.AddDays(30)) < 0) {
                    i.RiskStatus = RiskStatus.EXPIRED;
                }
                
                if (i.ammoutValue > 1,000,000.00) {

                    if (i.ClientSector.Equals(ClientSector.Private)) {
                        i.RiskStatus = RiskStatus.HIGHRISK;
                    }

                    if (i.ClientSector.Equals(ClientSector.Public)) {
                        i.RiskStatus = RiskStatus.MEDIUMRISK;
                    }
                }

                return i.RiskStatus = RiskStatus.UNKNOWN;
            }

            return ;
        }

        public static PrintTrades(List<ITrade> listTrades) {

            foreach (Itrade item in listTrades)
            {
                Console.WriteLine(item.TradeStatus);
            }
        }
    }
}
