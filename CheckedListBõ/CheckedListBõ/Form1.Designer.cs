namespace CheckedListBõ
{
    partial class Form1
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
            this.chklstLeft = new System.Windows.Forms.CheckedListBox();
            this.btnMoveOneFormLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveAllFromLeftToRight = new System.Windows.Forms.Button();
            this.btnMoveOneFromRightToLeft = new System.Windows.Forms.Button();
            this.btnMoveAllFromRightToLeft = new System.Windows.Forms.Button();
            this.chklstRight = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // chklstLeft
            // 
            this.chklstLeft.CheckOnClick = true;
            this.chklstLeft.FormattingEnabled = true;
            this.chklstLeft.Location = new System.Drawing.Point(15, 15);
            this.chklstLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chklstLeft.Name = "chklstLeft";
            this.chklstLeft.Size = new System.Drawing.Size(188, 277);
            this.chklstLeft.TabIndex = 0;
            // 
            // btnMoveOneFormLeftToRight
            // 
            this.btnMoveOneFormLeftToRight.Location = new System.Drawing.Point(234, 42);
            this.btnMoveOneFormLeftToRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveOneFormLeftToRight.Name = "btnMoveOneFormLeftToRight";
            this.btnMoveOneFormLeftToRight.Size = new System.Drawing.Size(112, 35);
            this.btnMoveOneFormLeftToRight.TabIndex = 1;
            this.btnMoveOneFormLeftToRight.Text = ">";
            this.btnMoveOneFormLeftToRight.UseVisualStyleBackColor = true;
            this.btnMoveOneFormLeftToRight.Click += new System.EventHandler(this.btnMoveOneFormLeftToRight_Click);
            // 
            // btnMoveAllFromLeftToRight
            // 
            this.btnMoveAllFromLeftToRight.Location = new System.Drawing.Point(234, 105);
            this.btnMoveAllFromLeftToRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveAllFromLeftToRight.Name = "btnMoveAllFromLeftToRight";
            this.btnMoveAllFromLeftToRight.Size = new System.Drawing.Size(112, 35);
            this.btnMoveAllFromLeftToRight.TabIndex = 1;
            this.btnMoveAllFromLeftToRight.Text = ">>";
            this.btnMoveAllFromLeftToRight.UseVisualStyleBackColor = true;
            this.btnMoveAllFromLeftToRight.Click += new System.EventHandler(this.btnMoveAllFromLeftToRight_Click);
            // 
            // btnMoveOneFromRightToLeft
            // 
            this.btnMoveOneFromRightToLeft.Location = new System.Drawing.Point(234, 165);
            this.btnMoveOneFromRightToLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveOneFromRightToLeft.Name = "btnMoveOneFromRightToLeft";
            this.btnMoveOneFromRightToLeft.Size = new System.Drawing.Size(112, 35);
            this.btnMoveOneFromRightToLeft.TabIndex = 1;
            this.btnMoveOneFromRightToLeft.Text = "<";
            this.btnMoveOneFromRightToLeft.UseVisualStyleBackColor = true;
            this.btnMoveOneFromRightToLeft.Click += new System.EventHandler(this.btnMoveOneFromRightToLeft_Click);
            // 
            // btnMoveAllFromRightToLeft
            // 
            this.btnMoveAllFromRightToLeft.Location = new System.Drawing.Point(234, 225);
            this.btnMoveAllFromRightToLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoveAllFromRightToLeft.Name = "btnMoveAllFromRightToLeft";
            this.btnMoveAllFromRightToLeft.Size = new System.Drawing.Size(112, 35);
            this.btnMoveAllFromRightToLeft.TabIndex = 1;
            this.btnMoveAllFromRightToLeft.Text = "<<";
            this.btnMoveAllFromRightToLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllFromRightToLeft.Click += new System.EventHandler(this.btnMoveAllFromRightToLeft_Click);
            // 
            // chklstRight
            // 
            this.chklstRight.CheckOnClick = true;
            this.chklstRight.FormattingEnabled = true;
            this.chklstRight.Location = new System.Drawing.Point(378, 15);
            this.chklstRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chklstRight.Name = "chklstRight";
            this.chklstRight.Size = new System.Drawing.Size(188, 277);
            this.chklstRight.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 338);
            this.Controls.Add(this.btnMoveAllFromRightToLeft);
            this.Controls.Add(this.btnMoveOneFromRightToLeft);
            this.Controls.Add(this.btnMoveAllFromLeftToRight);
            this.Controls.Add(this.btnMoveOneFormLeftToRight);
            this.Controls.Add(this.chklstRight);
            this.Controls.Add(this.chklstLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklstLeft;
        private System.Windows.Forms.Button btnMoveOneFormLeftToRight;
        private System.Windows.Forms.Button btnMoveAllFromLeftToRight;
        private System.Windows.Forms.Button btnMoveOneFromRightToLeft;
        private System.Windows.Forms.Button btnMoveAllFromRightToLeft;
        private System.Windows.Forms.CheckedListBox chklstRight;
    }
}

