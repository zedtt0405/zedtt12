using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Order")]
    public partial class Order
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int No { get; set; }
        
        public int InvoiceNo { get; set; }

        public int ProductID { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        public decimal Price { get; set; }

        public int? Quantity { get; set; }
    }
}
