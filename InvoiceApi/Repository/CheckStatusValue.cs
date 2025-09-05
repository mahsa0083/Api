using System.ComponentModel;

namespace InvoiceApi.Repository
{
    public enum CheckStatusValue
    {
        [Description("درحال پرداخت")]
        Pending=1,

        [Description("پرداخت شده")]
        Paid=2,

        [Description("پرداخت شده")]

        Waiting = 3
    }
}
