namespace Homestaylist
{
    partial class Homestaylist
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHomestayown = new System.Windows.Forms.Label();
            this.cbxHomestayown = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDem = new System.Windows.Forms.TextBox();
            this.grdListview = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnUpdate,
            this.btnDelete,
            this.btnRefesh,
            this.btnDisplay});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(64, 24);
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 24);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(65, 24);
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(70, 24);
            this.btnDisplay.Text = "Display";
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblHomestayown
            // 
            this.lblHomestayown.AutoSize = true;
            this.lblHomestayown.Location = new System.Drawing.Point(12, 47);
            this.lblHomestayown.Name = "lblHomestayown";
            this.lblHomestayown.Size = new System.Drawing.Size(100, 17);
            this.lblHomestayown.TabIndex = 1;
            this.lblHomestayown.Text = "Homestay own";
            // 
            // cbxHomestayown
            // 
            this.cbxHomestayown.FormattingEnabled = true;
            this.cbxHomestayown.Location = new System.Drawing.Point(118, 44);
            this.cbxHomestayown.Name = "cbxHomestayown";
            this.cbxHomestayown.Size = new System.Drawing.Size(144, 24);
            this.cbxHomestayown.TabIndex = 2;
            this.cbxHomestayown.SelectedIndexChanged += new System.EventHandler(this.cbxHomestayown_SelectedValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(288, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 17);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL";
            // 
            // txtDem
            // 
            this.txtDem.Location = new System.Drawing.Point(359, 44);
            this.txtDem.Name = "txtDem";
            this.txtDem.Size = new System.Drawing.Size(68, 22);
            this.txtDem.TabIndex = 4;
            // 
            // grdListview
            // 
            this.grdListview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListview.Location = new System.Drawing.Point(0, 74);
            this.grdListview.Name = "grdListview";
            this.grdListview.RowTemplate.Height = 24;
            this.grdListview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListview.Size = new System.Drawing.Size(791, 487);
            this.grdListview.TabIndex = 5;
            // 
            // Homestaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 559);
            this.Controls.Add(this.grdListview);
            this.Controls.Add(this.txtDem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbxHomestayown);
            this.Controls.Add(this.lblHomestayown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homestaylist";
            this.Text = "Homestaylist";
            this.Load += new System.EventHandler(this.Homestay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnRefesh;
        private System.Windows.Forms.ToolStripMenuItem btnDisplay;
        private System.Windows.Forms.Label lblHomestayown;
        private System.Windows.Forms.ComboBox cbxHomestayown;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDem;
        private System.Windows.Forms.DataGridView grdListview;
    }
}

