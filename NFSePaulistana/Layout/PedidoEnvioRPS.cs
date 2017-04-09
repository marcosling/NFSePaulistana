using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class PedidoEnvioRPS
    {        
        public PedidoEnvioRPSCabecalho Cabecalho { get; set; }

        public tpRPS RPS { get; set; }

        //[XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }
   
    public class PedidoEnvioRPSCabecalho
    {
        public PedidoEnvioRPSCabecalho()
        {
            this.Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }

}
