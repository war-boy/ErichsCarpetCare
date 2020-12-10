using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErichsCarpetCare.Data.EF
{
    class TransactionsMetadata
    {
        [Required]
        [Display(Name = "Service")]
        public int? ServiceId { get; set; }

        [Display(Name = "Invoice Number")]
        public int? InvoiceNumber { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DateTime { get; set; }

        [UIHint("Multilinetext")]
        public string Notes { get; set; }
    }

    [MetadataType(typeof(TransactionsMetadata))]
    public partial class Transactions
    {
    }
}
