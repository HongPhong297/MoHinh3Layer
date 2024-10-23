using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class FrmQL : Form
    {
        private StudentService studentService;
        private FacultyService facultyService;
        public FrmQL()
        {
            InitializeComponent();
            studentService = new StudentService();
            facultyService = new FacultyService();
            LoadData();
            LoadFacultyComboBox();
        }
        private void LoadData()
        {
            dgvQuanLiSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuanLiSV.DataSource = studentService.LoadStudents();

        }
        private void LoadFacultyComboBox()
        {
            // Nạp danh sách khoa vào ComboBox
            cboKhoa.DataSource = facultyService.GetAllFacultyNames(); // Gọi service để lấy dữ liệu khoa
            //cboKhoa.DisplayMember = "FacultyName"; // Hiển thị tên khoa
            //cboKhoa.ValueMember = "FacultyID"; // Giá trị khoa là FacultyID

            //DataTable faculties = facultyService.GetAllFaculties();
           

        }
        private void dgvQuanLiSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu chỉ số hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                var selectedRow = dgvQuanLiSV.Rows[e.RowIndex];

               

                // Lấy giá trị từ hàng được chọn và đẩy vào các TextBox và ComboBox
                txtMaSV.Text = selectedRow.Cells["MSSV"].Value.ToString();
                txtHoTen.Text = selectedRow.Cells["Họ Tên"].Value.ToString();
                cboKhoa.SelectedItem = selectedRow.Cells["Khoa"].Value.ToString(); // Nếu ComboBox chứa các giá trị này
                txtDiemTrungBinh.Text = selectedRow.Cells["ĐTB"].Value.ToString();


                //string khoaValue = selectedRow.Cells["Khoa"].Value.ToString();
                //MessageBox.Show("Giá trị Khoa: " + khoaValue);

                ////string khoaValue = selectedRow.Cells["Khoa"].Value.ToString();

                ////for (int i = 0; i < cboKhoa.Items.Count; i++)
                ////{
                ////    if (((DataRowView)cboKhoa.Items[i])["FacultyName"].ToString() == khoaValue)
                ////    {
                ////        cboKhoa.SelectedIndex = i;
                ////        break;
                ////    }
                ////}
                string mssv = selectedRow.Cells["MSSV"].Value.ToString();
                string imagePath = $@"D:\LearningCSharp\MoHinh3Layer\GUI\Img\{mssv}.png"; // Đường dẫn tới thư mục chứa ảnh


                if (System.IO.File.Exists(imagePath))
                {
                    picBoxAnhDaiDien.Image = Image.FromFile(imagePath);
                }
                else
                {
                    picBoxAnhDaiDien.Image = null; // Hoặc có thể gán ảnh mặc định nếu không tìm thấy
                    MessageBox.Show("Không tìm thấy ảnh cho sinh viên: " + mssv);
                }


            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập MSSV và Họ Tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị từ các TextBox và ComboBox
                string studentID = txtMaSV.Text;
                string fullName = txtHoTen.Text;
                float? averageScore = string.IsNullOrWhiteSpace(txtDiemTrungBinh.Text) ? (float?)null : float.Parse(txtDiemTrungBinh.Text);

                // Lấy FacultyID từ ComboBox
                // Lấy FacultyID từ ComboBox
                var selectedFaculty = cboKhoa.SelectedItem.ToString();
                MessageBox.Show(selectedFaculty.ToString());
                int facultyID = facultyService.GetFacultyIDByName((string)selectedFaculty); // Khai báo biến là int             
                //int majorID = 1; // Giả sử bạn có logic để xác định MajorID, nếu không hãy để là null.
                string avatar = "2";
                // Kiểm tra nếu MSSV đã tồn tại trong DataGridView
                bool isUpdating = dgvQuanLiSV.SelectedRows.Count > 0 &&
                                  dgvQuanLiSV.SelectedRows[0].Cells["MSSV"].Value.ToString() == studentID;

                if (isUpdating)
                {
                    // Cập nhật sinh viên
                    studentService.UpdateStudent(studentID, fullName, averageScore, facultyID,"7");
                    MessageBox.Show("Cập nhật sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Thêm sinh viên
                    studentService.AddStudent(studentID, fullName, averageScore, facultyID,"8");
                    MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Tải lại dữ liệu vào DataGridView
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxChuaDKCN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChuaDKCN.Checked)
            {
                // Hiển thị sinh viên chưa đăng ký chuyên ngành (MajorID là null)
                dgvQuanLiSV.DataSource = studentService.GetStudentsWithNullMajor();
            }
            else
            {
                // Hiển thị toàn bộ sinh viên
                LoadData();
            }
        }

    }
}
