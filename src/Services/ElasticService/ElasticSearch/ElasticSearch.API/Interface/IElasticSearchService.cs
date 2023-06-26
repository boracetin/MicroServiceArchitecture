using ElasticSearch.API.Entity;

namespace ElasticSearch.API.Interface
{
    public interface IElasticSearchService
    {
        Task ChekIndex(string indexName);
        Task InsertDocument(string indexName, Cities cities);
        Task DeleteIndex(string indexName);
        Task DeleteByIdDocument(string indexName, Cities cities);
        Task InsertBulkDocuments(string indexName, List<Cities> cities);
        Task<Cities> GetDocument(string indexName, string id);
        Task<List<Cities>> GetDocuments(string indexName);
    }
}
