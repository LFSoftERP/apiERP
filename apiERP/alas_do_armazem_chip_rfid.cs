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
    
    public partial class alas_do_armazem_chip_rfid
    {
        public int INT_ID { get; set; }
        public int INT_ID_CHIP_RFID { get; set; }
        public int INT_ID_ALA { get; set; }
        public bool BOOL_ATIVO { get; set; }
    
        public virtual alas_do_armazem alas_do_armazem { get; set; }
        public virtual rfid_chip rfid_chip { get; set; }
    }
}
