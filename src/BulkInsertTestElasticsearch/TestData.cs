using System;

namespace BulkInsertTestElasticsearch
{
    public static class TestData
    {

        public static AppRecord AppRecord1 = new AppRecord
        {
            Id = 1,
            AppId = Guid.NewGuid().ToString(),
            Hash = "hash1",
            Url = "https://damienbod.com",
            Title = "test1",
            ShortName = "test One"
        };

        public static AppRecord AppRecord2 = new AppRecord
        {
            Id = 2,
            AppId = Guid.NewGuid().ToString(),
            Hash = "hash2",
            Url = "https://damienbod.com",
            Title = "test2",
            ShortName = "test Two"
        };

        public static AppRecord AppRecord3 = new AppRecord
        {
            Id = 2,
            AppId = Guid.NewGuid().ToString(),
            Hash = "hash3",
            Url = "https://damienbod.com",
            Title = "test3",
            ShortName = "test Three"
        };
    }
}