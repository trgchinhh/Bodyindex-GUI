namespace WindowsFormsApp1
{
    partial class FrmForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForm1));
            this.CB_Nam = new System.Windows.Forms.CheckBox();
            this.CB_Nu = new System.Windows.Forms.CheckBox();
            this.LB_Gioitinh = new System.Windows.Forms.Label();
            this.DT_Ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.LB_Ngaysinh = new System.Windows.Forms.Label();
            this.CB_Khac = new System.Windows.Forms.CheckBox();
            this.LB_Hoten = new System.Windows.Forms.Label();
            this.TB_Hoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Chieucao = new System.Windows.Forms.Label();
            this.TB_Chieucao = new System.Windows.Forms.TextBox();
            this.LB_Donvichieucao = new System.Windows.Forms.Label();
            this.LB_Cannang = new System.Windows.Forms.Label();
            this.TB_Cannang = new System.Windows.Forms.TextBox();
            this.LB_Donvicannang = new System.Windows.Forms.Label();
            this.LB_Chisovandong = new System.Windows.Forms.Label();
            this.CBB_Chisovandong = new System.Windows.Forms.ComboBox();
            this.LB_Tieudenhap = new System.Windows.Forms.Label();
            this.LB_Nhommau = new System.Windows.Forms.Label();
            this.CBB_Nhommau = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Vongeo = new System.Windows.Forms.Label();
            this.LB_Vonghong = new System.Windows.Forms.Label();
            this.TB_Vongeo = new System.Windows.Forms.TextBox();
            this.TB_Vonghong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_Nhiptimtoida = new System.Windows.Forms.Label();
            this.LB_Nhiptimnghi = new System.Windows.Forms.Label();
            this.TB_Nhiptimtoida = new System.Windows.Forms.TextBox();
            this.TB_Nhiptimnghi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Huyetap = new System.Windows.Forms.TextBox();
            this.TB_Cholestero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Nam
            // 
            this.CB_Nam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CB_Nam.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Nam.Location = new System.Drawing.Point(365, 163);
            this.CB_Nam.Name = "CB_Nam";
            this.CB_Nam.Size = new System.Drawing.Size(101, 30);
            this.CB_Nam.TabIndex = 0;
            this.CB_Nam.Text = "Nam";
            this.CB_Nam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_Nam.UseVisualStyleBackColor = false;
            this.CB_Nam.CheckedChanged += new System.EventHandler(this.CB_Nam_CheckedChanged);
            // 
            // CB_Nu
            // 
            this.CB_Nu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CB_Nu.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Nu.Location = new System.Drawing.Point(525, 162);
            this.CB_Nu.Name = "CB_Nu";
            this.CB_Nu.Size = new System.Drawing.Size(101, 30);
            this.CB_Nu.TabIndex = 1;
            this.CB_Nu.Text = "Nữ";
            this.CB_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_Nu.UseVisualStyleBackColor = false;
            this.CB_Nu.CheckedChanged += new System.EventHandler(this.CB_Nu_CheckedChanged);
            // 
            // LB_Gioitinh
            // 
            this.LB_Gioitinh.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Gioitinh.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gioitinh.Location = new System.Drawing.Point(213, 163);
            this.LB_Gioitinh.Name = "LB_Gioitinh";
            this.LB_Gioitinh.Size = new System.Drawing.Size(116, 30);
            this.LB_Gioitinh.TabIndex = 2;
            this.LB_Gioitinh.Text = "Giới tính";
            this.LB_Gioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DT_Ngaysinh
            // 
            this.DT_Ngaysinh.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.DT_Ngaysinh.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_Ngaysinh.Location = new System.Drawing.Point(365, 235);
            this.DT_Ngaysinh.Name = "DT_Ngaysinh";
            this.DT_Ngaysinh.Size = new System.Drawing.Size(418, 30);
            this.DT_Ngaysinh.TabIndex = 3;
            this.DT_Ngaysinh.ValueChanged += new System.EventHandler(this.DT_Ngaysinh_ValueChanged);
            // 
            // LB_Ngaysinh
            // 
            this.LB_Ngaysinh.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Ngaysinh.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Ngaysinh.Location = new System.Drawing.Point(213, 237);
            this.LB_Ngaysinh.Name = "LB_Ngaysinh";
            this.LB_Ngaysinh.Size = new System.Drawing.Size(116, 30);
            this.LB_Ngaysinh.TabIndex = 4;
            this.LB_Ngaysinh.Text = "Ngày Sinh";
            this.LB_Ngaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Khac
            // 
            this.CB_Khac.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CB_Khac.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Khac.Location = new System.Drawing.Point(682, 162);
            this.CB_Khac.Name = "CB_Khac";
            this.CB_Khac.Size = new System.Drawing.Size(101, 30);
            this.CB_Khac.TabIndex = 5;
            this.CB_Khac.Text = "Khác";
            this.CB_Khac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_Khac.UseVisualStyleBackColor = false;
            this.CB_Khac.CheckedChanged += new System.EventHandler(this.CB_Khac_CheckedChanged);
            // 
            // LB_Hoten
            // 
            this.LB_Hoten.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Hoten.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Hoten.Location = new System.Drawing.Point(213, 89);
            this.LB_Hoten.Name = "LB_Hoten";
            this.LB_Hoten.Size = new System.Drawing.Size(116, 30);
            this.LB_Hoten.TabIndex = 6;
            this.LB_Hoten.Text = "Họ Tên";
            this.LB_Hoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Hoten.Click += new System.EventHandler(this.LB_Hoten_Click);
            // 
            // TB_Hoten
            // 
            this.TB_Hoten.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Hoten.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Hoten.Location = new System.Drawing.Point(365, 89);
            this.TB_Hoten.Name = "TB_Hoten";
            this.TB_Hoten.Size = new System.Drawing.Size(418, 30);
            this.TB_Hoten.TabIndex = 7;
            this.TB_Hoten.TextChanged += new System.EventHandler(this.TB_Hoten_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // LB_Chieucao
            // 
            this.LB_Chieucao.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Chieucao.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Chieucao.Location = new System.Drawing.Point(25, 309);
            this.LB_Chieucao.Name = "LB_Chieucao";
            this.LB_Chieucao.Size = new System.Drawing.Size(116, 30);
            this.LB_Chieucao.TabIndex = 9;
            this.LB_Chieucao.Text = "Chiều cao";
            this.LB_Chieucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Chieucao
            // 
            this.TB_Chieucao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Chieucao.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Chieucao.Location = new System.Drawing.Point(217, 308);
            this.TB_Chieucao.Name = "TB_Chieucao";
            this.TB_Chieucao.Size = new System.Drawing.Size(140, 30);
            this.TB_Chieucao.TabIndex = 10;
            this.TB_Chieucao.TextChanged += new System.EventHandler(this.TB_Chieucao_TextChanged);
            // 
            // LB_Donvichieucao
            // 
            this.LB_Donvichieucao.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Donvichieucao.Location = new System.Drawing.Point(310, 309);
            this.LB_Donvichieucao.Name = "LB_Donvichieucao";
            this.LB_Donvichieucao.Size = new System.Drawing.Size(47, 28);
            this.LB_Donvichieucao.TabIndex = 11;
            this.LB_Donvichieucao.Text = "cm";
            this.LB_Donvichieucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Cannang
            // 
            this.LB_Cannang.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Cannang.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cannang.Location = new System.Drawing.Point(456, 308);
            this.LB_Cannang.Name = "LB_Cannang";
            this.LB_Cannang.Size = new System.Drawing.Size(116, 30);
            this.LB_Cannang.TabIndex = 13;
            this.LB_Cannang.Text = "Cân nặng";
            this.LB_Cannang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Cannang.Click += new System.EventHandler(this.LB_Cannang_Click);
            // 
            // TB_Cannang
            // 
            this.TB_Cannang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Cannang.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Cannang.Location = new System.Drawing.Point(634, 309);
            this.TB_Cannang.Name = "TB_Cannang";
            this.TB_Cannang.Size = new System.Drawing.Size(149, 30);
            this.TB_Cannang.TabIndex = 14;
            this.TB_Cannang.TextChanged += new System.EventHandler(this.TB_Cannang_TextChanged);
            // 
            // LB_Donvicannang
            // 
            this.LB_Donvicannang.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Donvicannang.Location = new System.Drawing.Point(736, 309);
            this.LB_Donvicannang.Name = "LB_Donvicannang";
            this.LB_Donvicannang.Size = new System.Drawing.Size(47, 28);
            this.LB_Donvicannang.TabIndex = 15;
            this.LB_Donvicannang.Text = "kg";
            this.LB_Donvicannang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Chisovandong
            // 
            this.LB_Chisovandong.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Chisovandong.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Chisovandong.Location = new System.Drawing.Point(25, 371);
            this.LB_Chisovandong.Name = "LB_Chisovandong";
            this.LB_Chisovandong.Size = new System.Drawing.Size(171, 30);
            this.LB_Chisovandong.TabIndex = 16;
            this.LB_Chisovandong.Text = "Chỉ số vận động";
            this.LB_Chisovandong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Chisovandong.Click += new System.EventHandler(this.LB_Chisovandong_Click);
            // 
            // CBB_Chisovandong
            // 
            this.CBB_Chisovandong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CBB_Chisovandong.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Chisovandong.FormattingEnabled = true;
            this.CBB_Chisovandong.Items.AddRange(new object[] {
            "Ít vận động",
            "Vận động nhẹ",
            "Vận động vừa",
            "Vận động nhiều",
            "Vận động rất nhiều"});
            this.CBB_Chisovandong.Location = new System.Drawing.Point(217, 371);
            this.CBB_Chisovandong.Name = "CBB_Chisovandong";
            this.CBB_Chisovandong.Size = new System.Drawing.Size(219, 30);
            this.CBB_Chisovandong.TabIndex = 17;
            this.CBB_Chisovandong.SelectedIndexChanged += new System.EventHandler(this.CBB_Chisovandong_SelectedIndexChanged);
            // 
            // LB_Tieudenhap
            // 
            this.LB_Tieudenhap.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Tieudenhap.Font = new System.Drawing.Font("JetBrains Mono NL", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tieudenhap.Location = new System.Drawing.Point(285, 9);
            this.LB_Tieudenhap.Name = "LB_Tieudenhap";
            this.LB_Tieudenhap.Size = new System.Drawing.Size(293, 43);
            this.LB_Tieudenhap.TabIndex = 18;
            this.LB_Tieudenhap.Text = "NHẬP THÔNG TIN";
            this.LB_Tieudenhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Tieudenhap.Click += new System.EventHandler(this.LB_Tieudenhap_Click);
            // 
            // LB_Nhommau
            // 
            this.LB_Nhommau.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Nhommau.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nhommau.Location = new System.Drawing.Point(25, 430);
            this.LB_Nhommau.Name = "LB_Nhommau";
            this.LB_Nhommau.Size = new System.Drawing.Size(116, 30);
            this.LB_Nhommau.TabIndex = 19;
            this.LB_Nhommau.Text = "Nhóm máu";
            this.LB_Nhommau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBB_Nhommau
            // 
            this.CBB_Nhommau.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CBB_Nhommau.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBB_Nhommau.FormattingEnabled = true;
            this.CBB_Nhommau.Items.AddRange(new object[] {
            "Nhóm máu A",
            "Nhóm máu B",
            "Nhóm máu AB",
            "Nhóm máu O"});
            this.CBB_Nhommau.Location = new System.Drawing.Point(217, 431);
            this.CBB_Nhommau.Name = "CBB_Nhommau";
            this.CBB_Nhommau.Size = new System.Drawing.Size(140, 30);
            this.CBB_Nhommau.TabIndex = 20;
            this.CBB_Nhommau.SelectedIndexChanged += new System.EventHandler(this.CBB_Nhommau_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono NL", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 67);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tính chỉ số ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 193);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LB_Vongeo
            // 
            this.LB_Vongeo.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Vongeo.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Vongeo.Location = new System.Drawing.Point(25, 488);
            this.LB_Vongeo.Name = "LB_Vongeo";
            this.LB_Vongeo.Size = new System.Drawing.Size(116, 30);
            this.LB_Vongeo.TabIndex = 23;
            this.LB_Vongeo.Text = "Vòng eo ";
            this.LB_Vongeo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Vonghong
            // 
            this.LB_Vonghong.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Vonghong.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Vonghong.Location = new System.Drawing.Point(456, 486);
            this.LB_Vonghong.Name = "LB_Vonghong";
            this.LB_Vonghong.Size = new System.Drawing.Size(116, 30);
            this.LB_Vonghong.TabIndex = 24;
            this.LB_Vonghong.Text = "Vòng hông ";
            this.LB_Vonghong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Vongeo
            // 
            this.TB_Vongeo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Vongeo.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Vongeo.Location = new System.Drawing.Point(217, 487);
            this.TB_Vongeo.Name = "TB_Vongeo";
            this.TB_Vongeo.Size = new System.Drawing.Size(140, 30);
            this.TB_Vongeo.TabIndex = 25;
            this.TB_Vongeo.TextChanged += new System.EventHandler(this.TB_Vongeo_TextChanged);
            // 
            // TB_Vonghong
            // 
            this.TB_Vonghong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Vonghong.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Vonghong.Location = new System.Drawing.Point(634, 484);
            this.TB_Vonghong.Name = "TB_Vonghong";
            this.TB_Vonghong.Size = new System.Drawing.Size(149, 30);
            this.TB_Vonghong.TabIndex = 26;
            this.TB_Vonghong.TextChanged += new System.EventHandler(this.TB_Vonghong_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "cm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "cm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Nhiptimtoida
            // 
            this.LB_Nhiptimtoida.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Nhiptimtoida.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nhiptimtoida.Location = new System.Drawing.Point(25, 545);
            this.LB_Nhiptimtoida.Name = "LB_Nhiptimtoida";
            this.LB_Nhiptimtoida.Size = new System.Drawing.Size(171, 30);
            this.LB_Nhiptimtoida.TabIndex = 29;
            this.LB_Nhiptimtoida.Text = "Nhịp tim tối đa";
            this.LB_Nhiptimtoida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Nhiptimtoida.Click += new System.EventHandler(this.label4_Click);
            // 
            // LB_Nhiptimnghi
            // 
            this.LB_Nhiptimnghi.BackColor = System.Drawing.SystemColors.Info;
            this.LB_Nhiptimnghi.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nhiptimnghi.Location = new System.Drawing.Point(455, 545);
            this.LB_Nhiptimnghi.Name = "LB_Nhiptimnghi";
            this.LB_Nhiptimnghi.Size = new System.Drawing.Size(158, 30);
            this.LB_Nhiptimnghi.TabIndex = 30;
            this.LB_Nhiptimnghi.Text = "Nhịp tim nghỉ";
            this.LB_Nhiptimnghi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Nhiptimtoida
            // 
            this.TB_Nhiptimtoida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Nhiptimtoida.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nhiptimtoida.Location = new System.Drawing.Point(217, 545);
            this.TB_Nhiptimtoida.Name = "TB_Nhiptimtoida";
            this.TB_Nhiptimtoida.Size = new System.Drawing.Size(140, 30);
            this.TB_Nhiptimtoida.TabIndex = 31;
            this.TB_Nhiptimtoida.TextChanged += new System.EventHandler(this.TB_Nhiptimtoida_TextChanged);
            // 
            // TB_Nhiptimnghi
            // 
            this.TB_Nhiptimnghi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Nhiptimnghi.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nhiptimnghi.Location = new System.Drawing.Point(634, 546);
            this.TB_Nhiptimnghi.Name = "TB_Nhiptimnghi";
            this.TB_Nhiptimnghi.Size = new System.Drawing.Size(149, 30);
            this.TB_Nhiptimnghi.TabIndex = 32;
            this.TB_Nhiptimnghi.TextChanged += new System.EventHandler(this.TB_Nhiptimnghi_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Huyết áp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Huyetap
            // 
            this.TB_Huyetap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Huyetap.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Huyetap.Location = new System.Drawing.Point(634, 372);
            this.TB_Huyetap.Name = "TB_Huyetap";
            this.TB_Huyetap.Size = new System.Drawing.Size(149, 30);
            this.TB_Huyetap.TabIndex = 35;
            this.TB_Huyetap.TextChanged += new System.EventHandler(this.TB_Huyetap_TextChanged);
            // 
            // TB_Cholestero
            // 
            this.TB_Cholestero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_Cholestero.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Cholestero.Location = new System.Drawing.Point(634, 430);
            this.TB_Cholestero.Name = "TB_Cholestero";
            this.TB_Cholestero.Size = new System.Drawing.Size(149, 30);
            this.TB_Cholestero.TabIndex = 36;
            this.TB_Cholestero.TextChanged += new System.EventHandler(this.TB_Cholestero_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(717, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "mmHg";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 28);
            this.label7.TabIndex = 38;
            this.label7.Text = "mg/dL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "bpm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(736, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 28);
            this.label9.TabIndex = 40;
            this.label9.Text = "bpm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono NL", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cholesterol";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(841, 667);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Cholestero);
            this.Controls.Add(this.TB_Huyetap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Nhiptimnghi);
            this.Controls.Add(this.TB_Nhiptimtoida);
            this.Controls.Add(this.LB_Nhiptimnghi);
            this.Controls.Add(this.LB_Nhiptimtoida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Vonghong);
            this.Controls.Add(this.TB_Vongeo);
            this.Controls.Add(this.LB_Vonghong);
            this.Controls.Add(this.LB_Vongeo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBB_Nhommau);
            this.Controls.Add(this.LB_Nhommau);
            this.Controls.Add(this.LB_Tieudenhap);
            this.Controls.Add(this.CBB_Chisovandong);
            this.Controls.Add(this.LB_Chisovandong);
            this.Controls.Add(this.LB_Donvicannang);
            this.Controls.Add(this.TB_Cannang);
            this.Controls.Add(this.LB_Cannang);
            this.Controls.Add(this.LB_Donvichieucao);
            this.Controls.Add(this.TB_Chieucao);
            this.Controls.Add(this.LB_Chieucao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Hoten);
            this.Controls.Add(this.LB_Hoten);
            this.Controls.Add(this.CB_Khac);
            this.Controls.Add(this.LB_Ngaysinh);
            this.Controls.Add(this.DT_Ngaysinh);
            this.Controls.Add(this.LB_Gioitinh);
            this.Controls.Add(this.CB_Nu);
            this.Controls.Add(this.CB_Nam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmForm1";
            this.Text = "Tính chỉ số cơ thể ";
            this.Load += new System.EventHandler(this.FrmForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Nam;
        private System.Windows.Forms.CheckBox CB_Nu;
        private System.Windows.Forms.Label LB_Gioitinh;
        private System.Windows.Forms.DateTimePicker DT_Ngaysinh;
        private System.Windows.Forms.Label LB_Ngaysinh;
        private System.Windows.Forms.CheckBox CB_Khac;
        private System.Windows.Forms.Label LB_Hoten;
        private System.Windows.Forms.TextBox TB_Hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Chieucao;
        private System.Windows.Forms.TextBox TB_Chieucao;
        private System.Windows.Forms.Label LB_Donvichieucao;
        private System.Windows.Forms.Label LB_Cannang;
        private System.Windows.Forms.TextBox TB_Cannang;
        private System.Windows.Forms.Label LB_Donvicannang;
        private System.Windows.Forms.Label LB_Chisovandong;
        private System.Windows.Forms.ComboBox CBB_Chisovandong;
        private System.Windows.Forms.Label LB_Tieudenhap;
        private System.Windows.Forms.Label LB_Nhommau;
        private System.Windows.Forms.ComboBox CBB_Nhommau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_Vongeo;
        private System.Windows.Forms.Label LB_Vonghong;
        private System.Windows.Forms.TextBox TB_Vongeo;
        private System.Windows.Forms.TextBox TB_Vonghong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_Nhiptimtoida;
        private System.Windows.Forms.Label LB_Nhiptimnghi;
        private System.Windows.Forms.TextBox TB_Nhiptimtoida;
        private System.Windows.Forms.TextBox TB_Nhiptimnghi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Huyetap;
        private System.Windows.Forms.TextBox TB_Cholestero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
    }
}

