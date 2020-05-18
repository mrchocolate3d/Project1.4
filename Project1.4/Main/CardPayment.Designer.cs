namespace ChapeauUI
{
    partial class CardPayment
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
            this.lblcardnumber = new System.Windows.Forms.Label();
            this.lblpasnumber = new System.Windows.Forms.Label();
            this.txtcardnumber = new System.Windows.Forms.TextBox();
            this.txtpasnumber = new System.Windows.Forms.TextBox();
            this.lblexpire = new System.Windows.Forms.Label();
            this.txtdateofexpire = new System.Windows.Forms.TextBox();
            this.btnconfirmpayement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcardnumber
            // 
            this.lblcardnumber.AutoSize = true;
            this.lblcardnumber.Location = new System.Drawing.Point(64, 45);
            this.lblcardnumber.Name = "lblcardnumber";
            this.lblcardnumber.Size = new System.Drawing.Size(134, 17);
            this.lblcardnumber.TabIndex = 0;
            this.lblcardnumber.Text = "Enter Card Number:";
            // 
            // lblpasnumber
            // 
            this.lblpasnumber.AutoSize = true;
            this.lblpasnumber.Location = new System.Drawing.Point(64, 80);
            this.lblpasnumber.Name = "lblpasnumber";
            this.lblpasnumber.Size = new System.Drawing.Size(90, 17);
            this.lblpasnumber.TabIndex = 1;
            this.lblpasnumber.Text = "Pas Number:";
            // 
            // txtcardnumber
            // 
            this.txtcardnumber.Location = new System.Drawing.Point(214, 45);
            this.txtcardnumber.Name = "txtcardnumber";
            this.txtcardnumber.Size = new System.Drawing.Size(139, 22);
            this.txtcardnumber.TabIndex = 2;
            // 
            // txtpasnumber
            // 
            this.txtpasnumber.Location = new System.Drawing.Point(214, 80);
            this.txtpasnumber.Name = "txtpasnumber";
            this.txtpasnumber.Size = new System.Drawing.Size(139, 22);
            this.txtpasnumber.TabIndex = 3;
            // 
            // lblexpire
            // 
            this.lblexpire.AutoSize = true;
            this.lblexpire.Location = new System.Drawing.Point(64, 121);
            this.lblexpire.Name = "lblexpire";
            this.lblexpire.Size = new System.Drawing.Size(104, 17);
            this.lblexpire.TabIndex = 4;
            this.lblexpire.Text = "Date Of Expire:";
            // 
            // txtdateofexpire
            // 
            this.txtdateofexpire.Location = new System.Drawing.Point(214, 121);
            this.txtdateofexpire.Name = "txtdateofexpire";
            this.txtdateofexpire.Size = new System.Drawing.Size(139, 22);
            this.txtdateofexpire.TabIndex = 5;
            // 
            // btnconfirmpayement
            // 
            this.btnconfirmpayement.Location = new System.Drawing.Point(108, 184);
            this.btnconfirmpayement.Name = "btnconfirmpayement";
            this.btnconfirmpayement.Size = new System.Drawing.Size(245, 57);
            this.btnconfirmpayement.TabIndex = 6;
            this.btnconfirmpayement.Text = "Confirm Payement";
            this.btnconfirmpayement.UseVisualStyleBackColor = true;
            this.btnconfirmpayement.Click += new System.EventHandler(this.btnconfirmpayement_Click);
            // 
            // CardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 280);
            this.Controls.Add(this.btnconfirmpayement);
            this.Controls.Add(this.txtdateofexpire);
            this.Controls.Add(this.lblexpire);
            this.Controls.Add(this.txtpasnumber);
            this.Controls.Add(this.txtcardnumber);
            this.Controls.Add(this.lblpasnumber);
            this.Controls.Add(this.lblcardnumber);
            this.Name = "CardPayment";
            this.Text = "CardPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcardnumber;
        private System.Windows.Forms.Label lblpasnumber;
        private System.Windows.Forms.TextBox txtcardnumber;
        private System.Windows.Forms.TextBox txtpasnumber;
        private System.Windows.Forms.Label lblexpire;
        private System.Windows.Forms.TextBox txtdateofexpire;
        private System.Windows.Forms.Button btnconfirmpayement;
    }
}