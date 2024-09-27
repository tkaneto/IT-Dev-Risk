using System;
using System.IO;
using DevRisk;

namespace DevRisk
{
    public enum TradeStatus {
        UNKNOWN = 0,
        EXPIRED = 1,
        MEDIUMRISK = 2,
        HIGHRISK = 3
    }
}