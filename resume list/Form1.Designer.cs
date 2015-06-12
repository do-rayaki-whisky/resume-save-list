namespace resume_list
{
    partial class form1_main
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
            this.textbox_paste_name = new System.Windows.Forms.TextBox();
            this.btn_save_name = new System.Windows.Forms.Button();
            this.textbox_view_name = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_paste_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_paste_name
            // 
            this.textbox_paste_name.Location = new System.Drawing.Point(64, 38);
            this.textbox_paste_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_paste_name.Multiline = true;
            this.textbox_paste_name.Name = "textbox_paste_name";
            this.textbox_paste_name.Size = new System.Drawing.Size(293, 26);
            this.textbox_paste_name.TabIndex = 0;
            this.textbox_paste_name.Click += new System.EventHandler(this.textBox1_Click);
            this.textbox_paste_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_save_name
            // 
            this.btn_save_name.Location = new System.Drawing.Point(375, 36);
            this.btn_save_name.Name = "btn_save_name";
            this.btn_save_name.Size = new System.Drawing.Size(75, 31);
            this.btn_save_name.TabIndex = 1;
            this.btn_save_name.Text = "บันทึก";
            this.btn_save_name.UseVisualStyleBackColor = true;
            this.btn_save_name.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_view_name
            // 
            this.textbox_view_name.Location = new System.Drawing.Point(64, 74);
            this.textbox_view_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_view_name.Name = "textbox_view_name";
            this.textbox_view_name.ReadOnly = true;
            this.textbox_view_name.Size = new System.Drawing.Size(293, 26);
            this.textbox_view_name.TabIndex = 2;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(60, 125);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(53, 20);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "status";
            // 
            // label_paste_name
            // 
            this.label_paste_name.AutoSize = true;
            this.label_paste_name.Location = new System.Drawing.Point(12, 41);
            this.label_paste_name.Name = "label_paste_name";
            this.label_paste_name.Size = new System.Drawing.Size(41, 20);
            this.label_paste_name.TabIndex = 4;
            this.label_paste_name.Text = "ใส่ชื่อ";
            // 
            // form1_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 170);
            this.Controls.Add(this.label_paste_name);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.textbox_view_name);
            this.Controls.Add(this.btn_save_name);
            this.Controls.Add(this.textbox_paste_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form1_main";
            this.Text = "จัดเก็บรายชื่อใบสมัคร";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_paste_name;
        private System.Windows.Forms.Button btn_save_name;
        private System.Windows.Forms.TextBox textbox_view_name;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_paste_name;
    }
}

