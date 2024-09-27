using System;
using System.IO;
using DevRisk;

namespace DevRisk
{
    interface ITrade {
        public double Value { get; } // indicates the transaction amount in dollars

        public string ClientSector { get; } // indicates the client's sector which can be "Public" or "Private"

        public DateTime NextPaymentDate { get; } // indicates when the next payment from the client to the bank is expected

        public TradeStatus TradeStatus { get; set; } // indicates the status based on specific rules
    }
}