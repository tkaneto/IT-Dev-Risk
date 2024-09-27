using system;

namespace IT-DEV-Risk
{
    public class Trade : ITrade {

        double Value { get; set; } // indicates the transaction amount in dollars
        ClientSector ClientSector { get; set; } // indicates the client's sector which can be "Public" or "Private"
        DateTime NextPaymentDate { get; set; } // indicates when the newxt payment from the client to the bank is expected
        enum RiskStatus { get; set; } // Indicates HIGHRISK, MEDIUMRISK, EXPIRED and eventual others

        public Trade(double ammoutValue, string clientSector, DateTime nextPayment)
        {
            this.Value = ammoutValue;
            this.ClientSector = clientSector.Enum(clientSector);
            this.NextPaymentDate = nextPayment;
        }
    }
}
