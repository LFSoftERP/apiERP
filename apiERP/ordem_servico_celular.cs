//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiERP
{
    using System;
    using System.Collections.Generic;
    
    public partial class ordem_servico_celular
    {
        public ordem_servico_celular()
        {
            this.contas_a_pagar_e_receber = new HashSet<contas_a_pagar_e_receber>();
        }
    
        public int INT_ID { get; set; }
        public Nullable<int> INT_ID_CLIENTE { get; set; }
        public string TXT_MODELO { get; set; }
        public string TXT_MARCA { get; set; }
        public string TXT_IMEI { get; set; }
        public string TXT_DEFEITO_RECLAMADO { get; set; }
        public string TXT_DEFEITO_CONSTATADO { get; set; }
        public string TXT_SENHA { get; set; }
        public string TXT_DETALHES_OBS { get; set; }
        public System.DateTime DATE_ENTRADA { get; set; }
        public Nullable<System.DateTime> DATE_RETIRADA { get; set; }
        public string TXT_GARANTIA { get; set; }
        public Nullable<System.DateTime> DATE_FINALIZADO { get; set; }
        public int INT_ID_CADASTRO { get; set; }
        public System.DateTime DATE_CADASTRO { get; set; }
        public Nullable<int> INT_ID_ALTERA { get; set; }
        public Nullable<System.DateTime> DATE_ALTERA { get; set; }
        public Nullable<int> INT_ID_EXLCLUI { get; set; }
        public Nullable<System.DateTime> DATE_EXCLUI { get; set; }
        public Nullable<int> INT_ID_FINALIZOU { get; set; }
        public Nullable<int> INT_ID_AVISOU { get; set; }
        public Nullable<int> INT_ID_ENTREGOU { get; set; }
        public Nullable<System.DateTime> DATE_AVISOU { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public string TXT_NUM_ORDEM { get; set; }
        public string TXT_ACESSORIOS { get; set; }
        public Nullable<decimal> DECIMAL_VALOR { get; set; }
        public string TXT_NOME_CLIENTE { get; set; }
        public string TXT_CPF_CNPJ { get; set; }
        public string TXT_RUA { get; set; }
        public string TXT_APELIDO { get; set; }
        public string TXT_OBS { get; set; }
        public bool BOOL_PF_PJ { get; set; }
        public string TXT_BAIRRO { get; set; }
        public string TXT_NR { get; set; }
        public string TXT_TELEFONE { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual ICollection<contas_a_pagar_e_receber> contas_a_pagar_e_receber { get; set; }
    }
}
