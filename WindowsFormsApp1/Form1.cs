using System;
using System.Drawing;
using System.Windows.Forms;
using KhoiTaoThongTinCaNhan;

namespace WindowsFormsApp1
{
	public partial class FrmForm1 : Form
	{
		public string gioi_tinh = "";
		public double chi_so_van_dong = 0;
		public string nhom_mau = "";
		public int tuoi = 0;
		public int nhip_tim_toi_da = 0;
		public int nhip_tim_nghi = 0;
		public int huyet_ap = 0;
		public int cholestero = 0;
		// ===================== KHỞI TẠO =====================
		public FrmForm1()
		{
			InitializeComponent();
		}

		// ===================== FORM LOAD =====================
		private void FrmForm1_Load(object sender, EventArgs e)
		{

		}

		// ===================== LABEL =====================
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void LB_Chisovandong_Click(object sender, EventArgs e)
		{

		}

		private void LB_Tieudenhap_Click(object sender, EventArgs e)
		{

		}

		private void LB_Hoten_Click(object sender, EventArgs e)
		{

		}

		private void LB_Cannang_Click(object sender, EventArgs e)
		{

		}

		// hàm cảnh báo khi nhập sai  
		void Canh_bao(string message)
		{
			MessageBox.Show(
				message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning
			);
		}

		// ===================== TEXTBOX =====================
		private void TB_Hoten_TextChanged(object sender, EventArgs e)
		{
			foreach (char c in TB_Hoten.Text)
			{
				if (char.IsDigit(c))
				{
					Canh_bao("Họ tên không được chứa số");
					TB_Hoten.Text = "";
					break;
				}
			}
		}

