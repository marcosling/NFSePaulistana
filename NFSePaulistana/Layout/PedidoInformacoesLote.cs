using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class PedidoInformacoesLote
    {
        public PedidoInformacoesLoteCabecalho Cabecalho { get; set; }

        //[XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }

    public class PedidoInformacoesLoteCabecalho
    {
        public PedidoInformacoesLoteCabecalho()
        {
            this.Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        public long NumeroLote { get; set; }
        
        [XmlIgnoreAttribute()]
        public bool NumeroLoteSpecified { get; set; }

        public long InscricaoPrestador { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }
}
