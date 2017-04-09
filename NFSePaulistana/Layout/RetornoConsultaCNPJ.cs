using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class RetornoConsultaCNPJ
    {
        [XmlElement(Namespace = "")]
        public RetornoConsultaCNPJCabecalho Cabecalho { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Alerta { get; set; }

        [XmlElement(Namespace = "")]
        public List<tpEvento> Erro { get; set; }

        [XmlElement(Namespace = "")]
        public List<RetornoConsultaCNPJDetalhe> Detalhe { get; set; }
    }

    public class RetornoConsultaCNPJCabecalho
    {
        public bool Sucesso { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }

    public class RetornoConsultaCNPJDetalhe
    {
        public long InscricaoMunicipal { get; set; }

        public bool EmiteNFe { get; set; }
    }
}
