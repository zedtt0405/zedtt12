using Lab_4.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class frmOrder : Form
    {
        StudentContextDB context = new StudentContextDB();
        public frmOrder()
        {
            InitializeComponent();
            BindOrder(false, DateTime.Now, DateTime.Now);
        }
        private void BindOrder(bool isAllMonth, DateTime fromDate, DateTime toDate)
        {
            string sql = string.Empty;
            if (isAllMonth)
                sql = string.Format(@"select ROW_NUMBER() OVER(ORDER BY a.InvoiceNo) AS [Index], b.OrderDate, b.DeliveryDate, a.InvoiceNo, a.Price, a.Quantity, a.Price * a.Quantity as TotalAmount from [Order] a left join Invoice b
                on a.InvoiceNo = b.InvoiceNo
                where b.OrderDate >= CAST('{0} 00:00:00.000' as datetime) and b.OrderDate <= CAST('{1} 23:59:59.998' as datetime)", GetStartOfCurrentMonth().ToString("yyyy-MM-dd"), GetEndOfCurrentMonth().ToString("yyyy-MM-dd"));
            else
                sql = string.Format(@"select ROW_NUMBER() OVER(ORDER BY a.InvoiceNo) AS [Index], b.OrderDate, b.DeliveryDate, a.InvoiceNo, a.Price, a.Quantity, a.Price * a.Quantity as TotalAmount from [Order] a left join Invoice b
                on a.InvoiceNo = b.InvoiceNo
                where b.OrderDate >= CAST('{0} 00:00:00.000' as datetime) and b.OrderDate <= CAST('{1} 23:59:59.998' as datetime)", fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"));
            List<ItemOrder> lst = new List<ItemOrder>();
            using (var ctx = new StudentContextDB())
            {
                lst = ctx.Database.SqlQuery<ItemOrder>(sql).ToList();
            };
            dataOrder.DataSource = lst;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BindOrder(true, DateTime.Now, DateTime.Now);
        }

        #region Extends
        private class ItemOrder
        {
            public long Index { get; set; }
            public string InvoiceNo { get; set; }
            public DateTime OrderDate { get; set; }
            public DateTime DeliveryDate { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalAmount { get; set; }
        }
        private static DateTime GetStartOfCurrentMonth()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0, 0);
        }

        private static DateTime GetEndOfCurrentMonth()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 23, 59, 59, 999);
        }
        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value != DateTime.MinValue)
                BindOrder(false, dateTimePicker1.Value, dateTimePicker2.Value);
            else
                BindOrder(false, dateTimePicker1.Value, DateTime.Now);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != DateTime.MinValue)
                BindOrder(false, dateTimePicker1.Value, dateTimePicker2.Value);
            else
                BindOrder(false, DateTime.Now, dateTimePicker2.Value);
        }
    }
}
