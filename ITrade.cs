using System;
using System.IO;

namespace IT-DEV-Risk
{
    interface ITrade{
        double Value { get; } // indicates the transaction amount in dollars

        string ClientSector { get; } // indicates the client's sector which can be "Public" or "Private"

        DateTime NextPaymentDate { get; } // indicates when the next payment from the client to the bank is expected

        TradeStatus TradeStatus { get; set; } // indicates the status based on specific rules
    }
}