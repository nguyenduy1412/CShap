namespace NguyenNgocDuy
{
    partial class Bai5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.grbKetqua = new System.Windows.Forms.GroupBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.grbKetqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào số nguyên N";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(239, 27);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 23);
            this.txtSo.TabIndex = 1;
            this.txtSo.TextChanged += new System.EventHandler(this.txtSo_TextChanged);
            // 
            // grbKetqua
            // 
            this.grbKetqua.Controls.Add(this.txtKQ);
            this.grbKetqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbKetqua.ForeColor = System.Drawing.Color.Blue;
            this.grbKetqua.Location = new System.Drawing.Point(27, 94);
            this.grbKetqua.Name = "grbKetqua";
            this.grbKetqua.Size = new System.Drawing.Size(312, 100);
            this.grbKetqua.TabIndex = 2;
            this.grbKetqua.TabStop = false;
            this.grbKetqua.Text = "Kết quả đọc số";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(12, 22);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(294, 72);
            this.txtKQ.TabIndex = 0;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 232);
            this.Controls.Add(this.grbKetqua);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.grbKetqua.ResumeLayout(false);
            this.grbKetqua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSo;
        private GroupBox grbKetqua;
        private TextBox txtKQ;
    }
}