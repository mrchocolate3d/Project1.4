namespace ChapeauUI
{
    partial class LoginPage
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
            this.roundButton1 = new ChapeauUI.RoundButton();
            this.roundButton2 = new ChapeauUI.RoundButton();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(276, 110);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(75, 23);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // roundButton2
            // 
            this.roundButton2.Location = new System.Drawing.Point(543, 230);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(75, 23);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "roundButton2";
            this.roundButton2.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton roundButton1;
        private RoundButton roundButton2;
    }
}