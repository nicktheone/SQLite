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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCreateDB = new System.Windows.Forms.Button();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelNotes = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelAddress = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.TextBoxNotes = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelCustomer = new System.Windows.Forms.Label();
            this.ButtonRead = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.LaberlOrder = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelCustomerId = new System.Windows.Forms.Label();
            this.TextBoxProduct = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.TextBoxCustomerId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 410);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonCreateDB
            // 
            this.buttonCreateDB.AutoSize = true;
            this.buttonCreateDB.Location = new System.Drawing.Point(404, 297);
            this.buttonCreateDB.Name = "buttonCreateDB";
            this.buttonCreateDB.Size = new System.Drawing.Size(110, 30);
            this.buttonCreateDB.TabIndex = 19;
            this.buttonCreateDB.Text = "Create DB";
            this.buttonCreateDB.UseVisualStyleBackColor = true;
            this.buttonCreateDB.Click += new System.EventHandler(this.buttonCreateDB_Click);
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.Location = new System.Drawing.Point(15, 96);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(86, 17);
            this.LabelFirstName.TabIndex = 11;
            this.LabelFirstName.Text = "First Name";
            // 
            // LabelNotes
            // 
            this.LabelNotes.AutoSize = true;
            this.LabelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotes.Location = new System.Drawing.Point(15, 236);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(50, 17);
            this.LabelNotes.TabIndex = 16;
            this.LabelNotes.Text = "Notes";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(15, 124);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(85, 17);
            this.LabelLastName.TabIndex = 12;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(15, 208);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(47, 17);
            this.LabelEmail.TabIndex = 15;
            this.LabelEmail.Text = "Email";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(15, 152);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(67, 17);
            this.LabelAddress.TabIndex = 13;
            this.LabelAddress.Text = "Address";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhone.Location = new System.Drawing.Point(15, 180);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(54, 17);
            this.LabelPhone.TabIndex = 14;
            this.LabelPhone.Text = "Phone";
            // 
            // TextBoxNotes
            // 
            this.TextBoxNotes.Location = new System.Drawing.Point(137, 233);
            this.TextBoxNotes.Multiline = true;
            this.TextBoxNotes.Name = "TextBoxNotes";
            this.TextBoxNotes.Size = new System.Drawing.Size(211, 105);
            this.TextBoxNotes.TabIndex = 40;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(137, 205);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(211, 22);
            this.TextBoxEmail.TabIndex = 39;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(137, 177);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(211, 22);
            this.TextBoxPhone.TabIndex = 38;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(137, 149);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(211, 22);
            this.TextBoxAddress.TabIndex = 37;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(137, 121);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(211, 22);
            this.TextBoxLastName.TabIndex = 36;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(137, 93);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(211, 22);
            this.TextBoxFirstName.TabIndex = 35;
            // 
            // LabelCustomer
            // 
            this.LabelCustomer.AutoSize = true;
            this.LabelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomer.Location = new System.Drawing.Point(62, 19);
            this.LabelCustomer.Name = "LabelCustomer";
            this.LabelCustomer.Size = new System.Drawing.Size(221, 39);
            this.LabelCustomer.TabIndex = 34;
            this.LabelCustomer.Text = "CUSTOMER";
            this.LabelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRead
            // 
            this.ButtonRead.Location = new System.Drawing.Point(404, 133);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(110, 30);
            this.ButtonRead.TabIndex = 31;
            this.ButtonRead.Text = "Read";
            this.ButtonRead.UseVisualStyleBackColor = true;
            this.ButtonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(404, 205);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(110, 30);
            this.ButtonDelete.TabIndex = 33;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Enabled = false;
            this.ButtonUpdate.Location = new System.Drawing.Point(404, 169);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(110, 30);
            this.ButtonUpdate.TabIndex = 32;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(404, 97);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(110, 30);
            this.ButtonCreate.TabIndex = 30;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCustomer);
            this.tabControl1.Controls.Add(this.tabPageOrder);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 400);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.LabelFirstName);
            this.tabPageCustomer.Controls.Add(this.LabelCustomer);
            this.tabPageCustomer.Controls.Add(this.LabelNotes);
            this.tabPageCustomer.Controls.Add(this.TextBoxFirstName);
            this.tabPageCustomer.Controls.Add(this.TextBoxNotes);
            this.tabPageCustomer.Controls.Add(this.LabelLastName);
            this.tabPageCustomer.Controls.Add(this.TextBoxLastName);
            this.tabPageCustomer.Controls.Add(this.TextBoxEmail);
            this.tabPageCustomer.Controls.Add(this.LabelEmail);
            this.tabPageCustomer.Controls.Add(this.TextBoxAddress);
            this.tabPageCustomer.Controls.Add(this.LabelAddress);
            this.tabPageCustomer.Controls.Add(this.TextBoxPhone);
            this.tabPageCustomer.Controls.Add(this.LabelPhone);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(369, 371);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Customer";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.LaberlOrder);
            this.tabPageOrder.Controls.Add(this.LabelDate);
            this.tabPageOrder.Controls.Add(this.label1);
            this.tabPageOrder.Controls.Add(this.LabelCustomerId);
            this.tabPageOrder.Controls.Add(this.TextBoxProduct);
            this.tabPageOrder.Controls.Add(this.TextBoxCustomerId);
            this.tabPageOrder.Controls.Add(this.TextBoxDate);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(369, 371);
            this.tabPageOrder.TabIndex = 1;
            this.tabPageOrder.Text = "Order";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 39);
            this.label1.TabIndex = 43;
            this.label1.Text = "ORDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LaberlOrder
            // 
            this.LaberlOrder.AutoSize = true;
            this.LaberlOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaberlOrder.Location = new System.Drawing.Point(15, 96);
            this.LaberlOrder.Name = "LaberlOrder";
            this.LaberlOrder.Size = new System.Drawing.Size(50, 17);
            this.LaberlOrder.TabIndex = 11;
            this.LaberlOrder.Text = "Order";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(15, 124);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(42, 17);
            this.LabelDate.TabIndex = 12;
            this.LabelDate.Text = "Date";
            // 
            // LabelCustomerId
            // 
            this.LabelCustomerId.AutoSize = true;
            this.LabelCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomerId.Location = new System.Drawing.Point(15, 152);
            this.LabelCustomerId.Name = "LabelCustomerId";
            this.LabelCustomerId.Size = new System.Drawing.Size(76, 17);
            this.LabelCustomerId.TabIndex = 13;
            this.LabelCustomerId.Text = "Customer";
            // 
            // TextBoxProduct
            // 
            this.TextBoxProduct.Location = new System.Drawing.Point(137, 93);
            this.TextBoxProduct.Name = "TextBoxProduct";
            this.TextBoxProduct.Size = new System.Drawing.Size(211, 22);
            this.TextBoxProduct.TabIndex = 44;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Location = new System.Drawing.Point(137, 121);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(211, 22);
            this.TextBoxDate.TabIndex = 45;
            // 
            // TextBoxCustomerId
            // 
            this.TextBoxCustomerId.Location = new System.Drawing.Point(137, 149);
            this.TextBoxCustomerId.Name = "TextBoxCustomerId";
            this.TextBoxCustomerId.Size = new System.Drawing.Size(211, 22);
            this.TextBoxCustomerId.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 434);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButtonRead);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.buttonCreateDB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            this.tabPageOrder.ResumeLayout(false);
            this.tabPageOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreateDB;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelNotes;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelAddress;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox TextBoxNotes;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelCustomer;
        private System.Windows.Forms.Button ButtonRead;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LaberlOrder;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelCustomerId;
        private System.Windows.Forms.TextBox TextBoxProduct;
        private System.Windows.Forms.TextBox TextBoxCustomerId;
        private System.Windows.Forms.TextBox TextBoxDate;
    }
}

