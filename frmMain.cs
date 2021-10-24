
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Lab_4.model;

namespace Lab_4
{
    public partial class frmMain : Form
    {
        StudentContextDB context = new StudentContextDB();
        public frmMain()
        {
            InitializeComponent();
            
        }
        public void InsertStudent(Student temp)
        {
            StudentContextDB context = new StudentContextDB();
            context.Students.Add(temp);
            context.SaveChanges();
        }

        private void NapTenKhoaVaoComboBox()
        {
            var select = from s in context.Falculties select s.FacultyName;
            foreach(var s in select)
            {
                cbbKhoa.Items.Add(s);

            }
        }

        private void NapDSSinhVienVaoGridView()
        {
            dataGridViewStudent.Rows.Clear();
            var data1 = from sinhvien in context.Students
                        join khoa in context.Falculties on sinhvien.FacultyID equals khoa.FacultyID
                        select new
                        {
                            masv = sinhvien.StudentID,
                            tensv = sinhvien.FullName,
                            diemTBsv = sinhvien.AverageScore,
                            tenkhoa = khoa.FacultyName

                        };
            foreach (var data_ in data1)
            {
                //Console.WriteLine("{0}-{1}-{2}-{3}", data_.masv, data_.tensv, data_.diemTBsv, data_.tenkhoa);
                dataGridViewStudent.Rows.Add(data_.masv, data_.tensv, data_.diemTBsv, data_.tenkhoa);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            NapTenKhoaVaoComboBox();
            NapDSSinhVienVaoGridView();
        }

        private void DataGridViewStudent_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridViewStudent.SelectedRows.Count == 0) return;
            int dong = dataGridViewStudent.CurrentRow.Index;
            if (dataGridViewStudent.Rows[dong].Cells[0].Value == null) return;
            textBoxMaSV.Text = dataGridViewStudent.Rows[dong].Cells[0].Value.ToString();
            textBoxHoTen.Text = dataGridViewStudent.Rows[dong].Cells[1].Value.ToString();
            textBoxDTB.Text = dataGridViewStudent.Rows[dong].Cells[2].Value.ToString();
            cbbKhoa.Text = dataGridViewStudent.Rows[dong].Cells[3].Value.ToString();
            textBoxMaSV.Enabled = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count == 0) return;
            int dong = dataGridViewStudent.CurrentRow.Index;
            if (dataGridViewStudent.Rows[dong].Cells[0].Value == null) return;
            String maSVCanXoa = dataGridViewStudent.Rows[dong].Cells[0].Value.ToString();
            var svXoa = from sv in context.Students where (sv.StudentID == maSVCanXoa) select sv;
            if (svXoa != null)
            {
                foreach (var data_ in svXoa)
                {
                    context.Students.Remove(data_);
                }
                context.SaveChanges();
                NapDSSinhVienVaoGridView();
                textBoxMaSV.Enabled = true;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Student temp = new Student();
            temp.StudentID = textBoxMaSV.Text;
            temp.FullName = textBoxHoTen.Text;
            temp.AverageScore = float.Parse(textBoxDTB.Text);
            temp.FacultyID = cbbKhoa.SelectedIndex + 1;
            context.Students.Add(temp);
            context.SaveChanges();
            NapDSSinhVienVaoGridView();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count == 0) return;
            int dong = dataGridViewStudent.CurrentRow.Index;
            if (dataGridViewStudent.Rows[dong].Cells[0].Value == null) return;
            String maSVCanUpdate = dataGridViewStudent.Rows[dong].Cells[0].Value.ToString();        
            Student student = new Student();
            student.StudentID = maSVCanUpdate; // textBoxMaSV.Text;
            student.FullName = textBoxHoTen.Text;
            student.AverageScore = float.Parse(textBoxDTB.Text);
            student.FacultyID = cbbKhoa.SelectedIndex + 1;
            context.Students.Attach(student);
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();
            NapDSSinhVienVaoGridView();
            textBoxMaSV.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFalculty frmFal = new frmFalculty();
            frmFal.Closed += (s, args) => this.Close();
            frmFal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrder _frmOrder = new frmOrder();
            _frmOrder.Closed += (s, args) => this.Close();
            _frmOrder.Show();
        }
    }
}

