// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage.Table;
using static Azure.Storage.Connection.GetCloudStorageAccount.CloudStorageAccountGetter;

namespace Azure.Storage.Table.GetTableClient
{
    /// <summary>Function returns an instance of Microsoft Azure CloudTableClient using the given connection string</summary>
    public static class TableClientGetter
    {
        /// <summary>Returns an instance of Microsoft Azure CloudTableClient using the given connection string</summary>
        public static CloudTableClient TableClient(string connectionString) => StorageAccount(connectionString).CreateCloudTableClient();
    }
}
