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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btn_Resturant = new System.Windows.Forms.Button();
            this.pnltitle = new System.Windows.Forms.Panel();
            this.pnlpayment.SuspendLayout();
            this.pnltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(247, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Chapeau";
            // 
            // pnlpayment
            // 
            this.pnlpayment.Controls.Add(this.radioButton1);
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
            this.pnlpayment.Location = new System.Drawing.Point(2, 178);
            this.pnlpayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlpayment.Name = "pnlpayment";
            this.pnlpayment.Size = new System.Drawing.Size(750, 742);
            this.pnlpayment.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(285, 576);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 21);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pay by Credit";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Location = new System.Drawing.Point(559, 500);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(43, 17);
            this.lbltotalamount.TabIndex = 16;
            this.lbltotalamount.Text = "-------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Amount(incl all taxes and tip):";
            // 
            // txttip
            // 
            this.txttip.Location = new System.Drawing.Point(562, 452);
            this.txttip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttip.Name = "txttip";
            this.txttip.Size = new System.Drawing.Size(60, 22);
            this.txttip.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter tip amount:";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(559, 413);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(43, 17);
            this.lblvat.TabIndex = 12;
            this.lblvat.Text = "-------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "VAT(21%):";
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(193, 642);
            this.btnpay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(342, 59);
            this.btnpay.TabIndex = 10;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Location = new System.Drawing.Point(559, 374);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(38, 17);
            this.lbltotalprice.TabIndex = 9;
            this.lbltotalprice.Text = "------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "TotalPrice: ";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(588, 41);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(43, 17);
            this.lblserver.TabIndex = 7;
            this.lblserver.Text = "-------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee";
            // 
            // lbltablenumber
            // 
            this.lbltablenumber.AutoSize = true;
            this.lbltablenumber.Location = new System.Drawing.Point(136, 41);
            this.lbltablenumber.Name = "lbltablenumber";
            this.lbltablenumber.Size = new System.Drawing.Size(43, 17);
            this.lbltablenumber.TabIndex = 5;
            this.lbltablenumber.Text = "-------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table Number";
            // 
            // radiobtncash
            // 
            this.radiobtncash.AutoSize = true;
            this.radiobtncash.Location = new System.Drawing.Point(581, 576);
            this.radiobtncash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.radiobtnpin.Location = new System.Drawing.Point(49, 576);
            this.radiobtnpin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.listViewrecipt.Location = new System.Drawing.Point(90, 119);
            this.listViewrecipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewrecipt.Name = "listViewrecipt";
            this.listViewrecipt.Size = new System.Drawing.Size(519, 205);
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
            this.btnprintrecipt.Location = new System.Drawing.Point(2, 130);
            this.btnprintrecipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprintrecipt.Name = "btnprintrecipt";
            this.btnprintrecipt.Size = new System.Drawing.Size(145, 30);
            this.btnprintrecipt.TabIndex = 2;
            this.btnprintrecipt.Text = "Print Recipt";
            this.btnprintrecipt.UseVisualStyleBackColor = true;
            this.btnprintrecipt.Click += new System.EventHandler(this.btnprintrecipt_Click);
            // 
            // btn_Resturant
            // 
            this.btn_Resturant.Location = new System.Drawing.Point(628, 130);
            this.btn_Resturant.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Resturant.Name = "btn_Resturant";
            this.btn_Resturant.Size = new System.Drawing.Size(100, 28);
            this.btn_Resturant.TabIndex = 3;
            this.btn_Resturant.Text = "Resturant View";
            this.btn_Resturant.UseVisualStyleBackColor = true;
            this.btn_Resturant.Click += new System.EventHandler(this.btn_Resturant_Click);
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.DarkRed;
            this.pnltitle.Controls.Add(this.label1);
            this.pnltitle.Location = new System.Drawing.Point(2, 0);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(750, 103);
            this.pnltitle.TabIndex = 4;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 935);
            this.Controls.Add(this.pnltitle);
            this.Controls.Add(this.btn_Resturant);
            this.Controls.Add(this.btnprintrecipt);
            this.Controls.Add(this.pnlpayment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payment";
            this.Text = "Payment";
            this.pnlpayment.ResumeLayout(false);
            this.pnlpayment.PerformLayout();
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_Resturant;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel pnltitle;
    }
}