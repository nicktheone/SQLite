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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.LabelAddCustomer = new System.Windows.Forms.Label();
            this.ButtonRead = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 571);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // buttonCreateDB
            // 
            this.buttonCreateDB.AutoSize = true;
            this.buttonCreateDB.Location = new System.Drawing.Point(389, 440);
            this.buttonCreateDB.Name = "buttonCreateDB";
            this.buttonCreateDB.Size = new System.Drawing.Size(110, 30);
            this.buttonCreateDB.TabIndex = 19;
            this.buttonCreateDB.Text = "Create DB";
            this.buttonCreateDB.UseVisualStyleBackColor = true;
            this.buttonCreateDB.Click += new System.EventHandler(this.buttonCreateDB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelFirstName);
            this.panel1.Controls.Add(this.LabelNotes);
            this.panel1.Controls.Add(this.LabelLastName);
            this.panel1.Controls.Add(this.LabelEmail);
            this.panel1.Controls.Add(this.LabelAddress);
            this.panel1.Controls.Add(this.LabelPhone);
            this.panel1.Location = new System.Drawing.Point(2, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 245);
            this.panel1.TabIndex = 41;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirstName.Location = new System.Drawing.Point(42, 3);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelFirstName.Size = new System.Drawing.Size(86, 17);
            this.LabelFirstName.TabIndex = 11;
            this.LabelFirstName.Text = "First Name";
            // 
            // LabelNotes
            // 
            this.LabelNotes.AutoSize = true;
            this.LabelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotes.Location = new System.Drawing.Point(78, 143);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelNotes.Size = new System.Drawing.Size(50, 17);
            this.LabelNotes.TabIndex = 16;
            this.LabelNotes.Text = "Notes";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(43, 31);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelLastName.Size = new System.Drawing.Size(85, 17);
            this.LabelLastName.TabIndex = 12;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelEmail
            // 
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(61, 115);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelEmail.Size = new System.Drawing.Size(71, 17);
            this.LabelEmail.TabIndex = 15;
            this.LabelEmail.Text = "Email";
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(61, 59);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelAddress.Size = new System.Drawing.Size(67, 17);
            this.LabelAddress.TabIndex = 13;
            this.LabelAddress.Text = "Address";
            // 
            // LabelPhone
            // 
            this.LabelPhone.AutoSize = true;
            this.LabelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhone.Location = new System.Drawing.Point(74, 87);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelPhone.Size = new System.Drawing.Size(54, 17);
            this.LabelPhone.TabIndex = 14;
            this.LabelPhone.Text = "Phone";
            // 
            // TextBoxNotes
            // 
            this.TextBoxNotes.Location = new System.Drawing.Point(156, 380);
            this.TextBoxNotes.Multiline = true;
            this.TextBoxNotes.Name = "TextBoxNotes";
            this.TextBoxNotes.Size = new System.Drawing.Size(200, 105);
            this.TextBoxNotes.TabIndex = 40;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(156, 352);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.TextBoxEmail.TabIndex = 39;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(156, 324);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(200, 22);
            this.TextBoxPhone.TabIndex = 38;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(156, 296);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(200, 22);
            this.TextBoxAddress.TabIndex = 37;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(156, 268);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(200, 22);
            this.TextBoxLastName.TabIndex = 36;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(156, 240);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(200, 22);
            this.TextBoxFirstName.TabIndex = 35;
            // 
            // LabelAddCustomer
            // 
            this.LabelAddCustomer.AutoSize = true;
            this.LabelAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddCustomer.Location = new System.Drawing.Point(126, 167);
            this.LabelAddCustomer.Name = "LabelAddCustomer";
            this.LabelAddCustomer.Size = new System.Drawing.Size(221, 39);
            this.LabelAddCustomer.TabIndex = 34;
            this.LabelAddCustomer.Text = "CUSTOMER";
            this.LabelAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRead
            // 
            this.ButtonRead.Location = new System.Drawing.Point(389, 276);
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
            this.ButtonDelete.Location = new System.Drawing.Point(389, 348);
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
            this.ButtonUpdate.Location = new System.Drawing.Point(389, 312);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(110, 30);
            this.ButtonUpdate.TabIndex = 32;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(389, 240);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(110, 30);
            this.ButtonCreate.TabIndex = 30;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1321, 63);
            this.panel2.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1321, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxNotes);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxLastName);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.LabelAddCustomer);
            this.Controls.Add(this.ButtonRead);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.buttonCreateDB);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreateDB;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label LabelAddCustomer;
        private System.Windows.Forms.Button ButtonRead;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Panel panel2;
    }
}

