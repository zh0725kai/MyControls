namespace FrmTestControls
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.thermometer1 = new MyControls.Thermometer();
            this.SuspendLayout();
            // 
            // thermometer1
            // 
            this.thermometer1.AutoSize = true;
            this.thermometer1.BackColor = System.Drawing.SystemColors.Control;
            this.thermometer1.BigScale = 5;
            this.thermometer1.BigScaleColor = System.Drawing.Color.Lime;
            this.thermometer1.DialBackColor = System.Drawing.Color.Gray;
            this.thermometer1.DialOutLineColor = System.Drawing.Color.Gray;
            this.thermometer1.DrawColor = System.Drawing.Color.Yellow;
            this.thermometer1.DrawFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.thermometer1.Location = new System.Drawing.Point(65, 56);
            this.thermometer1.MaximumSize = new System.Drawing.Size(400, 2000);
            this.thermometer1.MaxTemperature = 50F;
            this.thermometer1.MercuryBackColor = System.Drawing.Color.LightGray;
            this.thermometer1.MercuryColor = System.Drawing.Color.Red;
            this.thermometer1.MinimumSize = new System.Drawing.Size(40, 200);
            this.thermometer1.MinTemperature = 0F;
            this.thermometer1.Name = "thermometer1";
            this.thermometer1.Size = new System.Drawing.Size(72, 381);
            this.thermometer1.SmallScale = 10;
            this.thermometer1.SmallScaleColor = System.Drawing.Color.Black;
            this.thermometer1.TabIndex = 0;
            this.thermometer1.TempColor = System.Drawing.Color.Red;
            this.thermometer1.Temperature = 12.5F;
            this.thermometer1.TempFont = new System.Drawing.Font("宋体", 12F);
            this.thermometer1.TempTextEnable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 643);
            this.Controls.Add(this.thermometer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.Thermometer thermometer1;
    }
}

