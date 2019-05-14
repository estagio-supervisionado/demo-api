using Demo.Domain.Documentos;
using Demo.Domain.Interfaces.Solr;
using SolrNet;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Infra.Data.Solr
{
    public abstract class SolrData<Document> : ISolrData<Document> where Document : DocumentBase
    {
        protected readonly ISolrOperations<Document> _solr;

        protected SolrData(ISolrOperations<Document> solr)
        {
            _solr = solr;
        }

        public async Task AddOrUpdateAsync(IEnumerable<Document> documents)
        {
            await _solr.AddRangeAsync(documents);
        }

        public async Task<IEnumerable<Document>> QueryAsync(string query, CancellationToken cancellationToken = default)
        {
            return await _solr.QueryAsync(query, cancellationToken);
        }
    }

}
