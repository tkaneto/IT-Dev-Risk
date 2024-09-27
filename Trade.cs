using DevRisk;

namespace DevRisk
{
    public class Trade : ITrade {

        public double Value { get; set; } // indicates the transaction amount in dollars

        public string ClientSector { get; set; } // indicates the client's sector which can be "Public" or "Private"

        public DateTime NextPaymentDate { get; set; } // indicates when the newxt payment from the client to the bank is expected

        public TradeStatus TradeStatus { get; set; } // Indicates HIGHRISK, MEDIUMRISK, EXPIRED and eventual others
        
        public Trade(double ammoutValue, string clientSector, DateTime nextPayment)
        {
            this.Value = ammoutValue; // TODO: Would be better if we could receive AN DECIMAL TYPE, need Architect Team approval
            this.ClientSector = clientSector; // TODO: Would be better if we could receive AN ENUM TYPE, need  Architect Team approval
            this.NextPaymentDate = nextPayment;
        }
    }
}
