//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIGBUZhilishnikKuncevo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TotalCheck
    {
        public int id { get; set; }
        public int bankBookId { get; set; }
        public Nullable<decimal> fine { get; set; }
        public decimal totalPayble { get; set; }
        public int paymentStateId { get; set; }
        public Nullable<int> benefitId { get; set; }
        public System.DateTime requiredPaymentDate { get; set; }
        public System.DateTime paymentDate { get; set; }
    
        public virtual BankBook BankBook { get; set; }
        public virtual Benefit Benefit { get; set; }
        public virtual PaymentState PaymentState { get; set; }
    }
}