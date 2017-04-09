using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class RetornoCancelamentoNFe
    {
        [XmlElement(Namespace = "")]
        public RetornoCancelamentoNFeCabecalho Cabecalho { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Alerta { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Erro { get; set; }
    }

    public class RetornoCancelamentoNFeCabecalho
    {
        public bool Sucesso { get; set; }

        public long Versao { get; set; }
    }
}
