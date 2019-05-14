using Demo.Domain.Documentos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Domain.Interfaces.Services
{
    public interface IDocumentoService
    {
        Task SeedAsync();
        Task Indexar(IEnumerable<DocumentBase> documents);
    }
}
