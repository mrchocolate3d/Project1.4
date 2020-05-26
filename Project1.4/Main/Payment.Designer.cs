namespace ChapeauUI
{
    partial class Payment
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
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtncash = new System.Windows.Forms.RadioButton();
            this.radiobtnpin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Billing";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(282, 130);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(39, 20);
            this.lbltotalamount.TabIndex = 3;
            this.lbltotalamount.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plus the Added Tip.";
            // 
            // radiobtncash
            // 
            this.radiobtncash.AutoSize = true;
            this.radiobtncash.Location = new System.Drawing.Point(91, 32);
            this.radiobtncash.Name = "radiobtncash";
            this.radiobtncash.Size = new System.Drawing.Size(109, 21);
            this.radiobtncash.TabIndex = 6;
            this.radiobtncash.TabStop = true;
            this.radiobtncash.Text = "Pay By Cash";
            this.radiobtncash.UseVisualStyleBackColor = true;
            // 
            // radiobtnpin
            // 
            this.radiobtnpin.AutoSize = true;
            this.radiobtnpin.Location = new System.Drawing.Point(428, 32);
            this.radiobtnpin.Name = "radiobtnpin";
            this.radiobtnpin.Size = new System.Drawing.Size(97, 21);
            this.radiobtnpin.TabIndex = 7;
            this.radiobtnpin.TabStop = true;
            this.radiobtnpin.Text = "Pay By Pin";
            this.radiobtnpin.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 264);
            this.Controls.Add(this.radiobtnpin);
            this.Controls.Add(this.radiobtncash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtncash;
        private System.Windows.Forms.RadioButton radiobtnpin;
    }
}