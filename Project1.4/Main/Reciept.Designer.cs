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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltablenumber = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colpaymentid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colemployeeid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colpaymentmethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coldateorder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colvat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltotalprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnproceedpayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
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
            this.label3.Location = new System.Drawing.Point(454, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server:";
            // 
            // lbltablenumber
            // 
            this.lbltablenumber.AutoSize = true;
            this.lbltablenumber.Location = new System.Drawing.Point(195, 85);
            this.lbltablenumber.Name = "lbltablenumber";
            this.lbltablenumber.Size = new System.Drawing.Size(38, 17);
            this.lbltablenumber.TabIndex = 5;
            this.lbltablenumber.Text = "------";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(543, 85);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(38, 17);
            this.lblserver.TabIndex = 6;
            this.lblserver.Text = "------";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colpaymentid,
            this.colorderid,
            this.colemployeeid,
            this.colpaymentmethod,
            this.coldateorder,
            this.colvat,
            this.coltotalprice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(61, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 424);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colpaymentid
            // 
            this.colpaymentid.Text = "PaymentID";
            this.colpaymentid.Width = 99;
            // 
            // colorderid
            // 
            this.colorderid.Text = "orderID";
            this.colorderid.Width = 67;
            // 
            // colemployeeid
            // 
            this.colemployeeid.Text = "employeeID";
            this.colemployeeid.Width = 96;
            // 
            // colpaymentmethod
            // 
            this.colpaymentmethod.Text = "paymentMethod";
            this.colpaymentmethod.Width = 117;
            // 
            // coldateorder
            // 
            this.coldateorder.Text = "dateOrder";
            this.coldateorder.Width = 80;
            // 
            // colvat
            // 
            this.colvat.Text = "vat";
            // 
            // coltotalprice
            // 
            this.coltotalprice.Text = "totalPrice";
            this.coltotalprice.Width = 88;
            // 
            // btnproceedpayment
            // 
            this.btnproceedpayment.Location = new System.Drawing.Point(61, 584);
            this.btnproceedpayment.Name = "btnproceedpayment";
            this.btnproceedpayment.Size = new System.Drawing.Size(612, 50);
            this.btnproceedpayment.TabIndex = 17;
            this.btnproceedpayment.Text = "Proceed To Payment";
            this.btnproceedpayment.UseVisualStyleBackColor = true;
            // 
            // Reciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 657);
            this.Controls.Add(this.btnproceedpayment);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblserver);
            this.Controls.Add(this.lbltablenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reciept";
            this.Text = "Reciept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltablenumber;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colpaymentid;
        private System.Windows.Forms.ColumnHeader colorderid;
        private System.Windows.Forms.ColumnHeader colemployeeid;
        private System.Windows.Forms.ColumnHeader colpaymentmethod;
        private System.Windows.Forms.ColumnHeader coldateorder;
        private System.Windows.Forms.ColumnHeader colvat;
        private System.Windows.Forms.ColumnHeader coltotalprice;
        private System.Windows.Forms.Button btnproceedpayment;
    }
}