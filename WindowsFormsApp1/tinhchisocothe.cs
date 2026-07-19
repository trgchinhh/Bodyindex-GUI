using System;

namespace TinhChiSoCoThe
{
	public static class ChiSoCoThe
	{

		public static float chi_so_bmi(float can_nang, float chieu_cao)
		{
			return (float)Math.Round((can_nang / (chieu_cao * chieu_cao)), 2);
		}

		public static float chi_so_bmr(string gioi_tinh, float can_nang, float chieu_cao, int tuoi)
		{
			float bmr = 0;
			if (gioi_tinh == "Nam")
			{
				bmr = (float)Math.Round((10 * can_nang) + (6.25 * chieu_cao) - (5 * tuoi) + 5, 2);
			}
			else
			{
				bmr = (float)Math.Round((10 * can_nang) + (6.25 * chieu_cao) - (5 * tuoi) - 161, 2);
			}
			return bmr;
		}

		public static float chi_so_tdee(string gioi_tinh, float can_nang, float chieu_cao, int tuoi, double chi_so_van_dong)
		{
			float bmr = chi_so_bmr(gioi_tinh, can_nang, chieu_cao, tuoi); 
			return (float)Math.Round(bmr * chi_so_van_dong, 2);
		}

		public static float chi_so_whr(string gioi_tinh, float vong_eo, float vong_hong)
		{
			return (float)Math.Round((vong_eo / vong_hong), 2);
		}

		public static float chi_so_lbm(string gioi_tinh, float can_nang, float chieu_cao)
		{
			float chieu_cao_cm = chieu_cao * 100f;
			float lbm;
			if(gioi_tinh == "Nam")
			{
				lbm = (float)Math.Round(((0.32810 * can_nang) + (0.33929 * chieu_cao_cm) - 29.5336));
			} else
			{
				lbm = (float)Math.Round(((0.29569 * can_nang) + (0.41813 * chieu_cao_cm) - 43.2933));
			}
			return lbm;
		}

		public static float chi_so_ffmi(string gioi_tinh, float can_nang, float chieu_cao)
		{
			float lbm = chi_so_lbm(gioi_tinh, can_nang, chieu_cao);
			float ffmi = (float)Math.Round(lbm / (chieu_cao * chieu_cao), 2);
			return ffmi;
		}

		public static float chi_so_rfm(float vong_eo, float chieu_cao)
		{
			float chieu_cao_cm = chieu_cao * 100f;
			float rfm = (float)Math.Round((64 - (4 * (vong_eo / chieu_cao_cm))), 2);
			return rfm;
		}

		public static float chi_so_bfp(string gioi_tinh, float can_nang, float chieu_cao, int tuoi)
		{
			float bmi = chi_so_bmi(can_nang, chieu_cao);
			float bfp = 0;
			if(gioi_tinh == "Nam")
			{
				bfp = (float)Math.Round((1.20 * bmi) + (0.23 * tuoi) - 16.2, 2);
			}else
			{
				bfp = (float)Math.Round((1.20 * bmi) + (0.23 * tuoi) - 5.4, 2);    
			}
			return bfp;
		}

		public static float chi_so_bbw(float can_nang)
		{
			float luong_nuoc = (float)Math.Round(can_nang * 0.033, 2);
			return luong_nuoc;
		}

		public static float chi_so_ibw(string gioi_tinh, float chieu_cao)
		{
			float chieu_cao_cm = chieu_cao * 100f;
			float ibw = 0;
			if (gioi_tinh == "Nam")
			{
				ibw = (float)Math.Round(50 + 2.3 * ((chieu_cao_cm - 152.4) / 2.54), 2);
			}
			else
			{
				ibw = (float)Math.Round(45.5 + 2.3 * ((chieu_cao_cm - 152.4) / 2.54), 2);
			}
			return ibw;
		}

		public static float chi_so_ma(string gioi_tinh, float can_nang, float chieu_cao, int tuoi)
		{
			float bmr = chi_so_bmr(gioi_tinh, can_nang, chieu_cao, tuoi);
			var bmr_tb_nam = new (int min, int max, int tb)[] { (18, 30, 1900), (31, 50, 1800), (51, 70, 1700), (71, 150, 1600) };
			var bmr_tb_nu = new (int min, int max, int tb)[] { (18, 30, 1500), (31, 50, 1400), (51, 70, 1300), (71, 150, 1200) };
			var bang_bmr = gioi_tinh == "Nam" ? bmr_tb_nam : bmr_tb_nu;
			int bmr_tb = 0;
			foreach (var item in bang_bmr)
			{
				if (tuoi >= item.min && tuoi <= item.max)
				{
					bmr_tb = item.tb;
					break;
				}
			}
			float he_so_dieu_chinh = (bmr - bmr_tb) / 100f;
			return (int)Math.Round(tuoi - he_so_dieu_chinh);
		}

		public static float chi_so_vfr(float vong_eo, float vong_hong)
		{
			return (float)Math.Round(vong_eo / vong_hong, 2);
		}

		public static float chi_so_bsa(float chieu_cao, float can_nang)
		{
			float chieu_cao_cm = chieu_cao * 100f;
			return (float)Math.Round(Math.Sqrt((chieu_cao_cm * can_nang) / 3600f), 2);
		}

		public static float chi_so_vo2max(float nhip_tim_toi_da, float nhip_tim_nghi)
		{
			return 15f * (nhip_tim_toi_da / nhip_tim_nghi);
		}

		public static float chi_so_hsi(string gioi_tinh, float can_nang, float chieu_cao, int tuoi, float cholesterol, float huyet_ap)
		{
			float bmi = chi_so_bmi(can_nang, chieu_cao);
			float bfp = chi_so_bfp(gioi_tinh, can_nang, chieu_cao, tuoi);
			return (float)Math.Round((bmi * 0.4f + bfp * 0.3f + huyet_ap * 0.2f + cholesterol * 0.1f) / 4f, 2);
		}

		public static float chi_so_mmi(string gioi_tinh, float can_nang, float chieu_cao)
		{
			float ffmi = chi_so_ffmi(gioi_tinh, can_nang, chieu_cao);
			return (float)Math.Round(ffmi / can_nang, 2);
		}

		public static float chi_so_bfm(string gioi_tinh, float can_nang, float chieu_cao, int tuoi)
		{
			float bfp = chi_so_bfp(gioi_tinh, can_nang, chieu_cao, tuoi);
			return (float)Math.Round(can_nang * (bfp / 100f), 2);
		}
	}
}