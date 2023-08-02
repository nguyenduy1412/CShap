namespace Cau4TH02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lstTrai = new System.Windows.Forms.ListBox();
            this.lstPhai = new System.Windows.Forms.ListBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnPhaiPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnTraiTrai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(92, 29);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(205, 23);
            this.txtTenMon.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(327, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lstTrai
            // 
            this.lstTrai.FormattingEnabled = true;
            this.lstTrai.ItemHeight = 15;
            this.lstTrai.Items.AddRange(new object[] {
            "Khai vị",
            "Tôm hấp bia",
            "Lẩu hải sản",
            "Trái cây"});
            this.lstTrai.Location = new System.Drawing.Point(18, 74);
            this.lstTrai.Name = "lstTrai";
            this.lstTrai.Size = new System.Drawing.Size(146, 199);
            this.lstTrai.TabIndex = 3;
            // 
            // lstPhai
            // 
            this.lstPhai.FormattingEnabled = true;
            this.lstPhai.ItemHeight = 15;
            this.lstPhai.Location = new System.Drawing.Point(256, 74);
            this.lstPhai.Name = "lstPhai";
            this.lstPhai.Size = new System.Drawing.Size(146, 199);
            this.lstPhai.TabIndex = 4;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(184, 86);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(56, 23);
            this.btnPhai.TabIndex = 5;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnPhaiPhai
            // 
            this.btnPhaiPhai.Location = new System.Drawing.Point(184, 131);
            this.btnPhaiPhai.Name = "btnPhaiPhai";
            this.btnPhaiPhai.Size = new System.Drawing.Size(56, 23);
            this.btnPhaiPhai.TabIndex = 5;
            this.btnPhaiPhai.Text = ">>";
            this.btnPhaiPhai.UseVisualStyleBackColor = true;
            this.btnPhaiPhai.Click += new System.EventHandler(this.btnPhaiPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(184, 172);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(56, 23);
            this.btnTrai.TabIndex = 5;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnTraiTrai
            // 
            this.btnTraiTrai.Location = new System.Drawing.Point(184, 215);
            this.btnTraiTrai.Name = "btnTraiTrai";
            this.btnTraiTrai.Size = new System.Drawing.Size(56, 23);
            this.btnTraiTrai.TabIndex = 5;
            this.btnTraiTrai.Text = "<<";
            this.btnTraiTrai.UseVisualStyleBackColor = true;
            this.btnTraiTrai.Click += new System.EventHandler(this.btnTraiTrai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 309);
            this.Controls.Add(this.btnTraiTrai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhaiPhai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.lstPhai);
            this.Controls.Add(this.lstTrai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thực đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTenMon;
        private Button btnThem;
        private ListBox lstTrai;
        private ListBox lstPhai;
        private Button btnPhai;
        private Button btnPhaiPhai;
        private Button btnTrai;
        private Button btnTraiTrai;
    }
}