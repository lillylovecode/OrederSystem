
namespace NewUI_WindowsFormsApp
{
    partial class FormFavorite
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv最愛 = new System.Windows.Forms.DataGridView();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.txt單價 = new System.Windows.Forms.TextBox();
            this.txt店名 = new System.Windows.Forms.TextBox();
            this.txt品名 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn訂餐 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv最愛)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的最愛";
            // 
            // dgv最愛
            // 
            this.dgv最愛.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv最愛.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv最愛.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.dgv最愛.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv最愛.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv最愛.GridColor = System.Drawing.Color.White;
            this.dgv最愛.Location = new System.Drawing.Point(36, 72);
            this.dgv最愛.Name = "dgv最愛";
            this.dgv最愛.RowHeadersWidth = 51;
            this.dgv最愛.RowTemplate.Height = 27;
            this.dgv最愛.Size = new System.Drawing.Size(727, 210);
            this.dgv最愛.TabIndex = 1;
            this.dgv最愛.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv最愛_CellClick);
            // 
            // btn刪除
            // 
            this.btn刪除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btn刪除.Font = new System.Drawing.Font("文鼎中特廣告體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.ForeColor = System.Drawing.Color.White;
            this.btn刪除.Location = new System.Drawing.Point(594, 288);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(169, 40);
            this.btn刪除.TabIndex = 2;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = false;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(336, 466);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(48, 32);
            this.txt數量.TabIndex = 12;
            this.txt數量.Text = "1";
            // 
            // txt單價
            // 
            this.txt單價.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt單價.Location = new System.Drawing.Point(165, 463);
            this.txt單價.Name = "txt單價";
            this.txt單價.Size = new System.Drawing.Size(70, 32);
            this.txt單價.TabIndex = 13;
            // 
            // txt店名
            // 
            this.txt店名.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt店名.Location = new System.Drawing.Point(165, 319);
            this.txt店名.Name = "txt店名";
            this.txt店名.Size = new System.Drawing.Size(252, 32);
            this.txt店名.TabIndex = 14;
            // 
            // txt品名
            // 
            this.txt品名.Font = new System.Drawing.Font("文鼎中特廣告體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt品名.Location = new System.Drawing.Point(165, 388);
            this.txt品名.Name = "txt品名";
            this.txt品名.Size = new System.Drawing.Size(252, 32);
            this.txt品名.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(249, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(78, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "單價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(78, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "品名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("文鼎中特廣告體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(78, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "店名";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewUI_WindowsFormsApp.Properties.Resources.astronaut;
            this.pictureBox1.Location = new System.Drawing.Point(594, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn訂餐
            // 
            this.btn訂餐.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(229)))));
            this.btn訂餐.Font = new System.Drawing.Font("文鼎中特廣告體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂餐.ForeColor = System.Drawing.Color.White;
            this.btn訂餐.Location = new System.Drawing.Point(442, 319);
            this.btn訂餐.Name = "btn訂餐";
            this.btn訂餐.Size = new System.Drawing.Size(121, 101);
            this.btn訂餐.TabIndex = 2;
            this.btn訂餐.Text = "訂餐";
            this.btn訂餐.UseVisualStyleBackColor = false;
            this.btn訂餐.Click += new System.EventHandler(this.btn訂餐_Click);
            // 
            // FormFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(83)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(790, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.txt單價);
            this.Controls.Add(this.txt店名);
            this.Controls.Add(this.txt品名);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn訂餐);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.dgv最愛);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFavorite";
            this.Text = "FormFavorite";
            this.Load += new System.EventHandler(this.FormFavorite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv最愛)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv最愛;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.TextBox txt單價;
        private System.Windows.Forms.TextBox txt店名;
        private System.Windows.Forms.TextBox txt品名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn訂餐;
    }
}