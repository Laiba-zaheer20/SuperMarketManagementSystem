namespace oop_project
{
    partial class viewitems
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
            this.components = new System.ComponentModel.Container();
            this.itemsview = new System.Windows.Forms.DataGridView();
            this.oilDataSet = new oop_project.oilDataSet();
            this.oilDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsview
            // 
            this.itemsview.AccessibleDescription = "True";
            this.itemsview.AllowUserToOrderColumns = true;
            this.itemsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsview.Location = new System.Drawing.Point(0, 0);
            this.itemsview.Name = "itemsview";
            this.itemsview.Size = new System.Drawing.Size(724, 258);
            this.itemsview.TabIndex = 0;
            this.itemsview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsview_CellContentClick);
            // 
            // oilDataSet
            // 
            this.oilDataSet.DataSetName = "oilDataSet";
            this.oilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oilDataSetBindingSource
            // 
            this.oilDataSetBindingSource.DataSource = this.oilDataSet;
            this.oilDataSetBindingSource.Position = 0;
            // 
            // viewok
            // 
            this.viewok.Location = new System.Drawing.Point(0, 256);
            this.viewok.Name = "viewok";
            this.viewok.Size = new System.Drawing.Size(724, 24);
            this.viewok.TabIndex = 1;
            this.viewok.Text = "OK\r\n";
            this.viewok.UseVisualStyleBackColor = true;
            this.viewok.Click += new System.EventHandler(this.viewok_Click);
            // 
            // viewitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 281);
            this.Controls.Add(this.viewok);
            this.Controls.Add(this.itemsview);
            this.Name = "viewitems";
            this.Text = "viewitems";
            this.Load += new System.EventHandler(this.viewitems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource oilDataSetBindingSource;
        private oilDataSet oilDataSet;
        public System.Windows.Forms.DataGridView itemsview;
        private System.Windows.Forms.Button viewok;
    }
}