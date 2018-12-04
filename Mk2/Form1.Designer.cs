namespace Mk2
{
    partial class Form1
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
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonRemoveByIndex = new System.Windows.Forms.Button();
            this.buttonRecoverDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRecoverByIndex = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCreateDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.AutoSize = true;
            this.buttonAddCustomer.Location = new System.Drawing.Point(114, 15);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(107, 27);
            this.buttonAddCustomer.TabIndex = 18;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonRemoveByIndex
            // 
            this.buttonRemoveByIndex.AutoSize = true;
            this.buttonRemoveByIndex.Location = new System.Drawing.Point(139, 87);
            this.buttonRemoveByIndex.Name = "buttonRemoveByIndex";
            this.buttonRemoveByIndex.Size = new System.Drawing.Size(127, 27);
            this.buttonRemoveByIndex.TabIndex = 17;
            this.buttonRemoveByIndex.Text = "Remove By Index";
            this.buttonRemoveByIndex.UseVisualStyleBackColor = true;
            this.buttonRemoveByIndex.Click += new System.EventHandler(this.buttonRemoveByIndex_Click);
            // 
            // buttonRecoverDB
            // 
            this.buttonRecoverDB.AutoSize = true;
            this.buttonRecoverDB.Location = new System.Drawing.Point(534, 24);
            this.buttonRecoverDB.Name = "buttonRecoverDB";
            this.buttonRecoverDB.Size = new System.Drawing.Size(94, 27);
            this.buttonRecoverDB.TabIndex = 15;
            this.buttonRecoverDB.Text = "Recover DB";
            this.buttonRecoverDB.UseVisualStyleBackColor = true;
            this.buttonRecoverDB.Click += new System.EventHandler(this.buttonRecoverDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 391);
            this.dataGridView1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(12, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // buttonRecoverByIndex
            // 
            this.buttonRecoverByIndex.AutoSize = true;
            this.buttonRecoverByIndex.Location = new System.Drawing.Point(139, 54);
            this.buttonRecoverByIndex.Name = "buttonRecoverByIndex";
            this.buttonRecoverByIndex.Size = new System.Drawing.Size(128, 27);
            this.buttonRecoverByIndex.TabIndex = 11;
            this.buttonRecoverByIndex.Text = "Recover By Index";
            this.buttonRecoverByIndex.UseVisualStyleBackColor = true;
            this.buttonRecoverByIndex.Click += new System.EventHandler(this.buttonRecoverByIndex_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.Location = new System.Drawing.Point(33, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 27);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCreateDB
            // 
            this.buttonCreateDB.AutoSize = true;
            this.buttonCreateDB.Location = new System.Drawing.Point(921, 24);
            this.buttonCreateDB.Name = "buttonCreateDB";
            this.buttonCreateDB.Size = new System.Drawing.Size(83, 27);
            this.buttonCreateDB.TabIndex = 19;
            this.buttonCreateDB.Text = "Create DB";
            this.buttonCreateDB.UseVisualStyleBackColor = true;
            this.buttonCreateDB.Click += new System.EventHandler(this.buttonCreateDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 483);
            this.Controls.Add(this.buttonCreateDB);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.buttonRemoveByIndex);
            this.Controls.Add(this.buttonRecoverDB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonRecoverByIndex);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonRemoveByIndex;
        private System.Windows.Forms.Button buttonRecoverDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonRecoverByIndex;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCreateDB;
    }
}

