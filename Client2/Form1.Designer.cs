namespace Client2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataTableUsers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputBirthday = new System.Windows.Forms.TextBox();
            this.inputLastname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inputId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableUsers
            // 
            this.dataTableUsers.AllowUserToAddRows = false;
            this.dataTableUsers.AllowUserToDeleteRows = false;
            this.dataTableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataTableUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataTableUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataTableUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataTableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.Lastname,
            this.Birthday});
            this.dataTableUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableUsers.Location = new System.Drawing.Point(0, 0);
            this.dataTableUsers.Name = "dataTableUsers";
            this.dataTableUsers.ReadOnly = true;
            this.dataTableUsers.RowHeadersVisible = false;
            this.dataTableUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTableUsers.Size = new System.Drawing.Size(968, 441);
            this.dataTableUsers.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.Frozen = true;
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserName.Width = 307;
            // 
            // Lastname
            // 
            this.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Lastname.Frozen = true;
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lastname.Width = 308;
            // 
            // Birthday
            // 
            this.Birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Birthday.Frozen = true;
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Birthday.Width = 307;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataTableUsers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 441);
            this.panel1.TabIndex = 1;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(76, 6);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(279, 20);
            this.inputName.TabIndex = 2;
            // 
            // inputBirthday
            // 
            this.inputBirthday.Location = new System.Drawing.Point(676, 6);
            this.inputBirthday.Name = "inputBirthday";
            this.inputBirthday.Size = new System.Drawing.Size(289, 20);
            this.inputBirthday.TabIndex = 3;
            // 
            // inputLastname
            // 
            this.inputLastname.Location = new System.Drawing.Point(361, 6);
            this.inputLastname.Name = "inputLastname";
            this.inputLastname.Size = new System.Drawing.Size(309, 20);
            this.inputLastname.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.inputId);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.inputName);
            this.panel2.Controls.Add(this.inputLastname);
            this.panel2.Controls.Add(this.inputBirthday);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 86);
            this.panel2.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(84, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(3, 6);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(67, 20);
            this.inputId.TabIndex = 6;
            this.inputId.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(868, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Data users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTableUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputBirthday;
        private System.Windows.Forms.TextBox inputLastname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox inputId;
        private System.Windows.Forms.Button btnUpdate;
    }
}

