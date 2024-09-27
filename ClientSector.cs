using System;
using System.ComponentModel;
using System.IO;

namespace DevRisk
{
    public enum ClientSector {

        [DescriptionAttribute("Unkwnown")]
        Unknown = 0,

        [DescriptionAttribute("Private")]
        Private = 1,

        [DescriptionAttribute("Public")]
        Public = 2
    }
}