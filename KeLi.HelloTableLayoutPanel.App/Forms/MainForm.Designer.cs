namespace KeLi.HelloTableLayoutPanel.App.Forms
{
    partial class MainForm
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
            this.splStudent = new System.Windows.Forms.SplitContainer();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgiStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgiStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgiBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgiAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpStudent = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splStudent)).BeginInit();
            this.splStudent.Panel1.SuspendLayout();
            this.splStudent.Panel2.SuspendLayout();
            this.splStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // splStudent
            // 
            this.splStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splStudent.Location = new System.Drawing.Point(0, 0);
            this.splStudent.Name = "splStudent";
            // 
            // splStudent.Panel1
            // 
            this.splStudent.Panel1.Controls.Add(this.dgvStudent);
            // 
            // splStudent.Panel2
            // 
            this.splStudent.Panel2.AutoScroll = true;
            this.splStudent.Panel2.Controls.Add(this.tlpStudent);
            this.splStudent.Size = new System.Drawing.Size(884, 461);
            this.splStudent.SplitterDistance = 471;
            this.splStudent.TabIndex = 0;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgiStudentId,
            this.dgiStudentName,
            this.dgiBirthday,
            this.dgiAddress});
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(471, 461);
            this.dgvStudent.TabIndex = 2;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudent_CellClick);
            // 
            // dgiStudentId
            // 
            this.dgiStudentId.DataPropertyName = "StudentId";
            this.dgiStudentId.HeaderText = "StuID";
            this.dgiStudentId.Name = "dgiStudentId";
            this.dgiStudentId.ReadOnly = true;
            // 
            // dgiStudentName
            // 
            this.dgiStudentName.DataPropertyName = "StudentName";
            this.dgiStudentName.HeaderText = "Name";
            this.dgiStudentName.Name = "dgiStudentName";
            this.dgiStudentName.ReadOnly = true;
            // 
            // dgiBirthday
            // 
            this.dgiBirthday.DataPropertyName = "Birthday";
            this.dgiBirthday.HeaderText = "Birthday";
            this.dgiBirthday.Name = "dgiBirthday";
            this.dgiBirthday.ReadOnly = true;
            this.dgiBirthday.Width = 130;
            // 
            // dgiAddress
            // 
            this.dgiAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgiAddress.DataPropertyName = "Address";
            this.dgiAddress.HeaderText = "Address";
            this.dgiAddress.Name = "dgiAddress";
            this.dgiAddress.ReadOnly = true;
            // 
            // tlpStudent
            // 
            this.tlpStudent.AutoScroll = true;
            this.tlpStudent.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpStudent.ColumnCount = 4;
            this.tlpStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpStudent.Location = new System.Drawing.Point(0, 0);
            this.tlpStudent.Name = "tlpStudent";
            this.tlpStudent.RowCount = 1;
            this.tlpStudent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStudent.Size = new System.Drawing.Size(409, 461);
            this.tlpStudent.TabIndex = 0;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.splStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello, TableLayoutePanel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splStudent.Panel1.ResumeLayout(false);
            this.splStudent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splStudent)).EndInit();
            this.splStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TableLayoutPanel tlpStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgiStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgiStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgiBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgiAddress;
    }
}

