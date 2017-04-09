using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class RetornoInformacoesLote
    {
        [XmlElement(Namespace = "")]
        public RetornoInformacoesLoteCabecalho Cabecalho { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Alerta { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Erro { get; set; }
    }

    public class RetornoInformacoesLoteCabecalho
    {
        public bool Sucesso { get; set; }

        public tpInformacoesLote InformacoesLote { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }
}
