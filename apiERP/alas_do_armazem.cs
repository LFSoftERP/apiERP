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
    
    public partial class alas_do_armazem
    {
        public alas_do_armazem()
        {
            this.alas_do_armazem_chip_rfid = new HashSet<alas_do_armazem_chip_rfid>();
            this.alas_do_armazem_lotes = new HashSet<alas_do_armazem_lotes>();
            this.alas_do_armazem_lotes1 = new HashSet<alas_do_armazem_lotes>();
            this.remocao_de_lotes = new HashSet<remocao_de_lotes>();
            this.remocao_de_lotes1 = new HashSet<remocao_de_lotes>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_ALA { get; set; }
        public int INT_ID_ARMAZEM { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public Nullable<int> INT_ID_RFID { get; set; }
        public Nullable<int> INT_X { get; set; }
        public Nullable<int> INT_Y { get; set; }
        public Nullable<int> INT_ID_TIPO_DE_PERMISSAO { get; set; }
        public string CHAR_LOCAL { get; set; }
    
        public virtual ICollection<alas_do_armazem_chip_rfid> alas_do_armazem_chip_rfid { get; set; }
        public virtual almoxarifado almoxarifado { get; set; }
        public virtual rfid_chip rfid_chip { get; set; }
        public virtual tipo_de_permissao_alas_do_armazem tipo_de_permissao_alas_do_armazem { get; set; }
        public virtual ICollection<alas_do_armazem_lotes> alas_do_armazem_lotes { get; set; }
        public virtual ICollection<alas_do_armazem_lotes> alas_do_armazem_lotes1 { get; set; }
        public virtual ICollection<remocao_de_lotes> remocao_de_lotes { get; set; }
        public virtual ICollection<remocao_de_lotes> remocao_de_lotes1 { get; set; }
    }
}