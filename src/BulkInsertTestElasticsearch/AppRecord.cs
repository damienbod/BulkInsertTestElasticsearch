using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkInsertTestElasticsearch
{
    public class AppRecord
    {
        public AppRecord() { }

        //public AppRecord(AppLinkMetadata metadata)
        //{
        //    AppId = metadata.Id;
        //    Hash = metadata.Hash;
        //    Url = metadata.Url;
        //    Title = metadata.Title;
        //    ShortName = metadata.DeveloperShortName;
        //}

        public long Id { get; set; }
        public string AppId { get; set; }
        public string Hash { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string ShortName { get; set; }
    }
}
