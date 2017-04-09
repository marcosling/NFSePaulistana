using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class RetornoEnvioRPS
    {
        [XmlElement(Namespace = "")]
        public RetornoEnvioRPSCabecalho Cabecalho { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Alerta { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Erro { get; set; }

        [XmlElement(Namespace = "")]
        public tpChaveNFeRPS ChaveNFeRPS { get; set; }
    }

    public class RetornoEnvioRPSCabecalho
    {
        public bool Sucesso { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }

}
