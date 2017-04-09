using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class PedidoEnvioLoteRPS
    {
        public PedidoEnvioLoteRPSCabecalho Cabecalho { get; set; }

        [XmlElementAttribute("RPS")]
        public List<tpRPS> RPS { get; set; }

        //[XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }

    public class PedidoEnvioLoteRPSCabecalho
    {
        public PedidoEnvioLoteRPSCabecalho()
        {
            this.transacao = true;
            this.Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool transacao { get; set; }

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime dtInicio { get; set; }

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime dtFim { get; set; }

        public long QtdRPS { get; set; }

        public decimal ValorTotalServicos { get; set; }

        public decimal ValorTotalDeducoes { get; set; }

        [XmlIgnoreAttribute()]
        public bool ValorTotalDeducoesSpecified { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }
}
