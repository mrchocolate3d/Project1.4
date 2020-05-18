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
            this.btncreditcard = new System.Windows.Forms.Button();
            this.btncash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncreditcard
            // 
            this.btncreditcard.Location = new System.Drawing.Point(12, 153);
            this.btncreditcard.Name = "btncreditcard";
            this.btncreditcard.Size = new System.Drawing.Size(294, 65);
            this.btncreditcard.TabIndex = 0;
            this.btncreditcard.Text = "Pay By Credit Card";
            this.btncreditcard.UseVisualStyleBackColor = true;
            this.btncreditcard.Click += new System.EventHandler(this.btncreditcard_Click);
            // 
            // btncash
            // 
            this.btncash.Location = new System.Drawing.Point(359, 153);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(294, 65);
            this.btncash.TabIndex = 1;
            this.btncash.Text = "Pay by Cash.";
            this.btncash.UseVisualStyleBackColor = true;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Billing";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.Location = new System.Drawing.Point(235, 35);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(39, 20);
            this.lbltotalamount.TabIndex = 3;
            this.lbltotalamount.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plus the Added Tip.";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncash);
            this.Controls.Add(this.btncreditcard);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreditcard;
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label label2;
    }
}