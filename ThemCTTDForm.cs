using Bunifu.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace QuanLyGiaiBong
{
    public partial class ThemCTTDForm : Form
    {
         ProcessDataBase dtBase = new ProcessDataBase();
        string madoikhach,madoinha,matrandau, tenDoiNha, tenDoiKhach;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public ThemCTTDForm(int MaTd)
        {
            InitializeComponent();
            matrandau= MaTd.ToString();
        }

        private void TenDoiDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            TenCTDropDown.SelectedIndex = -1;
            DoDropDown.SelectedIndex = -1;
            VangDropDown.SelectedIndex = -1;
            DSCT();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ThemCTTDForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT MaTranDau, DB1.TenDoi AS TenDoiNha, DB2.TenDoi AS TenDoiKhach,DB1.MaDoi AS MaDoiNha,DB2.MaDoi AS MaDoiKhach ,DB1.Logo AS AnhDN,DB2.Logo AS AnhDK " +
                                 "FROM TranDau AS TD " +
                                 "JOIN DoiBong AS DB1 ON TD.MaDoiNha = DB1.MaDoi " +
                                 "JOIN DoiBong AS DB2 ON TD.MaDoiKhach = DB2.MaDoi "+
                                   "WHERE TD.MaTranDau = " + matrandau;

            DataTable result = dtBase.DocBang(query);

            if (result != null && result.Rows.Count > 0)
            {
                tenDoiNha = result.Rows[0]["TenDoiNha"].ToString();
                tenDoiKhach = result.Rows[0]["TenDoiKhach"].ToString();

                TenDoiNhaLabel.Text = tenDoiNha;
                TenDoiKhachLabel.Text = tenDoiKhach;

                madoikhach = result.Rows[0]["MaDoiKhach"].ToString();
                madoinha = result.Rows[0]["MaDoiNha"].ToString();
                matrandau = result.Rows[0]["MaTranDau"].ToString();
                TenDoiDropDown.Items.AddRange(
                   new String[]
                   {
                        tenDoiNha,
                        tenDoiKhach,
                   });

          
                string appPath = Application.StartupPath;
                string projectRootPath = Path.GetFullPath(Path.Combine(appPath, @"..\..")); 
                string doibongPath = Path.Combine(projectRootPath, "Images", "DoiBong");
                string anhDNPath = Path.Combine(doibongPath, result.Rows[0]["AnhDN"].ToString());
                string anhDKPath = Path.Combine(doibongPath, result.Rows[0]["AnhDK"].ToString());


                if (File.Exists(anhDNPath) && File.Exists(anhDKPath))
                {
                    // Load và hiển thị ảnh
                    DoiNhaPicture.WaitOnLoad = true;
                    Image home = Image.FromFile(anhDNPath);
                    DoiNhaPicture.Image = home;
                    DoiNhaPicture.SizeMode = PictureBoxSizeMode.Zoom;

                    DoiKhachPicture.WaitOnLoad = true;
                    Image away = Image.FromFile(anhDKPath);
                    DoiKhachPicture.Image = away;
                    DoiKhachPicture.SizeMode = PictureBoxSizeMode.Zoom;


                }
            }
            result.Dispose();
            DSCT();
        }


        private void DSCT()
        {
            TenCTDropDown.Items.Clear();
            DoDropDown.Items.Clear();
            VangDropDown.Items.Clear();


            if (TenDoiDropDown.SelectedItem != null)
            {
                string selectedTeam = TenDoiDropDown.SelectedItem.ToString();
                string queryTenCT = "";

                if (selectedTeam == tenDoiNha)
                {
                    queryTenCT = "select TenCT from CauThu " +
                        "join TranDau_CauThu on CauThu.MaCT = TranDau_CauThu.MaCauThu " +
                        "join DoiBong on DoiBong.MaDoi = TranDau_CauThu.MaDoi " +
                        "where DoiBong.TenDoi=N'"+tenDoiNha+"' AND TranDau_CauThu.MaTranDau = " + matrandau;
                }
                else if (selectedTeam == tenDoiKhach)
                {
                    queryTenCT = "select TenCT from CauThu " +
                       "join TranDau_CauThu on CauThu.MaCT = TranDau_CauThu.MaCauThu " +
                       "join DoiBong on DoiBong.MaDoi = TranDau_CauThu.MaDoi " +
                       "where DoiBong.TenDoi=N'" + tenDoiKhach + "' AND TranDau_CauThu.MaTranDau = " + matrandau;
                }

                DataTable dsCT = dtBase.DocBang(queryTenCT);

                if (dsCT != null && dsCT.Rows.Count > 0)
                {
                    foreach (DataRow row in dsCT.Rows)
                    {
                        string tenCauThu = row["TenCT"].ToString();
                        TenCTDropDown.Items.Add(tenCauThu);
                        DoDropDown.Items.Add(tenCauThu);
                        VangDropDown.Items.Add(tenCauThu);
                    }

                    dsCT.Dispose();
                }
            }
        }
        private void CapNhatKetQua(string maTD)
        {
            int ma_nha, ma_khach;
            int diem_nha;
            int diem_khach;
            DataTable cttd = dtBase.DocBang("select madoinha,madoikhach, sobanthangdoinha, sobanthuadoinha from trandau where matrandau = " + maTD);
            ma_nha = int.Parse(cttd.Rows[0]["madoinha"].ToString());
            ma_khach = int.Parse(cttd.Rows[0]["madoikhach"].ToString());
            diem_nha = int.Parse(cttd.Rows[0]["sobanthangdoinha"].ToString());
            diem_khach = int.Parse(cttd.Rows[0]["sobanthuadoinha"].ToString());
            if (diem_nha > diem_khach)
            {
                dtBase.CapNhatDuLieu("update DoiBong set Diem = ISNULL(Diem,0) + 3 where MaDoi = " + ma_nha);
            }
            else if (diem_nha == diem_khach)
            {
                dtBase.CapNhatDuLieu("update DoiBong set Diem = ISNULL(Diem,0) + 1 where MaDoi = " + ma_nha);
                dtBase.CapNhatDuLieu("update DoiBong set Diem = ISNULL(Diem,0) + 1 where MaDoi = " + ma_khach);
            }
            else
            {
                dtBase.CapNhatDuLieu("update DoiBong set Diem = ISNULL(Diem,0) + 3 where MaDoi = " + ma_khach);
            }
            cttd.Dispose();
        }

        private void DSDoiKhachBtn_Click(object sender, EventArgs e)
        {
            DSCauThuThiDauForm dsCauThuForm = new DSCauThuThiDauForm(madoikhach,matrandau);
            dsCauThuForm.Show();
        }

        private void DSDoiNhaBtn_Click(object sender, EventArgs e)
        {
            DSCauThuThiDauForm dsCauThuForm = new DSCauThuThiDauForm(madoinha,matrandau);
            dsCauThuForm.Show();
        }
        private void LuuBtn_Click(object sender, EventArgs e)
        {
            if (TenDoiDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn 1 đội bóng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (DoDropDown.SelectedIndex == -1 && VangDropDown.SelectedIndex == -1 && TenCTDropDown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select at least one player or event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (TgianTheDo.Value == 0 && TgianTheVang.Value == 0 && TgianGhiBan.Value == 0)
            {
                MessageBox.Show("Hãy nhập thời gian khác 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (DoDropDown.SelectedIndex != -1)
            {
                string tenCauThu = DoDropDown.SelectedItem.ToString();
                int thoiGian = (int)TgianTheDo.Value;
         
                string insertRedCardQuery = $"INSERT INTO TranDau_The (MaTranDau, MaCauThu, ThoiGian, LoaiThe) " +
                                             $"VALUES ({matrandau}, (SELECT MaCT FROM CauThu WHERE TenCT = N'{tenCauThu}'), {thoiGian}, N'Thẻ Đỏ')";
                dtBase.CapNhatDuLieu(insertRedCardQuery);
            }

            if (VangDropDown.SelectedIndex != -1)
            {
                string tenCauThu = VangDropDown.SelectedItem.ToString();
                int thoiGian = (int)TgianTheVang.Value;
              
                string insertYellowCardQuery = $"INSERT INTO TranDau_The (MaTranDau, MaCauThu, ThoiGian, LoaiThe) " +
                                               $"VALUES ({matrandau}, (SELECT MaCT FROM CauThu WHERE TenCT = N'{tenCauThu}'), {thoiGian}, N'Thẻ Vàng')";
                dtBase.CapNhatDuLieu(insertYellowCardQuery);
            }

            if (TenCTDropDown.SelectedIndex != -1)
            {
                string tenCauThu = TenCTDropDown.SelectedItem.ToString();
                int thoiGian;
                if (int.TryParse(TgianGhiBan.Value.ToString(), out thoiGian))
                {
                    // The conversion was successful, proceed with the rest of your code
                    string insertGoalQuery = $"INSERT INTO TranDau_BanThang (MaTranDau, MaCauThu, ThoiGian) " +
                                             $"VALUES ({matrandau}, (SELECT MaCT FROM CauThu WHERE TenCT = N'{tenCauThu}'),  {thoiGian})";
                    dtBase.CapNhatDuLieu(insertGoalQuery);
                }
                else
                {
                    // Handle the case where the conversion fails (e.g., show an error message)
                    MessageBox.Show("Please enter a valid numeric value for ThoiGian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ClearFormValues();
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearFormValues()
        {
            DoDropDown.SelectedIndex = -1;
            VangDropDown.SelectedIndex = -1;
            TenCTDropDown.SelectedIndex = -1;

            TgianTheDo.Value = 0;
            TgianTheVang.Value = 0;
            TgianGhiBan.Value = 0;
        }
    
    }
}
    

