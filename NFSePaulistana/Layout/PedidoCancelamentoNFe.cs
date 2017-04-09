using System.Collections.Generic;
using System.Xml.Serialization;

namespace NFSePaulistana.Layout
{
    [XmlRootAttribute(Namespace = "http://www.prefeitura.sp.gov.br/nfe")]
    public class PedidoCancelamentoNFe
    {
        public PedidoCancelamentoNFeCabecalho Cabecalho { get; set; }

        public List<PedidoCancelamentoNFeDetalhe> Detalhe { get; set; }
        
        //[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        //public Signature.Signature Signature { get; set; }
    }

    public class PedidoCancelamentoNFeCabecalho
    {
        public PedidoCancelamentoNFeCabecalho()
        {
            transacao = true;
            Versao = ((long)(1));
        }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        public bool transacao { get; set; }

        [XmlAttribute]
        public long Versao { get; set; }
    }

    public class PedidoCancelamentoNFeDetalhe
    {
        public tpChaveNFe ChaveNFe { get; set; }

        public string AssinaturaCancelamento { get; set; }
    }
}
