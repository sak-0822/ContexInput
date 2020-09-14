namespace ContexInput
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label_NumberOfInputCH = new System.Windows.Forms.Label();
            this.numericUpDown_NumberOfImputCH = new System.Windows.Forms.NumericUpDown();
            this.label_Method = new System.Windows.Forms.Label();
            this.comboBox_Method = new System.Windows.Forms.ComboBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Finish = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label_SumplingRate = new System.Windows.Forms.Label();
            this.textBox_SamplingRate = new System.Windows.Forms.TextBox();
            this.comboBox_Hz = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfImputCH)).BeginInit();
            this.SuspendLayout();
            // 
            // label_NumberOfInputCH
            // 
            this.label_NumberOfInputCH.AutoSize = true;
            this.label_NumberOfInputCH.Location = new System.Drawing.Point(82, 78);
            this.label_NumberOfInputCH.Name = "label_NumberOfInputCH";
            this.label_NumberOfInputCH.Size = new System.Drawing.Size(113, 24);
            this.label_NumberOfInputCH.TabIndex = 0;
            this.label_NumberOfInputCH.Text = "入力CH数";
            this.label_NumberOfInputCH.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown_NumberOfImputCH
            // 
            this.numericUpDown_NumberOfImputCH.Location = new System.Drawing.Point(86, 129);
            this.numericUpDown_NumberOfImputCH.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown_NumberOfImputCH.Name = "numericUpDown_NumberOfImputCH";
            this.numericUpDown_NumberOfImputCH.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown_NumberOfImputCH.TabIndex = 1;
            // 
            // label_Method
            // 
            this.label_Method.AutoSize = true;
            this.label_Method.Location = new System.Drawing.Point(82, 191);
            this.label_Method.Name = "label_Method";
            this.label_Method.Size = new System.Drawing.Size(106, 24);
            this.label_Method.TabIndex = 2;
            this.label_Method.Text = "入力方式";
            this.label_Method.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox_Method
            // 
            this.comboBox_Method.FormattingEnabled = true;
            this.comboBox_Method.Location = new System.Drawing.Point(86, 238);
            this.comboBox_Method.Name = "comboBox_Method";
            this.comboBox_Method.Size = new System.Drawing.Size(121, 32);
            this.comboBox_Method.TabIndex = 3;
            this.comboBox_Method.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(79, 523);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(164, 52);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "リセット";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // button_Finish
            // 
            this.button_Finish.Location = new System.Drawing.Point(541, 523);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(144, 52);
            this.button_Finish.TabIndex = 5;
            this.button_Finish.Text = "入力終了";
            this.button_Finish.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(304, 523);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(155, 52);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "入力開始";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // label_SumplingRate
            // 
            this.label_SumplingRate.AutoSize = true;
            this.label_SumplingRate.Location = new System.Drawing.Point(82, 331);
            this.label_SumplingRate.Name = "label_SumplingRate";
            this.label_SumplingRate.Size = new System.Drawing.Size(171, 24);
            this.label_SumplingRate.TabIndex = 7;
            this.label_SumplingRate.Text = "サンプリングレート";
            // 
            // textBox_SamplingRate
            // 
            this.textBox_SamplingRate.Location = new System.Drawing.Point(86, 393);
            this.textBox_SamplingRate.Name = "textBox_SamplingRate";
            this.textBox_SamplingRate.Size = new System.Drawing.Size(149, 31);
            this.textBox_SamplingRate.TabIndex = 8;
            // 
            // comboBox_Hz
            // 
            this.comboBox_Hz.FormattingEnabled = true;
            this.comboBox_Hz.Location = new System.Drawing.Point(259, 393);
            this.comboBox_Hz.Name = "comboBox_Hz";
            this.comboBox_Hz.Size = new System.Drawing.Size(75, 32);
            this.comboBox_Hz.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 31);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 646);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_Hz);
            this.Controls.Add(this.textBox_SamplingRate);
            this.Controls.Add(this.label_SumplingRate);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.button_Finish);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.comboBox_Method);
            this.Controls.Add(this.label_Method);
            this.Controls.Add(this.numericUpDown_NumberOfImputCH);
            this.Controls.Add(this.label_NumberOfInputCH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfImputCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NumberOfInputCH;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfImputCH;
        private System.Windows.Forms.Label label_Method;
        private System.Windows.Forms.ComboBox comboBox_Method;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Finish;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label_SumplingRate;
        private System.Windows.Forms.TextBox textBox_SamplingRate;
        private System.Windows.Forms.ComboBox comboBox_Hz;
        private System.Windows.Forms.TextBox textBox1;
    }
}

