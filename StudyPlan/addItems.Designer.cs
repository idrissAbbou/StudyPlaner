namespace StudyPlan
{
    partial class addItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addItems));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalHours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.totalHoursLabel = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(80, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.BackColor = System.Drawing.Color.Khaki;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Items,
            this.Category,
            this.TotalHours});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(80, 265);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(716, 242);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Items
            // 
            this.Items.Text = "Items";
            this.Items.Width = 373;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 165;
            // 
            // TotalHours
            // 
            this.TotalHours.Text = "TotalHours";
            this.TotalHours.Width = 178;
            // 
            // txtCategory
            // 
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(80, 135);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(255, 36);
            this.txtCategory.TabIndex = 0;
            this.txtCategory.Tag = "";
            this.txtCategory.Click += new System.EventHandler(this.txtCategory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(609, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(224, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 44);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(80, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(255, 36);
            this.txtId.TabIndex = 0;
            this.txtId.Tag = "";
            this.txtId.Visible = false;
            this.txtId.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalHoursLabel.Location = new System.Drawing.Point(85, 526);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(124, 25);
            this.totalHoursLabel.TabIndex = 4;
            this.totalHoursLabel.Text = "Total Hours";
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSort.Location = new System.Drawing.Point(689, 513);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(107, 44);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(526, 806);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Hours";
            // 
            // addItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalHoursLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addItems";
            this.Size = new System.Drawing.Size(847, 585);
            this.Load += new System.EventHandler(this.addItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Items;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ColumnHeader TotalHours;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label totalHoursLabel;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
    }
}
