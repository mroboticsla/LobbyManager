namespace ConfigStringEncoder
{
    partial class frm_main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.txt_Encoded = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ToEncode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_decode = new System.Windows.Forms.Button();
            this.txt_Decoded = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ToDecode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to Encode:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 251);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Encode);
            this.tabPage1.Controls.Add(this.txt_Encoded);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_ToEncode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Encode
            // 
            this.btn_Encode.Location = new System.Drawing.Point(389, 194);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(75, 23);
            this.btn_Encode.TabIndex = 4;
            this.btn_Encode.Text = "Encode";
            this.btn_Encode.UseVisualStyleBackColor = true;
            this.btn_Encode.Click += new System.EventHandler(this.btn_Encode_Click);
            // 
            // txt_Encoded
            // 
            this.txt_Encoded.Location = new System.Drawing.Point(95, 102);
            this.txt_Encoded.Multiline = true;
            this.txt_Encoded.Name = "txt_Encoded";
            this.txt_Encoded.ReadOnly = true;
            this.txt_Encoded.Size = new System.Drawing.Size(369, 81);
            this.txt_Encoded.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result:";
            // 
            // txt_ToEncode
            // 
            this.txt_ToEncode.Location = new System.Drawing.Point(95, 15);
            this.txt_ToEncode.Multiline = true;
            this.txt_ToEncode.Name = "txt_ToEncode";
            this.txt_ToEncode.Size = new System.Drawing.Size(369, 81);
            this.txt_ToEncode.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_decode);
            this.tabPage2.Controls.Add(this.txt_Decoded);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_ToDecode);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_decode
            // 
            this.btn_decode.Location = new System.Drawing.Point(390, 190);
            this.btn_decode.Name = "btn_decode";
            this.btn_decode.Size = new System.Drawing.Size(75, 23);
            this.btn_decode.TabIndex = 9;
            this.btn_decode.Text = "Decode";
            this.btn_decode.UseVisualStyleBackColor = true;
            this.btn_decode.Click += new System.EventHandler(this.btn_decode_Click);
            // 
            // txt_Decoded
            // 
            this.txt_Decoded.Location = new System.Drawing.Point(96, 98);
            this.txt_Decoded.Multiline = true;
            this.txt_Decoded.Name = "txt_Decoded";
            this.txt_Decoded.ReadOnly = true;
            this.txt_Decoded.Size = new System.Drawing.Size(369, 81);
            this.txt_Decoded.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result:";
            // 
            // txt_ToDecode
            // 
            this.txt_ToDecode.Location = new System.Drawing.Point(96, 11);
            this.txt_ToDecode.Multiline = true;
            this.txt_ToDecode.Name = "txt_ToDecode";
            this.txt_ToDecode.Size = new System.Drawing.Size(369, 81);
            this.txt_ToDecode.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Text to Decode:";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 251);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_main";
            this.Text = "M-Robotics ConfigString Encoder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.TextBox txt_Encoded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ToEncode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_decode;
        private System.Windows.Forms.TextBox txt_Decoded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ToDecode;
        private System.Windows.Forms.Label label4;
    }
}

