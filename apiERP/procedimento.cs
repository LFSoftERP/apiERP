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
    
    public partial class procedimento
    {
        public procedimento()
        {
            this.contas_a_pagar_e_receber = new HashSet<contas_a_pagar_e_receber>();
            this.movimentos_produtos_contabeis = new HashSet<movimentos_produtos_contabeis>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_CONVENIO { get; set; }
        public System.DateTime DATE_PROCEDIMENTO { get; set; }
        public string TXT_OBS { get; set; }
        public Nullable<int> INT_ID_PACIENTE { get; set; }
        public string TXT_NOME_PACIENTE { get; set; }
        public decimal DECIMAL_VLR_SUS { get; set; }
        public decimal DECIMAL_VALOR { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public System.DateTime DATE_ENTRADA { get; set; }
        public System.DateTime DATE_SAIDA { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public int INT_ID_FUNCIONARIO { get; set; }
        public Nullable<int> INT_ID_MEDICO { get; set; }
        public int INT_ID_TIPO_PROCEDIMENTO { get; set; }
        public decimal DECIMAL_QTD { get; set; }
        public string TXT_NR_GUIA_REFERENCIADA { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual cliente cliente1 { get; set; }
        public virtual ICollection<contas_a_pagar_e_receber> contas_a_pagar_e_receber { get; set; }
        public virtual convenio_plano_de_saude convenio_plano_de_saude { get; set; }
        public virtual funcionario funcionario { get; set; }
        public virtual ICollection<movimentos_produtos_contabeis> movimentos_produtos_contabeis { get; set; }
        public virtual procedimento_tipo procedimento_tipo { get; set; }
    }
}
