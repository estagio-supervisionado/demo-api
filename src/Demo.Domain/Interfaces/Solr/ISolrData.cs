using Demo.Domain.Documentos;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Domain.Interfaces.Solr
{
    public interface ISolrData<Document> where Document: DocumentBase
    {
        Task AddOrUpdateAsync(IEnumerable<Document> documents);

        Task<IEnumerable<Document>> QueryAsync(string query, CancellationToken cancellationToken = default);
    }
}
