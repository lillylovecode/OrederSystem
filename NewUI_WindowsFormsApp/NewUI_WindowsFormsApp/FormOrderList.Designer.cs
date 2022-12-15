
namespace NewUI_WindowsFormsApp
{
    partial class FormOrderList
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
            this.dgv統計結果 = new System.Windows.Forms.DataGridView();
            this.btn列印結果 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt總額 = new System.Windows.Forms.TextBox();
            this.cbox店名 = new System.Windows.Forms.ComboBox();
            this.dgv店家資訊 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl列表標題 = new System.Windows.Forms.Label();
            this.btn總明細 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv統計結果)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv店家資訊)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv統計結果
            // 
            this.dgv統計結果.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv統計結果.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv統計結果.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv統計結果.Location = new System.Drawing.Point(457, 58);
            this.dgv統計結果.Name = "dgv統計結果";
            this.dgv統計結果.ReadOnly = true;
            this.dgv統計結果.RowHeadersWidth = 51;
            this.dgv統計結果.RowTemplate.Height = 27;
            this.dgv統計結果.Size = new System.Drawing.Size(308, 513);
            this.dgv統計結果.TabIndex = 0;
            // 
            // btn列印結果
            // 
            this.btn列印結果.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btn列印結果.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn列印結果.Font = new System.Drawing.Font("文鼎中特廣告體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列印結果.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn列印結果.Location = new System.Drawing.Point(40, 419);
            this.btn列印結果.Name = "btn列印結果";
            this.btn列印結果.Size = new System.Drawing.Size(333, 49);
            this.btn列印結果.TabIndex = 7;
            this.btn列印結果.Text = "列印統計表";
            this.btn列印結果.UseVisualStyleBackColor = false;
            this.btn列印結果.Click += new System.EventHandler(this.btn列印結果_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "店名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(34, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "總額";
            // 
            // txt總額
            // 
            this.txt總額.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt總額.Location = new System.Drawing.Point(121, 323);
            this.txt總額.Name = "txt總額";
            this.txt總額.Size = new System.Drawing.Size(252, 32);
            this.txt總額.TabIndex = 9;
            // 
            // cbox店名
            // 
            this.cbox店名.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox店名.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox店名.FormattingEnabled = true;
            this.cbox店名.Location = new System.Drawing.Point(121, 248);
            this.cbox店名.Name = "cbox店名";
            this.cbox店名.Size = new System.Drawing.Size(252, 32);
            this.cbox店名.TabIndex = 8;
            this.cbox店名.SelectedIndexChanged += new System.EventHandler(this.cbox店名_SelectedIndexChanged);
            // 
            // dgv店家資訊
            // 
            this.dgv店家資訊.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv店家資訊.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv店家資訊.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv店家資訊.Location = new System.Drawing.Point(12, 58);
            this.dgv店家資訊.Name = "dgv店家資訊";
            this.dgv店家資訊.ReadOnly = true;
            this.dgv店家資訊.RowHeadersWidth = 51;
            this.dgv店家資訊.RowTemplate.Height = 27;
            this.dgv店家資訊.Size = new System.Drawing.Size(439, 164);
            this.dgv店家資訊.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(115, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "店家資訊";
            // 
            // lbl列表標題
            // 
            this.lbl列表標題.AutoSize = true;
            this.lbl列表標題.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl列表標題.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl列表標題.Location = new System.Drawing.Point(461, 20);
            this.lbl列表標題.Name = "lbl列表標題";
            this.lbl列表標題.Size = new System.Drawing.Size(147, 35);
            this.lbl列表標題.TabIndex = 6;
            this.lbl列表標題.Text = "統計結果";
            // 
            // btn總明細
            // 
            this.btn總明細.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btn總明細.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn總明細.Font = new System.Drawing.Font("文鼎中特廣告體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn總明細.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn總明細.Location = new System.Drawing.Point(40, 489);
            this.btn總明細.Name = "btn總明細";
            this.btn總明細.Size = new System.Drawing.Size(333, 49);
            this.btn總明細.TabIndex = 7;
            this.btn總明細.Text = "列印總明細表";
            this.btn總明細.UseVisualStyleBackColor = false;
            this.btn總明細.Click += new System.EventHandler(this.btn總明細_Click);
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(790, 610);
            this.Controls.Add(this.dgv店家資訊);
            this.Controls.Add(this.txt總額);
            this.Controls.Add(this.cbox店名);
            this.Controls.Add(this.btn總明細);
            this.Controls.Add(this.btn列印結果);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl列表標題);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv統計結果);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrderList";
            this.Text = "FormOrderList";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv統計結果)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv店家資訊)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv統計結果;
        private System.Windows.Forms.Button btn列印結果;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt總額;
        private System.Windows.Forms.ComboBox cbox店名;
        private System.Windows.Forms.DataGridView dgv店家資訊;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl列表標題;
        private System.Windows.Forms.Button btn總明細;
    }
}