using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConfLib.Models.Enums
{
    public enum ValueEnum : byte
    {
        [Description("Bool")]
        Bool = 0,

        [Description("Byte")]
        Byte = 1,

        [Description("String")]
        String = 2,

        [Description("Decimal")]
        Decimal = 3,

        [Description("Double")]
        Double = 4,

        [Description("Float")]
        Float = 5,

        [Description("Integer")]
        Int = 6,

        [Description("Long")]
        Long = 7

    }
}
