using System.ServiceModel;

namespace FundScreenerWcfHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface IPriceChangeCallBack
    {
        [OperationContract(IsOneWay = true)]
        void PriceChange(string code, string name, decimal price);
    }


}
