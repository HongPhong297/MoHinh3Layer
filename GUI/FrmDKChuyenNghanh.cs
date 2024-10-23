using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDKChuyenNghanh : Form
    {
        private readonly MajorService majorService;
        private readonly FacultyService facultyService;
        private readonly StudentService studentService;
        public FrmDKChuyenNghanh()
        {
            InitializeComponent();
            facultyService = new FacultyService();
            majorService = new MajorService();
            studentService = new StudentService();
            
            setup();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboKhoa.DataSource = facultyService.GetAllFacultyNames();
            //int selectedfacultyid = convert.toint32(cbokhoa.selectedvalue);
            var selectedFaculty = cboKhoa.SelectedItem.ToString();      
            int facultyID = facultyService.GetFacultyIDByName((string)selectedFaculty);         
            cboChuyenNganh.DataSource = majorService.GetMajorsByFaculty(facultyID);
            cboChuyenNganh.DisplayMember = "Name";
            cboChuyenNganh.ValueMember = "MajorID";


            MessageBox.Show("cboKhoa_SelectedIndexChanged");
            // Thêm cột checkbox vào đầu
            ;
            // Load students who haven't registered for a major
            dgvDangKi.DataSource = studentService.GetStudentsWithNullMajor(selectedFaculty);

            
        }
        private void setup()
        {
            MessageBox.Show("setup()");
            try
            {
                dgvDangKi.Columns.Clear();  // Xóa tất cả cột trước khi load lại dữ liệu nếu cần
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Chọn";  // Đặt tên cho cột
                checkBoxColumn.Width = 50;  // Đặt độ rộng cột
                checkBoxColumn.Name = "Chọn";  // Đặt tên cột để tham chiếu sau này
                checkBoxColumn.ReadOnly = false;

                //dgvDangKi.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                // Thêm cột checkbox vào dgvDangKi
                dgvDangKi.Columns.Add(checkBoxColumn);
                dgvDangKi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                cboKhoa.DataSource = facultyService.GetAllFacultyNames();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi " + ex);
            }
            
        }

        private void dgvDangKi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Reference the GridView Row.
                DataGridViewRow row = dgvDangKi.Rows[e.RowIndex];

                //Set the CheckBox selection.
                row.Cells["Chọn"].Value = !Convert.ToBoolean(row.Cells["Chọn"].EditedFormattedValue);

                //If CheckBox is checked, display Message Box.
                if (Convert.ToBoolean(row.Cells["Chọn"].Value))
                {
                    MessageBox.Show("Selected ID: " + row.Cells[1].Value);
                }
            }

            int majorID = (int)cboChuyenNganh.SelectedValue;
            MessageBox.Show(majorID.ToString());
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected MajorID from the ComboBox
                int majorID = (int)cboChuyenNganh.SelectedValue;
                //MessageBox.Show();
                // Check if a major is selected
                if (majorID == null)
                {
                    MessageBox.Show("Vui lòng chọn một chuyên ngành để đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Loop through the DataGridView rows
                foreach (DataGridViewRow row in dgvDangKi.Rows)
                {
                    // Check if the checkbox in the "Chọn" column is selected
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        // Get the StudentID from the row
                        int studentID = Convert.ToInt32(row.Cells["MSSV"].Value);

                        // Update the MajorID for the selected student
                        studentService.UpdateStudentMajor(studentID, majorID);

                        // Optional: You can show a message for each student that was registered
                        // MessageBox.Show($"Sinh viên {studentID} đã được đăng ký chuyên ngành thành công.");
                    }
                }

                // Refresh the DataGridView after registration
                setup(); // Assuming you have a method to reload the data

                MessageBox.Show("Đăng ký chuyên ngành thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDKChuyenNghanh_Load(object sender, EventArgs e)
        {

        }

        //private void btnDangKi_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Get the selected MajorID from the ComboBox
        //        int majorID = (int)cboChuyenNganh.SelectedValue;

        //        // Check if a major is selected
        //        if (majorID == null)
        //        {
        //            MessageBox.Show("Vui lòng chọn một chuyên ngành để đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        bool isAnyRowChecked = false; // Flag to check if any row is selected

        //        // Loop through the DataGridView rows
        //        foreach (DataGridViewRow row in dgvDangKi.Rows)
        //        {
        //            // Check if the checkbox in the "Chọn" column is selected
        //            bool isChecked = Convert.ToBoolean(row.Cells["Chọn"].Value);
        //            if (isChecked)
        //            {
        //                isAnyRowChecked = true; // Mark that at least one row is checked

        //                // Get the StudentID from the row
        //                int studentID = Convert.ToInt32(row.Cells["MSSV"].Value);

        //                // Update the MajorID for the selected student
        //                studentService.UpdateStudentMajor(studentID, majorID);
        //            }
        //        }

        //        if (isAnyRowChecked)
        //        {
        //            // Refresh the DataGridView after registration
        //            setup();  // Assuming you have a method to reload the data

        //            MessageBox.Show("Đăng ký chuyên ngành thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            // Show a message if no rows were selected
        //            MessageBox.Show("Vui lòng chọn ít nhất một sinh viên để đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



    }
}
