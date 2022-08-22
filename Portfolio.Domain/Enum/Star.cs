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
        [Description("★☆☆☆☆")] One = 1,
        [Description("★★☆☆☆")] Two = 2,
        [Description("★★★☆☆")] Three = 3,
        [Description("★★★★☆")] Four = 4,
        [Description("★★★★★")] Five = 5,
    }
}
