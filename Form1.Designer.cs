namespace Example10
{
    partial class 年齢判定
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJudge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(208, 42);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(75, 23);
            this.btnJudge.TabIndex = 0;
            this.btnJudge.Text = "判定";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "年齢は";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(104, 131);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 12);
            this.lblresult.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "歳";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(57, 40);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(88, 19);
            this.tbxAge.TabIndex = 4;
            // 
            // 年齢判定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJudge);
            this.Name = "年齢判定";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAge;
    }
}

