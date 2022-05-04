
namespace CPAU
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.accountText = new System.Windows.Forms.TextBox();
            this.PasswdText = new System.Windows.Forms.TextBox();
            this.PathText = new System.Windows.Forms.TextBox();
            this.ExportB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EndLab = new System.Windows.Forms.Label();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountText
            // 
            this.accountText.Location = new System.Drawing.Point(47, 19);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(145, 22);
            this.accountText.TabIndex = 0;
            // 
            // PasswdText
            // 
            this.PasswdText.Location = new System.Drawing.Point(47, 56);
            this.PasswdText.Name = "PasswdText";
            this.PasswdText.PasswordChar = '*';
            this.PasswdText.Size = new System.Drawing.Size(145, 22);
            this.PasswdText.TabIndex = 1;
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(7, 101);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(299, 22);
            this.PathText.TabIndex = 2;
            // 
            // ExportB
            // 
            this.ExportB.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExportB.Location = new System.Drawing.Point(204, 52);
            this.ExportB.Name = "ExportB";
            this.ExportB.Size = new System.Drawing.Size(102, 43);
            this.ExportB.TabIndex = 3;
            this.ExportB.Text = "產生";
            this.ExportB.UseVisualStyleBackColor = true;
            this.ExportB.Click += new System.EventHandler(this.ExportB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "檔案路徑";
            // 
            // EndLab
            // 
            this.EndLab.AutoSize = true;
            this.EndLab.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EndLab.ForeColor = System.Drawing.Color.Red;
            this.EndLab.Location = new System.Drawing.Point(200, 25);
            this.EndLab.Name = "EndLab";
            this.EndLab.Size = new System.Drawing.Size(0, 16);
            this.EndLab.TabIndex = 7;
            // 
            // KeyText
            // 
            this.KeyText.Location = new System.Drawing.Point(7, 143);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(299, 22);
            this.KeyText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(4, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 177);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.EndLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportB);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.PasswdText);
            this.Controls.Add(this.accountText);
            this.Name = "Form1";
            this.Text = "CPAU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.TextBox PasswdText;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button ExportB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EndLab;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.Label label4;
    }
}

