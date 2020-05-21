namespace ChapeauUI
{
    partial class OrdersList
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
            this.button3 = new System.Windows.Forms.Button();
            this.listOrders = new System.Windows.Forms.ListView();
            this.tableID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(111, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "In Progress";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(348, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Completed Orders";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // listOrders
            // 
            this.listOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableID,
            this.orderID});
            this.listOrders.ForeColor = System.Drawing.Color.White;
            this.listOrders.HideSelection = false;
            this.listOrders.Location = new System.Drawing.Point(111, 205);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(445, 378);
            this.listOrders.TabIndex = 3;
            this.listOrders.UseCompatibleStateImageBehavior = false;
            this.listOrders.View = System.Windows.Forms.View.Details;
            // 
            // tableID
            // 
            this.tableID.Text = "Table";
            this.tableID.Width = 307;
            // 
            // orderID
            // 
            this.orderID.Text = "Order Number";
            this.orderID.Width = 134;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 69);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitchen/Bar";
            // 
            // OrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "OrdersList";
            this.Text = "OrdersList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader tableID;
        private System.Windows.Forms.ColumnHeader orderID;
    }
}