using System.Runtime.Serialization;

namespace FundScreenerWcfHost
{
    [DataContract]
    public class Stock
    {
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
