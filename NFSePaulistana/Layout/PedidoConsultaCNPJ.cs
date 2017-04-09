using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    public class PedidoConsultaCNPJ
    {
        public PedidoConsultaCNPJCabecalho Cabecalho { get; set; }

        public tpCPFCNPJ CNPJContribuinte { get; set; }

        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }

    public class PedidoConsultaCNPJCabecalho
    {
        public PedidoConsultaCNPJCabecalho()
        {
            this.Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }
}
