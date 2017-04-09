using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class RetornoConsulta
    {
        [XmlElement(Namespace = "")]
        public RetornoConsultaCabecalho Cabecalho { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Alerta { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Erro { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpNFe> NFe { get; set; }
    }

    public class RetornoConsultaCabecalho
    {
        public bool Sucesso { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }
}
