using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElasticsearchCRUD;
using ElasticsearchCRUD.Model;

namespace BulkInsertTestElasticsearch
{
    public class AppRecordMapping : ElasticsearchMapping
    {
        /// <summary>
        /// Only required if you have some special mapping or want to remove some properties or use attributes..
        /// </summary>
        /// <param name="entity"></param>
        public override void MapEntityValues(EntityContextInfo entityInfo, ElasticsearchCrudJsonWriter elasticsearchCrudJsonWriter, bool beginMappingTree = false, bool createPropertyMappings = false)
        {
            AppRecord appRecord = entityInfo.Document as AppRecord;
            MapValue("Id", appRecord.Id, elasticsearchCrudJsonWriter.JsonWriter);
            MapValue("AppId", appRecord.AppId, elasticsearchCrudJsonWriter.JsonWriter);
            MapValue("Hash", appRecord.Hash, elasticsearchCrudJsonWriter.JsonWriter);
            MapValue("Url", appRecord.Url, elasticsearchCrudJsonWriter.JsonWriter);
            MapValue("Title", appRecord.Title, elasticsearchCrudJsonWriter.JsonWriter);
            MapValue("ShortName", appRecord.ShortName, elasticsearchCrudJsonWriter.JsonWriter);
        }

        public override string GetDocumentType(Type type)
        {
            return "apple_apps";
        }

        public override string GetIndexForType(Type type)
        {
            return "appdata_20161006";
        }
    }
}
