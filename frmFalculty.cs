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
    public partial class frmFalculty : Form
    {
        StudentContextDB context = new StudentContextDB();
        public frmFalculty()
        {
            InitializeComponent();
            dataFalculty.AutoGenerateColumns = false;
            BindFalculty();
        }

        private void BindFalculty()
        {
            var data1 = (from khoa in context.Falculties
                         select new
                         {
                             colMaKhoa = khoa.FacultyID,
                             colTenKhoa = khoa.FacultyName,
                             colTongSoGS = khoa.TotalProfessor.HasValue ? khoa.TotalProfessor.Value : 0
                         }).ToList();
            dataFalculty.DataSource = data1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Falculty temp = new Falculty();
            temp.FacultyID = int.Parse(textBoxMaKhoa.Text);
            temp.FacultyName = textBoxTenKhoa.Text;
            temp.TotalProfessor = int.Parse(textBoxGS.Text);
            context.Falculties.Add(temp);
            context.SaveChanges();
            BindFalculty();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataFalculty.SelectedRows.Count == 0)
                return;
            int dong = dataFalculty.CurrentRow.Index;
            if (dataFalculty.Rows[dong].Cells[0].Value == null)
                return;
            String id = dataFalculty.Rows[dong].Cells[0].Value.ToString();
            Falculty obj = new Falculty();
            obj.FacultyID = int.Parse(id);
            obj.FacultyName = textBoxTenKhoa.Text;
            obj.TotalProfessor = int.Parse(textBoxGS.Text);
            context.Falculties.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
            BindFalculty();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataFalculty.SelectedRows.Count == 0)
                return;
            int dong = dataFalculty.CurrentRow.Index;
            if (dataFalculty.Rows[dong].Cells[0].Value == null)
                return;
            int id = int.Parse(dataFalculty.Rows[dong].Cells[0].Value.ToString());
            if(id > 0)
            {
                var item = from sv in context.Falculties where (sv.FacultyID == id) select sv;
                if (item != null)
                {
                    foreach (var data_ in item)
                    {
                        context.Falculties.Remove(data_);
                    }
                    context.SaveChanges();
                }
            }
            BindFalculty();
        }

        private void dataFalculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataFalculty.SelectedRows.Count == 0) return;
            int dong = dataFalculty.CurrentRow.Index;
            if (dataFalculty.Rows[dong].Cells[0].Value == null) return;
            textBoxMaKhoa.Text = dataFalculty.Rows[dong].Cells[0].Value.ToString();
            textBoxTenKhoa.Text = dataFalculty.Rows[dong].Cells[1].Value.ToString();
            textBoxGS.Text = dataFalculty.Rows[dong].Cells[2].Value.ToString();
            textBoxMaKhoa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMaKhoa.Text = textBoxTenKhoa.Text = textBoxGS.Text = string.Empty;
        }
    }
}
