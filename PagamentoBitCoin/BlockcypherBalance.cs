using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoBitCoin
{
    internal class BlockcypherBalance
    {

        [JsonProperty("final_balance")]
        public long final_balance { get; set; } // Saldo final em satoshis

    }
}
