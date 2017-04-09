using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]    
    public class PedidoConsultaLote
    {
        public PedidoConsultaLoteCabecalho Cabecalho { get; set; }

        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }

    public class PedidoConsultaLoteCabecalho
    {
        public PedidoConsultaLoteCabecalho()
        {
            this.Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        public long NumeroLote { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }
}
