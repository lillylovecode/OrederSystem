
namespace NewUI_WindowsFormsApp
{
    partial class FormOrderFood
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView品項 = new System.Windows.Forms.ListView();
            this.txt品名 = new System.Windows.Forms.TextBox();
            this.txt單價 = new System.Windows.Forms.TextBox();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.dgv訂單明細 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txt店名 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn加 = new System.Windows.Forms.Button();
            this.btn減 = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單明細)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(406, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "店名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(406, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "品名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(406, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(561, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "數量";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(412, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "加入購物車";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView品項
            // 
            this.listView品項.HideSelection = false;
            this.listView品項.Location = new System.Drawing.Point(27, 30);
            this.listView品項.Name = "listView品項";
            this.listView品項.Size = new System.Drawing.Size(349, 312);
            this.listView品項.TabIndex = 4;
            this.listView品項.UseCompatibleStateImageBehavior = false;
            this.listView品項.ItemActivate += new System.EventHandler(this.listView品項_ItemActivate_1);
            // 
            // txt品名
            // 
            this.txt品名.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt品名.Location = new System.Drawing.Point(493, 105);
            this.txt品名.Name = "txt品名";
            this.txt品名.Size = new System.Drawing.Size(252, 32);
            this.txt品名.TabIndex = 5;
            // 
            // txt單價
            // 
            this.txt單價.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt單價.Location = new System.Drawing.Point(493, 180);
            this.txt單價.Name = "txt單價";
            this.txt單價.Size = new System.Drawing.Size(70, 32);
            this.txt單價.TabIndex = 5;
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(670, 184);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(48, 32);
            this.txt數量.TabIndex = 5;
            this.txt數量.Text = "1";
            this.txt數量.TextChanged += new System.EventHandler(this.txt數量_TextChanged);
            // 
            // dgv訂單明細
            // 
            this.dgv訂單明細.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.dgv訂單明細.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv訂單明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂單明細.Location = new System.Drawing.Point(27, 367);
            this.dgv訂單明細.Name = "dgv訂單明細";
            this.dgv訂單明細.RowHeadersWidth = 51;
            this.dgv訂單明細.RowTemplate.Height = 27;
            this.dgv訂單明細.Size = new System.Drawing.Size(718, 126);
            this.dgv訂單明細.TabIndex = 6;
            this.dgv訂單明細.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv訂單明細_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(562, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "刪除此筆資料";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txt店名
            // 
            this.txt店名.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt店名.Location = new System.Drawing.Point(493, 36);
            this.txt店名.Name = "txt店名";
            this.txt店名.Size = new System.Drawing.Size(252, 32);
            this.txt店名.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(594, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空欄位";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn加
            // 
            this.btn加.Font = new System.Drawing.Font("新細明體", 15F);
            this.btn加.Location = new System.Drawing.Point(724, 185);
            this.btn加.Name = "btn加";
            this.btn加.Size = new System.Drawing.Size(26, 28);
            this.btn加.TabIndex = 7;
            this.btn加.Text = "+";
            this.btn加.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn加.UseVisualStyleBackColor = true;
            this.btn加.Click += new System.EventHandler(this.btn加_Click);
            // 
            // btn減
            // 
            this.btn減.Font = new System.Drawing.Font("新細明體", 15F);
            this.btn減.Location = new System.Drawing.Point(635, 185);
            this.btn減.Name = "btn減";
            this.btn減.Size = new System.Drawing.Size(29, 28);
            this.btn減.TabIndex = 7;
            this.btn減.Text = "-";
            this.btn減.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn減.UseVisualStyleBackColor = true;
            this.btn減.Click += new System.EventHandler(this.btn減_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFavorite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFavorite.Location = new System.Drawing.Point(513, 242);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(180, 38);
            this.btnFavorite.TabIndex = 1;
            this.btnFavorite.Text = "加入我的最愛";
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // FormOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(790, 610);
            this.Controls.Add(this.btn減);
            this.Controls.Add(this.btn加);
            this.Controls.Add(this.dgv訂單明細);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.txt單價);
            this.Controls.Add(this.txt店名);
            this.Controls.Add(this.txt品名);
            this.Controls.Add(this.listView品項);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrderFood";
            this.Text = "FormOrderFood";
            this.Load += new System.EventHandler(this.FormOrderFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單明細)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView品項;
        private System.Windows.Forms.TextBox txt品名;
        private System.Windows.Forms.TextBox txt單價;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.DataGridView dgv訂單明細;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txt店名;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn加;
        private System.Windows.Forms.Button btn減;
        private System.Windows.Forms.Button btnFavorite;
    }
}