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
    
    public partial class carteira
    {
        public carteira()
        {
            this.hedge = new HashSet<hedge>();
            this.rolagem = new HashSet<rolagem>();
        }
    
        public int INT_ID { get; set; }
        public int INT_ID_GRUPO_DA_CARTEIRA { get; set; }
        public string TXT_DESCRICAO { get; set; }
        public bool BOOL_INSTRUMENTO_OU_OBJ_DE_HEDGE { get; set; }
        public float FLOAT_NIVEL { get; set; }
        public float FLOAT_QTD_INICIAL { get; set; }
        public float FLOAT_VALOR_INICIAL { get; set; }
        public float FLOAT_SALDO_ATUAL_EM_VALOR { get; set; }
        public float FLOAT_SALDO_ATUAL_EM_QTD { get; set; }
        public string TXT_VALOR_REFERENCIA { get; set; }
    
        public virtual grupo_da_carteira grupo_da_carteira { get; set; }
        public virtual ICollection<hedge> hedge { get; set; }
        public virtual ICollection<rolagem> rolagem { get; set; }
    }
}
