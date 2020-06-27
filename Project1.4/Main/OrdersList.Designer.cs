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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersList));
            this.btnOngoing = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.listOrders = new System.Windows.Forms.ListView();
            this.tableID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrdr = new System.Windows.Forms.Label();
            this.lblWaitr = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listOrdr = new System.Windows.Forms.ListView();
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTableNr = new System.Windows.Forms.Label();
            this.lblTabl = new System.Windows.Forms.Label();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOngoing
            // 
            this.btnOngoing.BackColor = System.Drawing.Color.Orange;
            this.btnOngoing.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngoing.Location = new System.Drawing.Point(12, 134);
            this.btnOngoing.Name = "btnOngoing";
            this.btnOngoing.Size = new System.Drawing.Size(359, 84);
            this.btnOngoing.TabIndex = 0;
            this.btnOngoing.Text = "Ongoing Orders";
            this.btnOngoing.UseVisualStyleBackColor = false;
            this.btnOngoing.Click += new System.EventHandler(this.btnOngoing_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.BurlyWood;
            this.btnComplete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(381, 133);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(359, 85);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Completed Orders";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // listOrders
            // 
            this.listOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(97)))));
            this.listOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tableID});
            this.listOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOrders.ForeColor = System.Drawing.Color.Black;
            this.listOrders.FullRowSelect = true;
            this.listOrders.HideSelection = false;
            this.listOrders.Location = new System.Drawing.Point(12, 474);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(88, 318);
            this.listOrders.TabIndex = 3;
            this.listOrders.UseCompatibleStateImageBehavior = false;
            this.listOrders.View = System.Windows.Forms.View.Details;
            this.listOrders.SelectedIndexChanged += new System.EventHandler(this.listOrders_SelectedIndexChanged);
            // 
            // tableID
            // 
            this.tableID.Text = "Table #";
            this.tableID.Width = 81;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.lblOrdr);
            this.panel2.Controls.Add(this.lblWaitr);
            this.panel2.Location = new System.Drawing.Point(260, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 143);
            this.panel2.TabIndex = 5;
            // 
            // lblOrdr
            // 
            this.lblOrdr.AutoSize = true;
            this.lblOrdr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdr.ForeColor = System.Drawing.Color.Black;
            this.lblOrdr.Location = new System.Drawing.Point(10, 28);
            this.lblOrdr.Name = "lblOrdr";
            this.lblOrdr.Size = new System.Drawing.Size(79, 22);
            this.lblOrdr.TabIndex = 3;
            this.lblOrdr.Text = "Order #";
            // 
            // lblWaitr
            // 
            this.lblWaitr.AutoSize = true;
            this.lblWaitr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitr.ForeColor = System.Drawing.Color.Black;
            this.lblWaitr.Location = new System.Drawing.Point(10, 84);
            this.lblWaitr.Name = "lblWaitr";
            this.lblWaitr.Size = new System.Drawing.Size(81, 22);
            this.lblWaitr.TabIndex = 2;
            this.lblWaitr.Text = "Waiter: ";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(581, 307);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(159, 143);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Mark as Ready";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(97)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 127);
            this.panel1.TabIndex = 9;
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(602, 44);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(137, 49);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitchen/Bar";
            // 
            // listOrdr
            // 
            this.listOrdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(97)))));
            this.listOrdr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.qty,
            this.comment});
            this.listOrdr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listOrdr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOrdr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listOrdr.HideSelection = false;
            this.listOrdr.Location = new System.Drawing.Point(106, 475);
            this.listOrdr.Name = "listOrdr";
            this.listOrdr.Size = new System.Drawing.Size(634, 317);
            this.listOrdr.TabIndex = 10;
            this.listOrdr.UseCompatibleStateImageBehavior = false;
            this.listOrdr.View = System.Windows.Forms.View.Details;
            // 
            // item
            // 
            this.item.Text = "Order Item";
            this.item.Width = 264;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.Width = 101;
            // 
            // comment
            // 
            this.comment.Text = "Comment";
            this.comment.Width = 264;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(97)))));
            this.panel3.Controls.Add(this.lblTableNr);
            this.panel3.Controls.Add(this.lblTabl);
            this.panel3.Location = new System.Drawing.Point(12, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 143);
            this.panel3.TabIndex = 11;
            // 
            // lblTableNr
            // 
            this.lblTableNr.AutoSize = true;
            this.lblTableNr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNr.Location = new System.Drawing.Point(121, 31);
            this.lblTableNr.Name = "lblTableNr";
            this.lblTableNr.Size = new System.Drawing.Size(96, 75);
            this.lblTableNr.TabIndex = 12;
            this.lblTableNr.Text = "__";
            // 
            // lblTabl
            // 
            this.lblTabl.AutoSize = true;
            this.lblTabl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabl.Location = new System.Drawing.Point(3, 20);
            this.lblTabl.Name = "lblTabl";
            this.lblTabl.Size = new System.Drawing.Size(110, 32);
            this.lblTabl.TabIndex = 11;
            this.lblTabl.Text = "Table #";
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKitchen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.Location = new System.Drawing.Point(12, 234);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(359, 48);
            this.btnKitchen.TabIndex = 12;
            this.btnKitchen.Text = "Kitchen Orders";
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnBar
            // 
            this.btnBar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBar.Location = new System.Drawing.Point(381, 233);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(359, 49);
            this.btnBar.TabIndex = 13;
            this.btnBar.Text = "Bar Orders";
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // OrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 985);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listOrdr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnOngoing);
            this.Name = "OrdersList";
            this.Text = "OrdersList";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOngoing;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ListView listOrders;
        private System.Windows.Forms.ColumnHeader tableID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOrdr;
        private System.Windows.Forms.Label lblWaitr;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listOrdr;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader comment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTableNr;
        private System.Windows.Forms.Label lblTabl;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnBar;
    }
}