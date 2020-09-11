using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus.Management;
using PurpleExplorer.Models;

namespace PurpleExplorer.Helpers
{
    public interface IServiceBusHelper
    {
        public Task<NamespaceInfo> GetNamespaceInfo(string connectionString);
        public Task<IList<ServiceBusTopic>> GetTopics(string connectionString);
        public Task<IList<ServiceBusSubscription>> GetSubscriptions(string connectionString, string topicPath);

    }
}