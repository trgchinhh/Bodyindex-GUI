using System;
using System.Windows.Forms;
using KhoiTaoThongTinCaNhan;
using TinhChiSoCoThe;

namespace WindowsFormsApp1
{
	public partial class Form2 : Form
	{
		private Thongtincanhan ttcn;
		public Form2(Thongtincanhan ttcn)
		{
			this.ttcn = ttcn;
			InitializeComponent();
			FillTextBox();
			BodyCalculate();
			float chi_so_bmi = ChiSoCoThe.chi_so_bmi(ttcn.can_nang, ttcn.chieu_cao);
			BodyAdvice(chi_so_bmi);
			// gán ảnh đại diện 
			if (ttcn.anh_dai_dien != null)
			{
				pictureBox1.Image = ttcn.anh_dai_dien;
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		public void FillTextBox()
		{
			TB_Thongtinnguoidung.Multiline = true;
			TB_Thongtinnguoidung.ScrollBars = ScrollBars.Vertical;
			TB_Thongtinnguoidung.ReadOnly = true;



			string[] thong_tin_ca_nhan = new string[]
			{
				"◉ Họ tên: " + ttcn.ho_ten,
				"◉ Giới tính: " + ttcn.gioi_tinh,
				"◉ Ngày sinh: " + ttcn.ngay_sinh.ToString("dd/MM/yyyy"),
				"◉ Tuổi hiện tại: " + ttcn.tuoi_hien_tai.ToString(),
				"◉ Chiều cao: " + ttcn.chieu_cao.ToString() + " (m)",
				"◉ Cân nặng: " + ttcn.can_nang.ToString() + " (kg)",
				"◉ Nhóm máu: " + ttcn.nhom_mau,
				"◉ Vòng eo: " + ttcn.vong_eo + " (cm)",
				"◉ Vòng hông: " + ttcn.vong_hong + " (cm)",
				"◉ Chỉ số vận động: " + ttcn.chi_so_van_dong.ToString(),
			};
			TB_Thongtinnguoidung.Text = string.Join(Environment.NewLine, thong_tin_ca_nhan);
			TB_Thongtinnguoidung.SelectionStart = 0;  
			TB_Thongtinnguoidung.SelectionLength = 0;
            TB_Thongtinnguoidung.TabStop = false;
        }

        private void BodyCalculate()
		{
			LB_BMI.Text = ChiSoCoThe.chi_so_bmi(ttcn.can_nang, ttcn.chieu_cao).ToString();
			LB_BMR.Text = ChiSoCoThe.chi_so_bmr(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao, ttcn.tuoi_hien_tai).ToString();
			LB_TDEE.Text = ChiSoCoThe.chi_so_tdee(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao, ttcn.tuoi_hien_tai, ttcn.chi_so_van_dong).ToString();
			LB_WHR.Text = ChiSoCoThe.chi_so_whr(ttcn.gioi_tinh, ttcn.vong_eo, ttcn.vong_hong).ToString();
			LB_LBM.Text = ChiSoCoThe.chi_so_lbm(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao).ToString();
			LB_FFMI.Text = ChiSoCoThe.chi_so_ffmi(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao).ToString();
			LB_RFM.Text = ChiSoCoThe.chi_so_rfm(ttcn.vong_eo, ttcn.chieu_cao).ToString();
			LB_BFP.Text = ChiSoCoThe.chi_so_bfp(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao, ttcn.tuoi_hien_tai).ToString();
			LB_BBW.Text = ChiSoCoThe.chi_so_bbw(ttcn.can_nang).ToString();
			LB_IBW.Text = ChiSoCoThe.chi_so_ibw(ttcn.gioi_tinh, ttcn.chieu_cao).ToString();
			LB_MA.Text = ChiSoCoThe.chi_so_ma(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao, ttcn.tuoi_hien_tai).ToString();
			LB_VFR.Text = ChiSoCoThe.chi_so_vfr(ttcn.vong_eo, ttcn.vong_hong).ToString();
			LB_BSA.Text = ChiSoCoThe.chi_so_bsa(ttcn.chieu_cao, ttcn.can_nang).ToString();
			LB_VO2MAX.Text = ChiSoCoThe.chi_so_vo2max(ttcn.nhip_tim_toi_da, ttcn.nhip_tim_nghi).ToString();
			LB_HSI.Text = ChiSoCoThe.chi_so_hsi(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao, ttcn.tuoi_hien_tai, ttcn.cholesterol, ttcn.huyet_ap).ToString();
			LB_MMI.Text = ChiSoCoThe.chi_so_mmi(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao).ToString();
			LB_BFM.Text = ChiSoCoThe.chi_so_bfm(ttcn.gioi_tinh, ttcn.can_nang, ttcn.chieu_cao, ttcn.tuoi_hien_tai).ToString();
		}


		private void BodyAdvice(float chi_so_bmi)
		{
            TB_Tinhtrang.Multiline = true;
            TB_Tinhtrang.ReadOnly = true;
            if (chi_so_bmi < 18.5)
			{
				TB_Tinhtrang.Text = "Thiếu cân"
				+ Environment.NewLine
				+ "Có nguy cơ suy dinh dưỡng"
				+ Environment.NewLine 
				+ "(◉) Cơ thể cần bổ sung dưỡng chất nhiều hơn";
			}
			else if(chi_so_bmi > 18.5 && chi_so_bmi < 24.9)
			{
				TB_Tinhtrang.Text = "Cơ thể cân đối"
				+ Environment.NewLine 
				+ "(◉) Nên duy trì thể trạng lành mạnh";
			} else
			{
				TB_Tinhtrang.Text = "Thừa cân"
                + Environment.NewLine
                + "Có nguy cơ béo phì"
				+ Environment.NewLine 
				+ "(◉) Nên duy trì thói quen tập thể dục";
			}
            TB_Tinhtrang.SelectionStart = 0;
            TB_Tinhtrang.SelectionLength = 0;
            TB_Tinhtrang.TabStop = false;
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		   
		}

		private void LB_BMI_Click(object sender, EventArgs e)
		{

		}

		private void LB_BMR_Click(object sender, EventArgs e)
		{

		}

		private void LB_TDEE_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
