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
    
    public partial class convenio_medico
    {
        public convenio_medico()
        {
            this.convenio_medico_guia = new HashSet<convenio_medico_guia>();
            this.convenio_titular = new HashSet<convenio_titular>();
        }
    
        public int INT_ID { get; set; }
        public string TXT_CONVENIO { get; set; }
        public string TXT_LOCAL { get; set; }
        public decimal DECIMAL_PORCENTAGEM_EMPRESA { get; set; }
        public System.DateTime DATE_LANCAMENTO { get; set; }
        public int INT_ID_EMPRESA { get; set; }
        public bool BOOL_ATIVO { get; set; }
        public decimal DECIMAL_PROCENTAGEM_EMPRESA_PARA_DEPENDENTES { get; set; }
    
        public virtual empresa empresa { get; set; }
        public virtual ICollection<convenio_medico_guia> convenio_medico_guia { get; set; }
        public virtual ICollection<convenio_titular> convenio_titular { get; set; }
    }
}
