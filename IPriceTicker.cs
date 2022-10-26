using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FundScreenerWcfHost
{

    [ServiceContract(SessionMode= SessionMode.Required, CallbackContract = typeof(IPriceChangeCallBack))]
    public interface IPriceTicker
    {
        [OperationContract(IsOneWay = true)]
        void Subscribe();

        [OperationContract(IsOneWay = true)]
        void Unsubscribe();

        [OperationContract]
        IList<Stock> GetAllStocks();

        [OperationContract(IsOneWay = true)]
        void PublishPriceChange(string item, string name, decimal price);
    }


}
