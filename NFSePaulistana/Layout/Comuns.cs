using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace NFSePaulistana.Layout
{
    public class tpChaveNFe
    {
        public long InscricaoPrestador { get; set; }

        public long NumeroNFe { get; set; }

        public string CodigoVerificacao { get; set; }
    }

    public class tpChaveNFeRPS
    {
        public tpChaveNFe ChaveNFe { get; set; }

        public tpChaveRPS ChaveRPS { get; set; }
    }

    public class tpChaveRPS
    {
        public long InscricaoPrestador { get; set; }

        public string SerieRPS { get; set; }

        public long NumeroRPS { get; set; }
    }

    public class tpCPFCNPJ
    {
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]        
        public string Item { get; set; }       

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName { get; set; }
    }

    public class tpEndereco
    {
        public string TipoLogradouro { get; set; }

        public string Logradouro { get; set; }

        public string NumeroEndereco { get; set; }

        public string ComplementoEndereco { get; set; }

        public string Bairro { get; set; }

        public int Cidade { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CidadeSpecified { get; set; }

        public string UF { get; set; }

        public int CEP { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CEPSpecified { get; set; }
    }

    public class tpEvento
    {
        public short Codigo { get; set; }

        public string Descricao { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ChaveNFe", typeof(tpChaveNFe))]
        [System.Xml.Serialization.XmlElementAttribute("ChaveRPS", typeof(tpChaveRPS))]
        public object Item { get; set; }
    }

    public class tpInformacoesLote
    {
        public long NumeroLote { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroLoteSpecified { get; set; }

        public long InscricaoPrestador { get; set; }

        public tpCPFCNPJ CPFCNPJRemetente { get; set; }

        public System.DateTime DataEnvioLote { get; set; }

        public long QtdNotasProcessadas { get; set; }

        public long TempoProcessamento { get; set; }

        public decimal ValorTotalServicos { get; set; }

        public decimal ValorTotalDeducoes { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorTotalDeducoesSpecified { get; set; }
    }

    public enum tpOpcaoSimples
    {
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    public class tpNFe
    {
        public byte[] Assinatura { get; set; }

        public tpChaveNFe ChaveNFe { get; set; }

        //[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DataEmissaoNFe { get; set; }

        public long NumeroLote { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroLoteSpecified { get; set; }

        public tpChaveRPS ChaveRPS { get; set; }

        public tpTipoRPS TipoRPS { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoRPSSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DataEmissaoRPS { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataEmissaoRPSSpecified { get; set; }

        public tpCPFCNPJ CPFCNPJPrestador { get; set; }

        public string RazaoSocialPrestador { get; set; }

        public tpEndereco EnderecoPrestador { get; set; }

        public string EmailPrestador { get; set; }

        public tpStatusNFe StatusNFe { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DataCancelamento { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataCancelamentoSpecified { get; set; }

        public string TributacaoNFe { get; set; }

        public tpOpcaoSimples OpcaoSimples { get; set; }

        public long NumeroGuia { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroGuiaSpecified { get; set; }

        public System.DateTime DataQuitacaoGuia { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataQuitacaoGuiaSpecified { get; set; }

        public decimal ValorServicos { get; set; }

        public decimal ValorDeducoes { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorDeducoesSpecified { get; set; }

        public decimal ValorPIS { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorPISSpecified { get; set; }

        public decimal ValorCOFINS { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCOFINSSpecified { get; set; }

        public decimal ValorINSS { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorINSSSpecified { get; set; }

        public decimal ValorIR { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorIRSpecified { get; set; }

        public decimal ValorCSLL { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCSLLSpecified { get; set; }

        public int CodigoServico { get; set; }

        public decimal AliquotaServicos { get; set; }

        public decimal ValorISS { get; set; }

        public decimal ValorCredito { get; set; }

        public bool ISSRetido { get; set; }

        public tpCPFCNPJ CPFCNPJTomador { get; set; }

        public long InscricaoMunicipalTomador { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoMunicipalTomadorSpecified { get; set; }

        public long InscricaoEstadualTomador { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoEstadualTomadorSpecified { get; set; }

        public string RazaoSocialTomador { get; set; }

        public tpEndereco EnderecoTomador { get; set; }

        public string EmailTomador { get; set; }

        public tpCPFCNPJ CPFCNPJIntermediario { get; set; }

        public long InscricaoMunicipalIntermediario { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoMunicipalIntermediarioSpecified { get; set; }

        public string ISSRetidoIntermediario { get; set; }

        public string EmailIntermediario { get; set; }

        public string Discriminacao { get; set; }

        public decimal ValorCargaTributaria { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCargaTributariaSpecified { get; set; }

        public decimal PercentualCargaTributaria { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentualCargaTributariaSpecified { get; set; }

        public string FonteCargaTributaria { get; set; }

        public long CodigoCEI { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodigoCEISpecified { get; set; }

        public long MatriculaObra { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatriculaObraSpecified { get; set; }

        public int MunicipioPrestacao { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MunicipioPrestacaoSpecified { get; set; }

        public long NumeroEncapsulamento { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroEncapsulamentoSpecified { get; set; }
    }

    public enum ItemChoiceType
    {
        [System.Xml.Serialization.XmlEnumAttribute("CPF")]
        CPF = 1,

        [System.Xml.Serialization.XmlEnumAttribute("CNPJ")]
        CNPJ = 2
    }

    public enum tpTipoRPS
    {
        RPS,

        [System.Xml.Serialization.XmlEnumAttribute("RPS-M")]
        RPSM,

        [System.Xml.Serialization.XmlEnumAttribute("RPS-C")]
        RPSC,
    }

    public enum tpStatusNFe
    {
        N,
        C,
        E,
    }

  
    public class tpRPS
    {
        public string Assinatura { get; set; }

        public tpChaveRPS ChaveRPS { get; set; }

        public tpTipoRPS TipoRPS { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DataEmissao { get; set; }

        public tpStatusNFe StatusRPS { get; set; }

        public string TributacaoRPS { get; set; }

        public decimal ValorServicos { get; set; }

        public decimal ValorDeducoes { get; set; }

        public decimal ValorPIS { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorPISSpecified { get; set; }

        public decimal ValorCOFINS { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCOFINSSpecified { get; set; }

        public decimal ValorINSS { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorINSSSpecified { get; set; }

        public decimal ValorIR { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorIRSpecified { get; set; }

        public decimal ValorCSLL { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCSLLSpecified { get; set; }

        public int CodigoServico { get; set; }

        public decimal AliquotaServicos { get; set; }

        public bool ISSRetido { get; set; }

        public tpCPFCNPJ CPFCNPJTomador { get; set; }

        public long InscricaoMunicipalTomador { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoMunicipalTomadorSpecified { get; set; }

        public long InscricaoEstadualTomador { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoEstadualTomadorSpecified { get; set; }

        public string RazaoSocialTomador { get; set; }

        public tpEndereco EnderecoTomador { get; set; }

        public string EmailTomador { get; set; }

        public tpCPFCNPJ CPFCNPJIntermediario { get; set; }

        public long InscricaoMunicipalIntermediario { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InscricaoMunicipalIntermediarioSpecified { get; set; }

        public bool ISSRetidoIntermediario { get; set; }

        public string EmailIntermediario { get; set; }

        public string Discriminacao { get; set; }

        public decimal ValorCargaTributaria { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorCargaTributariaSpecified { get; set; }

        public decimal PercentualCargaTributaria { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentualCargaTributariaSpecified { get; set; }

        public string FonteCargaTributaria { get; set; }

        public long CodigoCEI { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodigoCEISpecified { get; set; }

        public long MatriculaObra { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MatriculaObraSpecified { get; set; }

        public int MunicipioPrestacao { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MunicipioPrestacaoSpecified { get; set; }

        public long NumeroEncapsulamento { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumeroEncapsulamentoSpecified { get; set; }

        public void AssinarRPS(X509Certificate2 p_certificado_digital)
        {
            try
            {
                StringBuilder v_assinatura = new StringBuilder();

                v_assinatura.Append(ChaveRPS.InscricaoPrestador.ToString("00000000"));
                v_assinatura.Append(AjustaTexto(ChaveRPS.SerieRPS, 5));
                v_assinatura.Append(ChaveRPS.NumeroRPS.ToString("000000000000"));
                v_assinatura.Append(DataEmissao.ToString("yyyyMMdd"));
                v_assinatura.Append(AjustaTexto(TributacaoRPS, 1));
                v_assinatura.Append(AjustaTexto(StatusRPS.ToString(), 1));
                v_assinatura.Append((ISSRetido ? "S" : "N"));
                v_assinatura.Append((ValorServicos * 100).ToString("000000000000000"));
                v_assinatura.Append((ValorDeducoes * 100).ToString("000000000000000"));
                v_assinatura.Append(CodigoServico.ToString("00000"));

                if (CPFCNPJTomador != null)
                {                    
                    v_assinatura.Append((int)CPFCNPJTomador.ItemElementName);
                    v_assinatura.Append(Convert.ToInt64(CPFCNPJTomador.Item).ToString("00000000000000"));
                }
                else
                {
                    v_assinatura.Append("3");
                    v_assinatura.Append("00000000000000");
                }

                //86 tamanho da string

                if (CPFCNPJIntermediario != null)
                {                    
                    v_assinatura.Append((int)CPFCNPJIntermediario.ItemElementName);
                    v_assinatura.Append(Convert.ToInt64(CPFCNPJIntermediario.Item).ToString("00000000000000"));
                    

                    //102 tamanho da string
                }

                v_assinatura.Append("N");

                Assinatura = SignWithRSASHA1(p_certificado_digital, v_assinatura.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal string AjustaTexto(string p_text, Int16 p_size)
        {
            string p_text_temp;

            p_text_temp = p_text + new string(Convert.ToChar(" "), p_size);

            p_text_temp = p_text_temp.Substring(0, p_size);

            return p_text_temp;
        }

        internal string SignWithRSASHA1(X509Certificate2 cert, String value)
        {            
            // Converta a cadeia de caracteres ASCII para bytes. 
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            byte[] asciiBytes = asciiEncoding.GetBytes(value);

            // Gere o HASH (array de bytes) utilizando SHA1
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] sha1Hash = sha1.ComputeHash(asciiBytes);

            //- Assine o HASH (array de bytes) utilizando RSA-SHA1.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa = cert.PrivateKey as RSACryptoServiceProvider;
            asciiBytes = rsa.SignHash(sha1Hash, "SHA1");
            string result = Convert.ToBase64String(asciiBytes);
            return result;
        }
    }
}
