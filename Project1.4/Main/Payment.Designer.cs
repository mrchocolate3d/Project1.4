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
            this.pnlpayment = new System.Windows.Forms.Panel();
            this.btnpay = new System.Windows.Forms.Button();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltablenumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtncash = new System.Windows.Forms.RadioButton();
            this.radiobtnpin = new System.Windows.Forms.RadioButton();
            this.listViewrecipt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnprintrecipt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.pnlpayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Chapeau";
            // 
            // pnlpayment
            // 
            this.pnlpayment.Controls.Add(this.lbltotalamount);
            this.pnlpayment.Controls.Add(this.label7);
            this.pnlpayment.Controls.Add(this.txttip);
            this.pnlpayment.Controls.Add(this.label6);
            this.pnlpayment.Controls.Add(this.lblvat);
            this.pnlpayment.Controls.Add(this.label5);
            this.pnlpayment.Controls.Add(this.btnpay);
            this.pnlpayment.Controls.Add(this.lbltotalprice);
            this.pnlpayment.Controls.Add(this.label3);
            this.pnlpayment.Controls.Add(this.lblserver);
            this.pnlpayment.Controls.Add(this.label4);
            this.pnlpayment.Controls.Add(this.lbltablenumber);
            this.pnlpayment.Controls.Add(this.label2);
            this.pnlpayment.Controls.Add(this.radiobtncash);
            this.pnlpayment.Controls.Add(this.radiobtnpin);
            this.pnlpayment.Controls.Add(this.listViewrecipt);
            this.pnlpayment.Location = new System.Drawing.Point(12, 82);
            this.pnlpayment.Name = "pnlpayment";
            this.pnlpayment.Size = new System.Drawing.Size(785, 616);
            this.pnlpayment.TabIndex = 1;
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(214, 533);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(302, 53);
            this.btnpay.TabIndex = 10;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Location = new System.Drawing.Point(588, 324);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(38, 17);
            this.lbltotalprice.TabIndex = 9;
            this.lbltotalprice.Text = "------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "TotalPrice: ";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(667, 19);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(43, 17);
            this.lblserver.TabIndex = 7;
            this.lblserver.Text = "-------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server";
            // 
            // lbltablenumber
            // 
            this.lbltablenumber.AutoSize = true;
            this.lbltablenumber.Location = new System.Drawing.Point(175, 19);
            this.lbltablenumber.Name = "lbltablenumber";
            this.lbltablenumber.Size = new System.Drawing.Size(43, 17);
            this.lbltablenumber.TabIndex = 5;
            this.lbltablenumber.Text = "-------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table Number";
            // 
            // radiobtncash
            // 
            this.radiobtncash.AutoSize = true;
            this.radiobtncash.Location = new System.Drawing.Point(520, 476);
            this.radiobtncash.Name = "radiobtncash";
            this.radiobtncash.Size = new System.Drawing.Size(108, 21);
            this.radiobtncash.TabIndex = 2;
            this.radiobtncash.TabStop = true;
            this.radiobtncash.Text = "Pay by Cash";
            this.radiobtncash.UseVisualStyleBackColor = true;
            // 
            // radiobtnpin
            // 
            this.radiobtnpin.AutoSize = true;
            this.radiobtnpin.Location = new System.Drawing.Point(60, 476);
            this.radiobtnpin.Name = "radiobtnpin";
            this.radiobtnpin.Size = new System.Drawing.Size(96, 21);
            this.radiobtnpin.TabIndex = 1;
            this.radiobtnpin.TabStop = true;
            this.radiobtnpin.Text = "Pay by Pin";
            this.radiobtnpin.UseVisualStyleBackColor = true;
            // 
            // listViewrecipt
            // 
            this.listViewrecipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewrecipt.HideSelection = false;
            this.listViewrecipt.Location = new System.Drawing.Point(110, 94);
            this.listViewrecipt.Name = "listViewrecipt";
            this.listViewrecipt.Size = new System.Drawing.Size(518, 205);
            this.listViewrecipt.TabIndex = 0;
            this.listViewrecipt.UseCompatibleStateImageBehavior = false;
            this.listViewrecipt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "itemName";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "price";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "quantity";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "orderID";
            this.columnHeader4.Width = 122;
            // 
            // btnprintrecipt
            // 
            this.btnprintrecipt.Location = new System.Drawing.Point(37, 35);
            this.btnprintrecipt.Name = "btnprintrecipt";
            this.btnprintrecipt.Size = new System.Drawing.Size(145, 30);
            this.btnprintrecipt.TabIndex = 2;
            this.btnprintrecipt.Text = "Print Recipt";
            this.btnprintrecipt.UseVisualStyleBackColor = true;
            this.btnprintrecipt.Click += new System.EventHandler(this.btnprintrecipt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "VAT(21%):";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(588, 354);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(43, 17);
            this.lblvat.TabIndex = 12;
            this.lblvat.Text = "-------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter tip amount:";
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(588, 385);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(60, 22);
            this.txttip.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Amount(incl all taxes and tip):";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Location = new System.Drawing.Point(588, 419);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(43, 17);
            this.lbltotalamount.TabIndex = 16;
            this.lbltotalamount.Text = "-------";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 710);
            this.Controls.Add(this.btnprintrecipt);
            this.Controls.Add(this.pnlpayment);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.pnlpayment.ResumeLayout(false);
            this.pnlpayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlpayment;
        private System.Windows.Forms.ListView listViewrecipt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltablenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtncash;
        private System.Windows.Forms.RadioButton radiobtnpin;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Button btnprintrecipt;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label label5;
    }
}