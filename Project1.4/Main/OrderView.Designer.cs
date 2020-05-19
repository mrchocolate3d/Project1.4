﻿namespace ChapeauUI
{
    partial class OrderView
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
            this.btnDone = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(307, 543);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go To Payment.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDone.Location = new System.Drawing.Point(100, 544);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(173, 54);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // listOrder
            // 
            this.listOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.qty});
            this.listOrder.ForeColor = System.Drawing.Color.White;
            this.listOrder.HideSelection = false;
            this.listOrder.Location = new System.Drawing.Point(100, 214);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(386, 305);
            this.listOrder.TabIndex = 2;
            this.listOrder.UseCompatibleStateImageBehavior = false;
            this.listOrder.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 50);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblOrder);
            this.panel2.Controls.Add(this.lblWaiter);
            this.panel2.Controls.Add(this.lblTable);
            this.panel2.Location = new System.Drawing.Point(100, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 100);
            this.panel2.TabIndex = 4;
            // 
            // item
            // 
            this.item.Text = "Order Item";
            this.item.Width = 264;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.Width = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Order";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(21, 30);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(131, 37);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Table #";
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.Color.White;
            this.lblWaiter.Location = new System.Drawing.Point(243, 17);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(53, 16);
            this.lblWaiter.TabIndex = 2;
            this.lblWaiter.Text = "Waiter: ";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.White;
            this.lblOrder.Location = new System.Drawing.Point(243, 62);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(52, 16);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Order #";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListView listOrder;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTable;
    }
}