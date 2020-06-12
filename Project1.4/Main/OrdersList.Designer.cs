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
            this.btnOngoing = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.listOrders = new System.Windows.Forms.ListView();
            this.tableID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOngoing
            // 
            this.btnOngoing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOngoing.Location = new System.Drawing.Point(111, 113);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(208, 48);
            this.btnOngoing.TabIndex = 0;
            this.btnOngoing.Text = "In Progress";
            this.btnOngoing.UseVisualStyleBackColor = false;
            this.btnOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnComplete.Location = new System.Drawing.Point(348, 113);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(208, 48);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Completed Orders";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // listOrders
            // 
            this.listOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableID,
            this.orderID});
            this.listOrders.ForeColor = System.Drawing.Color.White;
            this.listOrders.FullRowSelect = true;
            this.listOrders.HideSelection = false;
            this.listOrders.Location = new System.Drawing.Point(111, 205);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(445, 378);
            this.listOrders.TabIndex = 3;
            this.listOrders.UseCompatibleStateImageBehavior = false;
            this.listOrders.View = System.Windows.Forms.View.Details;
            this.listOrders.SelectedIndexChanged += new System.EventHandler(this.listOrders_SelectedIndexChanged);
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
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnOngoing);
            this.Name = "OrdersList";
            this.Text = "OrdersList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOngoing;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ListView listOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader tableID;
        private System.Windows.Forms.ColumnHeader orderID;
    }
}