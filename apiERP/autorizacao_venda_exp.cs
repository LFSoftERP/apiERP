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
    
    public partial class autorizacao_venda_exp
    {
        public autorizacao_venda_exp()
        {
            this.motorista_autorizacao = new HashSet<motorista_autorizacao>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_AUTORIZACAO_GENERICA { get; set; }
        public string CHAR_FLAG_EXP_VENDA_INT { get; set; }
        public string TXT_TRANSPORTADORA { get; set; }
        public string TXT_CONTAINER { get; set; }
        public string TXT_LACRE { get; set; }
        public Nullable<int> INT_TARA { get; set; }
        public string TXT_OIC { get; set; }
        public string TXT_TIPO_SACARIA { get; set; }
    
        public virtual autorizacao_generica autorizacao_generica { get; set; }
        public virtual ICollection<motorista_autorizacao> motorista_autorizacao { get; set; }
    }
}
