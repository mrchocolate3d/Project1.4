namespace ChapeauUI
{
    partial class HomePage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_OrderView = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_employeeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 137);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tables";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 137);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kitchen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_OrderView
            // 
            this.btn_OrderView.Location = new System.Drawing.Point(246, 172);
            this.btn_OrderView.Name = "btn_OrderView";
            this.btn_OrderView.Size = new System.Drawing.Size(142, 137);
            this.btn_OrderView.TabIndex = 3;
            this.btn_OrderView.Text = "Menu";
            this.btn_OrderView.UseVisualStyleBackColor = true;
            this.btn_OrderView.Click += new System.EventHandler(this.btn_OrderView_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 137);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ongoing";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_employeeName
            // 
            this.lbl_employeeName.AutoSize = true;
            this.lbl_employeeName.Location = new System.Drawing.Point(219, 82);
            this.lbl_employeeName.Name = "lbl_employeeName";
            this.lbl_employeeName.Size = new System.Drawing.Size(25, 13);
            this.lbl_employeeName.TabIndex = 5;
            this.lbl_employeeName.Text = "------";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 535);
            this.Controls.Add(this.lbl_employeeName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_OrderView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_OrderView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_employeeName;
    }
}