		private void TB_Chieucao_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Chieucao.Text, out _))
			{
				TB_Chieucao.Text = "";
			}
		}

		private void TB_Cannang_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Cannang.Text, out _))
			{
				TB_Cannang.Text = "";
			}
		}

		// ===================== GIỚI TÍNH =====================
		private void CB_Nam_CheckedChanged(object sender, EventArgs e)
		{
			if (CB_Nam.Checked) gioi_tinh = "Nam";
		}

		private void CB_Nu_CheckedChanged(object sender, EventArgs e)
		{
			if (CB_Nu.Checked) gioi_tinh = "Nữ";
		}

		private void CB_Khac_CheckedChanged(object sender, EventArgs e)
		{
			if (CB_Khac.Checked) gioi_tinh = "Khác";
		}

		// ===================== DATETIME =====================
		private void DT_Ngaysinh_ValueChanged(object sender, EventArgs e)
		{

		}

		// ===================== COMBOBOX =====================
		private void CBB_Chisovandong_SelectedIndexChanged(object sender, EventArgs e)
		{
			double[] mang_chisovandong = { 1.2, 1.375, 1.55, 1.725, 1.9 };
			int index = CBB_Chisovandong.SelectedIndex;
			if (index >= 0)
			{
				chi_so_van_dong = mang_chisovandong[index];
			}
		}

		private void CBB_Nhommau_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] mang_nhommau = { "A", "B", "AB", "O" };
			int index = CBB_Nhommau.SelectedIndex;
			if (index >= 0)
			{
				nhom_mau = mang_nhommau[index];
			}
		}

		// ===================== PICTURE BOX =====================
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Title = "Chọn ảnh đại diện";
				ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Gán ảnh vào PictureBox
						pictureBox1.Image = Image.FromFile(ofd.FileName);
						pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // co giãn vừa PictureBox
					}
					catch (Exception ex)
					{
                        Canh_bao("Không thể mở ảnh: " + ex.Message);
					}
				}
			}
			if (pictureBox1.Image == null)
			{
                Canh_bao("Vui lòng chọn ảnh đại diện");
			}
		}

		private void TB_Vongeo_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Vongeo.Text, out _))
			{
				TB_Vongeo.Text = "";
			}
		}

		private void TB_Vonghong_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Vonghong.Text, out _))
			{
				TB_Vonghong.Text = "";
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void TB_Nhiptimtoida_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Nhiptimtoida.Text, out _))
			{
				TB_Nhiptimtoida.Text = "";
			}
		}

		private void TB_Nhiptimnghi_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Nhiptimnghi.Text, out _))
			{
				TB_Nhiptimnghi.Text = "";
			}
		}

		private void TB_Cholestero_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Cholestero.Text, out _))
			{
				TB_Cholestero.Text = "";
			}
		}

		private void TB_Huyetap_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(TB_Huyetap.Text, out _))
			{
				TB_Huyetap.Text = "";
			}
		}

		// ===================== BUTTON =====================
		private void button1_Click(object sender, EventArgs e)
		{
			// kiểm tra nhập họ tên 
			if (string.IsNullOrWhiteSpace(TB_Hoten.Text))
			{
                Canh_bao("Vui lòng nhập họ tên");
				return;
			}

			// kiểm tra nhập giới tính 
			if (gioi_tinh == "")
			{
                Canh_bao("Vui lòng chọn giới tính");
				return;
			}

			// kiểm tra nhập hợp lệ cân nặng và chiều cao 
			if (!double.TryParse(TB_Chieucao.Text, out double chieu_cao) ||
				!double.TryParse(TB_Cannang.Text, out double can_nang))
			{
                Canh_bao("Vui lòng nhập chiều cao và cân nặng đầy đủ");
				return;
			}

			// kiểm tra nhập hợp lệ nhịp tim 
			if (!double.TryParse(TB_Nhiptimtoida.Text, out double nhip_tim_toi_da) ||
				!double.TryParse(TB_Nhiptimnghi.Text, out double nhip_tim_nghi))
			{
                Canh_bao("Vui lòng nhập nhịp tim đầy đủ");
				return;
			}

            // kiểm tra nhập hợp lệ huyết áp và cholesterol
            if (!double.TryParse(TB_Huyetap.Text, out double huyet_ap) ||
                !double.TryParse(TB_Cholestero.Text, out double cholestero))
            {
                Canh_bao("Vui lòng nhập huyết áp và cholestero");
				return;
            }

            // ngày sinh 
            DateTime ngay_sinh = DT_Ngaysinh.Value;
			tuoi = DateTime.Now.Year - ngay_sinh.Year;

			// Kiểm tra ảnh
			if (pictureBox1.Image == null)
			{
                Canh_bao("Vui lòng chọn ảnh đại diện");
				return;
			}

            // kiểm tra tuổi
            if (tuoi < 1 || tuoi > 80)
            {
                Canh_bao("Vui lòng chọn ngày sinh");
                return;
            }

            // kiểm tra chiều cao 
            if (chieu_cao < 100 || chieu_cao > 250)
            {
                Canh_bao("Chiều cao phải từ 100 đến 250 cm");
                return;
            }

            // kiểm tra cân nặng
            if (can_nang < 20 || can_nang > 300)
            {
                Canh_bao("Cân nặng phải từ 20 đến 300 kg");
                return;
            }

            // kiểm tra nhịp tim nghỉ và tối đa 
            if (nhip_tim_nghi < 40 || nhip_tim_nghi > 120)
            {
                Canh_bao("Nhịp tim nghỉ phải từ 40 – 120 bpm");
                return;
            }
            if (nhip_tim_toi_da < 60 || nhip_tim_toi_da > 220)
            {
                Canh_bao("Nhịp tim tối đa không hợp lệ");
                return;
            }

            // kiểm tra huyết áp 
            if (huyet_ap < 70 || huyet_ap > 200)
            {
                Canh_bao("Huyết áp phải từ 70 – 200 mmHg");
                return;
            }

            // kiểm tra cholesterol
            if (cholestero < 100 || cholestero > 400)
            {
                Canh_bao("Cholesterol phải từ 100 – 400 mg/dL");
                return;
            }

            // kiểm tra chọn chỉ số vận động 
            if (chi_so_van_dong == 0)
            {
                Canh_bao("Vui lòng chọn chỉ số vận động");
                return;
            }

            // kiểm tra chọn nhóm máu
            if (string.IsNullOrEmpty(nhom_mau))
            {
                Canh_bao("Vui lòng chọn nhóm máu");
                return;
            }

            Thongtincanhan ttcn = new Thongtincanhan()
			{
				ho_ten = TB_Hoten.Text,
				gioi_tinh = gioi_tinh,
				ngay_sinh = ngay_sinh,
				tuoi_hien_tai = tuoi,
				chieu_cao = (float.TryParse(TB_Chieucao.Text, out float cc) ? cc : 0) / 100,
				can_nang = float.TryParse(TB_Cannang.Text, out float cn) ? cn : 0,
				vong_eo = float.TryParse(TB_Vongeo.Text, out float ve) ? ve : 0,
				vong_hong = float.TryParse(TB_Vonghong.Text, out float vh) ? vh : 0,
				nhip_tim_nghi = float.TryParse(TB_Nhiptimnghi.Text, out float ntn) ? ntn : 0,
                nhip_tim_toi_da = float.TryParse(TB_Nhiptimtoida.Text, out float nttd) ? nttd : 0,
                huyet_ap = float.TryParse(TB_Huyetap.Text, out float ha) ? ha : 0,
                cholesterol = float.TryParse(TB_Cholestero.Text, out float ch) ? ch : 0,
                chi_so_van_dong = chi_so_van_dong,
				nhom_mau = nhom_mau,
				anh_dai_dien = pictureBox1.Image,
			};

			Form2 form2 = new Form2(ttcn);
			this.Hide();
			form2.ShowDialog();
			this.Show();
		}
	}
}
