using System;

namespace Demo.Domain.Documentos
{
    public class Acordao: DocumentBase
    {
        
        public int IDDocumento { get; set; }
        public int IDProcesso { get; set; }
        public int IDArquivo { get; set; }
        public int IDProcessoAtenas { get; set; }
        public string NumeroClasse { get; set; }
        public string AnoClasse { get; set; }
        public int ClasseProcessoID { get; set; }
        public string ClasseProcessoDescricao { get; set; }
        public int SubclasseProcessoID { get; set; }
        public int RelatorMatricula { get; set; }
        public string NumeroUnico { get; set; }
        public string Assunto { get; set; }
        public string DescricaoLotacao { get; set; }
        public string Comarca { get; set; }
        public int IDLotacao { get; set; }
        public int CodigoComarca { get; set; }
        public string Instancia { get; set; }
        public string DescricaoLotacaoProcesso { get; set; }
        public int IDLotacaoProcesso { get; set; }
        public string DocumentoTexto { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
        public DateTime DataAdicao { get; set; }
    }

}
