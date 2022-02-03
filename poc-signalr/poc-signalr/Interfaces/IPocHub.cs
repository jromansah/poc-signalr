using System;
using System.Threading.Tasks;

namespace poc_signalr.Interfaces
{
    public interface IPocHub
    {
        Task NotifyConnection(string message);
        Task Counter(int number);
    }
}
