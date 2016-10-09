using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElasticsearchCRUD;
using ElasticsearchCRUD.Tracing;

namespace BulkInsertTestElasticsearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IElasticsearchMappingResolver elasticsearchMappingResolver = new ElasticsearchMappingResolver();
            // You only require a mapping if the default settings are not good enough
            elasticsearchMappingResolver.AddElasticSearchMappingForEntityType(typeof(AppRecord), new AppRecordMapping());

            using (var elasticSearchContext = new ElasticsearchContext("http://localhost:9200/", elasticsearchMappingResolver))
            {
                elasticSearchContext.TraceProvider = new TraceProvider("tracingExample");
                elasticSearchContext.AddUpdateDocument(TestData.AppRecord1, TestData.AppRecord1.Hash);
                elasticSearchContext.AddUpdateDocument(TestData.AppRecord2, TestData.AppRecord2.Hash);
                elasticSearchContext.AddUpdateDocument(TestData.AppRecord3, TestData.AppRecord3.Hash);

                var addEntitiesResult = elasticSearchContext.SaveChanges();

                Console.WriteLine(addEntitiesResult.PayloadResult);
                Console.WriteLine(addEntitiesResult.Status);
                Console.WriteLine(addEntitiesResult.Description);
            }
        }
    }
}
