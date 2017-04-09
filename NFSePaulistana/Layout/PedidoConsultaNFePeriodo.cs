using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class PedidoConsultaNFePeriodo
    {
        public PedidoConsultaNFePeriodoCabecalho Cabecalho { get; set; }

        //[XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }

    public class PedidoConsultaNFePeriodoCabecalho
    {
        public PedidoConsultaNFePeriodoCabecalho()
        {
            this.NumeroPagina = ((long)(1));
            this.Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        public tpCPFCNPJ CPFCNPJ { get; set; }

        public long Inscricao { get; set; }

        [XmlIgnoreAttribute()]
        public bool InscricaoSpecified { get; set; }

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime dtInicio { get; set; }

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime dtFim { get; set; }

        public long NumeroPagina { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }
}
