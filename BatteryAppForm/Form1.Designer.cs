namespace BatteryAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.persent_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.battery_progress = new System.Windows.Forms.ProgressBar();
            this.ReLoad_Button = new System.Windows.Forms.Button();
            this.zyoukyou = new System.Windows.Forms.Label();
            this.zyuden = new System.Windows.Forms.Label();
            this.hourlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minites = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // persent_label
            // 
            resources.ApplyResources(this.persent_label, "persent_label");
            this.persent_label.Name = "persent_label";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // battery_progress
            // 
            resources.ApplyResources(this.battery_progress, "battery_progress");
            this.battery_progress.Name = "battery_progress";
            this.battery_progress.Value = 50;
            // 
            // ReLoad_Button
            // 
            resources.ApplyResources(this.ReLoad_Button, "ReLoad_Button");
            this.ReLoad_Button.Name = "ReLoad_Button";
            this.ReLoad_Button.UseVisualStyleBackColor = true;
            this.ReLoad_Button.Click += new System.EventHandler(this.ReLoad_Button_Click);
            // 
            // zyoukyou
            // 
            resources.ApplyResources(this.zyoukyou, "zyoukyou");
            this.zyoukyou.Name = "zyoukyou";
            // 
            // zyuden
            // 
            resources.ApplyResources(this.zyuden, "zyuden");
            this.zyuden.Name = "zyuden";
            // 
            // hourlabel
            // 
            resources.ApplyResources(this.hourlabel, "hourlabel");
            this.hourlabel.Name = "hourlabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // minites
            // 
            resources.ApplyResources(this.minites, "minites");
            this.minites.Name = "minites";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // second
            // 
            resources.ApplyResources(this.second, "second");
            this.second.Name = "second";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minites);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hourlabel);
            this.Controls.Add(this.zyuden);
            this.Controls.Add(this.zyoukyou);
            this.Controls.Add(this.ReLoad_Button);
            this.Controls.Add(this.battery_progress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.persent_label);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();
            this.TransparencyKey = this.BackColor;

        }

        #endregion

        private System.Windows.Forms.Label persent_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar battery_progress;
        private System.Windows.Forms.Button ReLoad_Button;
        private System.Windows.Forms.Label zyoukyou;
        private System.Windows.Forms.Label zyuden;
        private System.Windows.Forms.Label hourlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minites;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label label4;
    }
}

