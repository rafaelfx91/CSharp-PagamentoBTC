using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoBitCoin
{
    internal class CotacaoBitcoin
    {
        [JsonProperty("bitcoin")]
        public BitcoinData Bitcoin { get; set; }
    }
}
