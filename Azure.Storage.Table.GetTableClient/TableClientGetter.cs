using Microsoft.Azure;
using static Azure.Storage.Connection.GetCloudStorageAccount.ConfigurationManagerGetter;

namespace Azure.Storage.Table.GetTableClient
{
    /// <summary>Function returns an instance of Microsoft Azure CloudTableClient using the given connection string</summary>
    public static class TableClientGetter
    {
        /// <summary>Returns an instance of Microsoft Azure CloudTableClient using the given connection string</summary>
        public static CloudTableClient TableClient(string connectionString) => ConfigurationManager(connectionString).CreateCloudTableClient();
    }
}
