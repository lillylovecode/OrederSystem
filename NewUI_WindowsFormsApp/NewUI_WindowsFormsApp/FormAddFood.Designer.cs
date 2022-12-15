
namespace NewUI_WindowsFormsApp
{
    partial class FormAddFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv品項列表 = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtShopID = new System.Windows.Forms.TextBox();
            this.btn選擇圖片 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btn清除欄位 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv品項列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv品項列表
            // 
            this.dgv品項列表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv品項列表.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv品項列表.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.dgv品項列表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("文鼎中特廣告體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv品項列表.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv品項列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv品項列表.Location = new System.Drawing.Point(24, 239);
            this.dgv品項列表.Name = "dgv品項列表";
            this.dgv品項列表.ReadOnly = true;
            this.dgv品項列表.RowHeadersWidth = 51;
            this.dgv品項列表.RowTemplate.Height = 27;
            this.dgv品項列表.Size = new System.Drawing.Size(745, 319);
            this.dgv品項列表.TabIndex = 0;
            this.dgv品項列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv品項列表_CellClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(336, 115);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(252, 32);
            this.txtPrice.TabIndex = 15;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFoodName.Location = new System.Drawing.Point(336, 77);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(252, 32);
            this.txtFoodName.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(36, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(250, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(250, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "品名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(250, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "店名";
            // 
            // txtShopName
            // 
            this.txtShopName.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShopName.Location = new System.Drawing.Point(337, 39);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(252, 32);
            this.txtShopName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(30, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "店家id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(30, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "商品id";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFoodID.Location = new System.Drawing.Point(150, 39);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(80, 32);
            this.txtFoodID.TabIndex = 16;
            // 
            // txtShopID
            // 
            this.txtShopID.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShopID.Location = new System.Drawing.Point(150, 83);
            this.txtShopID.Name = "txtShopID";
            this.txtShopID.Size = new System.Drawing.Size(80, 32);
            this.txtShopID.TabIndex = 16;
            // 
            // btn選擇圖片
            // 
            this.btn選擇圖片.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btn選擇圖片.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn選擇圖片.Font = new System.Drawing.Font("文鼎中特廣告體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn選擇圖片.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn選擇圖片.Location = new System.Drawing.Point(639, 179);
            this.btn選擇圖片.Name = "btn選擇圖片";
            this.btn選擇圖片.Size = new System.Drawing.Size(100, 31);
            this.btn選擇圖片.TabIndex = 11;
            this.btn選擇圖片.Text = "選擇圖片";
            this.btn選擇圖片.UseVisualStyleBackColor = false;
            this.btn選擇圖片.Click += new System.EventHandler(this.btn選擇圖片_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(161, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRenew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRenew.Location = new System.Drawing.Point(286, 179);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(119, 38);
            this.btnRenew.TabIndex = 11;
            this.btnRenew.Text = "修改";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btn清除欄位
            // 
            this.btn清除欄位.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btn清除欄位.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清除欄位.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除欄位.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn清除欄位.Location = new System.Drawing.Point(459, 179);
            this.btn清除欄位.Name = "btn清除欄位";
            this.btn清除欄位.Size = new System.Drawing.Size(130, 38);
            this.btn清除欄位.TabIndex = 11;
            this.btn清除欄位.Text = "清除欄位";
            this.btn清除欄位.UseVisualStyleBackColor = false;
            this.btn清除欄位.Click += new System.EventHandler(this.btn清除欄位_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewUI_WindowsFormsApp.Properties.Resources.空;
            this.pictureBox1.Location = new System.Drawing.Point(610, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FormAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(790, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtShopID);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.btn選擇圖片);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn清除欄位);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv品項列表);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddFood";
            this.Text = "FormAddFood";
            this.Load += new System.EventHandler(this.FormAddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv品項列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv品項列表;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtShopID;
        private System.Windows.Forms.Button btn選擇圖片;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btn清除欄位;
    }
}