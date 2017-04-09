using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class PedidoConsultaNFe
    {
        public PedidoConsultaNFeCabecalho Cabecalho { get; set; }

        [XmlElementAttribute("Detalhe")]
        public List<PedidoConsultaNFeDetalhe> Detalhe { get; set; }

        //[XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }

    public class PedidoConsultaNFeCabecalho
    {
        public PedidoConsultaNFeCabecalho()
        {
            this.Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }

    public class PedidoConsultaNFeDetalhe
    {
        /// <remarks/>
        [XmlElementAttribute("ChaveNFe", typeof(tpChaveNFe))]
        [XmlElementAttribute("ChaveRPS", typeof(tpChaveRPS))]
        public object Item { get; set; }
    }
}
