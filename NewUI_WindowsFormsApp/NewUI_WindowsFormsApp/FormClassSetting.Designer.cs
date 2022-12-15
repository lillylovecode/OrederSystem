
namespace NewUI_WindowsFormsApp
{
    partial class FormClassSetting
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
            this.dgv值日生 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chk值日生 = new System.Windows.Forms.CheckBox();
            this.txtstuName = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv值日生)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv值日生
            // 
            this.dgv值日生.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv值日生.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv值日生.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.dgv值日生.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv值日生.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv值日生.Location = new System.Drawing.Point(297, 36);
            this.dgv值日生.Name = "dgv值日生";
            this.dgv值日生.RowHeadersWidth = 51;
            this.dgv值日生.RowTemplate.Height = 27;
            this.dgv值日生.Size = new System.Drawing.Size(481, 480);
            this.dgv值日生.TabIndex = 0;
            this.dgv值日生.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv值日生_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "學生id";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("文鼎中特廣告體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChange.Location = new System.Drawing.Point(69, 350);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(189, 49);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "更改值日生";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("文鼎中特廣告體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "值日生狀態";
            // 
            // chk值日生
            // 
            this.chk值日生.AutoSize = true;
            this.chk值日生.Font = new System.Drawing.Font("文鼎中特廣告體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk值日生.ForeColor = System.Drawing.Color.White;
            this.chk值日生.Location = new System.Drawing.Point(195, 283);
            this.chk值日生.Name = "chk值日生";
            this.chk值日生.Size = new System.Drawing.Size(63, 34);
            this.chk值日生.TabIndex = 6;
            this.chk值日生.Text = "是";
            this.chk值日生.UseVisualStyleBackColor = true;
            // 
            // txtstuName
            // 
            this.txtstuName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtstuName.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtstuName.Location = new System.Drawing.Point(99, 205);
            this.txtstuName.Name = "txtstuName";
            this.txtstuName.ReadOnly = true;
            this.txtstuName.Size = new System.Drawing.Size(179, 43);
            this.txtstuName.TabIndex = 10;
            // 
            // txtStuID
            // 
            this.txtStuID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtStuID.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStuID.Location = new System.Drawing.Point(132, 130);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.ReadOnly = true;
            this.txtStuID.Size = new System.Drawing.Size(146, 43);
            this.txtStuID.TabIndex = 10;
            // 
            // FormClassSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(790, 610);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.txtstuName);
            this.Controls.Add(this.chk值日生);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv值日生);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClassSetting";
            this.Text = "FormClassSetting";
            this.Load += new System.EventHandler(this.FormClassSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv值日生)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv值日生;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk值日生;
        private System.Windows.Forms.TextBox txtstuName;
        private System.Windows.Forms.TextBox txtStuID;
    }
}