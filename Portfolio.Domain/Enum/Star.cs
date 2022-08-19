using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Enum
{
    public enum Star
    {
        //U+2605 = ★
        //U+2606 = ☆
        [Description("★☆☆☆☆")] One,
        [Description("★★☆☆☆")] Two,
        [Description("★★★☆☆")] Three,
        [Description("★★★★☆")] Four,
        [Description("★★★★★")] Five,
    }
}
