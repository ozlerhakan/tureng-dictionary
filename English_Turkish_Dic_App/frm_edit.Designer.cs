namespace English_Turkish_Dic_App
{
    partial class frm_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_edit));
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(15, 82);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(118, 22);
            this.txtTur.TabIndex = 0;
            this.txtTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTur_KeyPress);
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(15, 29);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(118, 22);
            this.txtEng.TabIndex = 1;
            this.txtEng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEng_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "English Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turkish Word";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(15, 111);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(118, 27);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Save";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frm_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 154);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtTur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Word Edit";
            this.Load += new System.EventHandler(this.frm_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
    }
}