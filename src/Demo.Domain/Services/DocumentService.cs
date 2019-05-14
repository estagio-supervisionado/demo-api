using Demo.Domain.Documentos;
using Demo.Domain.Interfaces.Services;
using Demo.Domain.Interfaces.Solr;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Services
{
    public class DocumentService : IDocumentoService
    {
        private IAcordaoData _acordaoData;

        public DocumentService(IAcordaoData acordaoData)
        {
            _acordaoData = acordaoData;
        }


        public async Task Indexar(IEnumerable<DocumentBase> documents)
        {
            var acordaos = documents.Select(x => x as Acordao);
            await  _acordaoData.AddOrUpdateAsync(acordaos);
        }

        public async Task SeedAsync()
        {
            var data = GetData();
            await Indexar(data);
        }


        public IEnumerable<Acordao> GetData()
        {
            using (var reader = new StreamReader("data.json", Encoding.Default))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<IEnumerable<Acordao>>(json);
            }
        }
    }
}
