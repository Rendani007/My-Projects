namespace speech2Text
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Browser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.convertBtn = new ePOSOne.btnProduct.Button_WOC();
            this.audioSaveBtn = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC5 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC4 = new ePOSOne.btnProduct.Button_WOC();
            this.recordBtn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFile
            // 
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(581, 296);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Rich Text Format|.rtf";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(531, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.convertBtn);
            this.panel1.Controls.Add(this.audioSaveBtn);
            this.panel1.Controls.Add(this.button_WOC5);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button_WOC4);
            this.panel1.Controls.Add(this.recordBtn);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 497);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // convertBtn
            // 
            this.convertBtn.BorderColor = System.Drawing.Color.Orange;
            this.convertBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.convertBtn.FlatAppearance.BorderSize = 0;
            this.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.Location = new System.Drawing.Point(402, 339);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.convertBtn.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.convertBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.convertBtn.Size = new System.Drawing.Size(128, 42);
            this.convertBtn.TabIndex = 16;
            this.convertBtn.Text = "Convert to text";
            this.convertBtn.TextColor = System.Drawing.Color.White;
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.Button_WOC2_Click_1);
            // 
            // audioSaveBtn
            // 
            this.audioSaveBtn.BorderColor = System.Drawing.Color.Orange;
            this.audioSaveBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.audioSaveBtn.FlatAppearance.BorderSize = 0;
            this.audioSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioSaveBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioSaveBtn.Location = new System.Drawing.Point(228, 339);
            this.audioSaveBtn.Name = "audioSaveBtn";
            this.audioSaveBtn.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.audioSaveBtn.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.audioSaveBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.audioSaveBtn.Size = new System.Drawing.Size(128, 42);
            this.audioSaveBtn.TabIndex = 15;
            this.audioSaveBtn.Text = "Save";
            this.audioSaveBtn.TextColor = System.Drawing.Color.White;
            this.audioSaveBtn.UseVisualStyleBackColor = false;
            this.audioSaveBtn.Click += new System.EventHandler(this.Button_WOC1_Click_1);
            // 
            // button_WOC5
            // 
            this.button_WOC5.BorderColor = System.Drawing.Color.Orange;
            this.button_WOC5.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC5.FlatAppearance.BorderSize = 0;
            this.button_WOC5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC5.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC5.Location = new System.Drawing.Point(312, 411);
            this.button_WOC5.Name = "button_WOC5";
            this.button_WOC5.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.button_WOC5.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.button_WOC5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC5.Size = new System.Drawing.Size(128, 42);
            this.button_WOC5.TabIndex = 14;
            this.button_WOC5.Text = "Export to text file";
            this.button_WOC5.TextColor = System.Drawing.Color.White;
            this.button_WOC5.UseVisualStyleBackColor = false;
            this.button_WOC5.Click += new System.EventHandler(this.Button_WOC5_Click);
            // 
            // button_WOC4
            // 
            this.button_WOC4.BorderColor = System.Drawing.Color.Orange;
            this.button_WOC4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC4.FlatAppearance.BorderSize = 0;
            this.button_WOC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC4.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC4.Location = new System.Drawing.Point(140, 411);
            this.button_WOC4.Name = "button_WOC4";
            this.button_WOC4.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.button_WOC4.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.button_WOC4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.button_WOC4.Size = new System.Drawing.Size(128, 42);
            this.button_WOC4.TabIndex = 13;
            this.button_WOC4.Text = "Play audio again";
            this.button_WOC4.TextColor = System.Drawing.Color.White;
            this.button_WOC4.UseVisualStyleBackColor = false;
            this.button_WOC4.Click += new System.EventHandler(this.Button_WOC4_Click);
            // 
            // recordBtn
            // 
            this.recordBtn.BorderColor = System.Drawing.Color.Orange;
            this.recordBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.recordBtn.FlatAppearance.BorderSize = 0;
            this.recordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordBtn.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordBtn.Location = new System.Drawing.Point(60, 339);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.OnHoverBorderColor = System.Drawing.Color.Orange;
            this.recordBtn.OnHoverButtonColor = System.Drawing.Color.Orange;
            this.recordBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.recordBtn.Size = new System.Drawing.Size(128, 42);
            this.recordBtn.TabIndex = 10;
            this.recordBtn.Text = "Record";
            this.recordBtn.TextColor = System.Drawing.Color.White;
            this.recordBtn.UseVisualStyleBackColor = false;
            this.recordBtn.Click += new System.EventHandler(this.Button_WOC1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(612, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog Browser;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC recordBtn;
        private ePOSOne.btnProduct.Button_WOC button_WOC4;
        private ePOSOne.btnProduct.Button_WOC button_WOC5;
        private ePOSOne.btnProduct.Button_WOC convertBtn;
        private ePOSOne.btnProduct.Button_WOC audioSaveBtn;
    }
}

