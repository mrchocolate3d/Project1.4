namespace ChapeauUI
{
    partial class Reciept
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
            this.btnpayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltablenumber = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblnettotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpayment
            // 
            this.btnpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.Location = new System.Drawing.Point(328, 379);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(225, 45);
            this.btnpayment.TabIndex = 1;
            this.btnpayment.Text = " Proceed to payment";
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurant Chapeau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server:";
            // 
            // lbltablenumber
            // 
            this.lbltablenumber.AutoSize = true;
            this.lbltablenumber.Location = new System.Drawing.Point(132, 85);
            this.lbltablenumber.Name = "lbltablenumber";
            this.lbltablenumber.Size = new System.Drawing.Size(38, 17);
            this.lbltablenumber.TabIndex = 5;
            this.lbltablenumber.Text = "------";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(398, 85);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(38, 17);
            this.lblserver.TabIndex = 6;
            this.lblserver.Text = "------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu Items";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = " TOTAL:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(367, 281);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(43, 17);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "-------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = " VAT: ";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(367, 310);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(43, 17);
            this.lblvat.TabIndex = 13;
            this.lblvat.Text = "-------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Net Total:";
            // 
            // lblnettotal
            // 
            this.lblnettotal.AutoSize = true;
            this.lblnettotal.Location = new System.Drawing.Point(367, 338);
            this.lblnettotal.Name = "lblnettotal";
            this.lblnettotal.Size = new System.Drawing.Size(43, 17);
            this.lblnettotal.TabIndex = 15;
            this.lblnettotal.Text = "-------";
            // 
            // Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 430);
            this.Controls.Add(this.lblnettotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblserver);
            this.Controls.Add(this.lbltablenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpayment);
            this.Name = "Reciept";
            this.Text = "Reciept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltablenumber;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblnettotal;
    }
}