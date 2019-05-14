using Demo.Domain.Documentos;
using Demo.Domain.Interfaces.Solr;
using SolrNet;

namespace Demo.Infra.Data.Solr
{
    public class AcordaoData : SolrData<Acordao>, IAcordaoData
    {
        public AcordaoData(ISolrOperations<Acordao> solr) : base(solr)
        {
        }
    }

}
