namespace Caesar
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vigenereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChuyenVigenere = new System.Windows.Forms.Button();
            this.btnDichVigenere = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaVigenere = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVigenere = new System.Windows.Forms.TextBox();
            this.txtKeyVegenere = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caesarToolStripMenuItem,
            this.vigenereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caesarToolStripMenuItem
            // 
            this.caesarToolStripMenuItem.Name = "caesarToolStripMenuItem";
            this.caesarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.caesarToolStripMenuItem.Text = "Caesar";
            // 
            // vigenereToolStripMenuItem
            // 
            this.vigenereToolStripMenuItem.Name = "vigenereToolStripMenuItem";
            this.vigenereToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.vigenereToolStripMenuItem.Text = "Vigenere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Dòng Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChuyenVigenere
            // 
            this.btnChuyenVigenere.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenVigenere.Image")));
            this.btnChuyenVigenere.Location = new System.Drawing.Point(420, 164);
            this.btnChuyenVigenere.Name = "btnChuyenVigenere";
            this.btnChuyenVigenere.Size = new System.Drawing.Size(84, 43);
            this.btnChuyenVigenere.TabIndex = 26;
            this.btnChuyenVigenere.UseVisualStyleBackColor = true;
            this.btnChuyenVigenere.Click += new System.EventHandler(this.btnChuyenVigenere_Click);
            // 
            // btnDichVigenere
            // 
            this.btnDichVigenere.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVigenere.Image")));
            this.btnDichVigenere.Location = new System.Drawing.Point(420, 229);
            this.btnDichVigenere.Name = "btnDichVigenere";
            this.btnDichVigenere.Size = new System.Drawing.Size(84, 42);
            this.btnDichVigenere.TabIndex = 25;
            this.btnDichVigenere.UseVisualStyleBackColor = true;
            this.btnDichVigenere.Click += new System.EventHandler(this.btnDichVigenere_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaVigenere);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(514, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 283);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Văn bản mã hóa";
            // 
            // txtMaVigenere
            // 
            this.txtMaVigenere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaVigenere.Location = new System.Drawing.Point(21, 27);
            this.txtMaVigenere.Multiline = true;
            this.txtMaVigenere.Name = "txtMaVigenere";
            this.txtMaVigenere.Size = new System.Drawing.Size(342, 216);
            this.txtMaVigenere.TabIndex = 0;
            this.txtMaVigenere.TextChanged += new System.EventHandler(this.txtMaVegenere_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVigenere);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 283);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Văn bản";
            // 
            // txtVigenere
            // 
            this.txtVigenere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVigenere.Location = new System.Drawing.Point(21, 28);
            this.txtVigenere.Multiline = true;
            this.txtVigenere.Name = "txtVigenere";
            this.txtVigenere.Size = new System.Drawing.Size(342, 216);
            this.txtVigenere.TabIndex = 0;
            this.txtVigenere.Text = "HELLOWORLD";
            this.txtVigenere.TextChanged += new System.EventHandler(this.btnDichVinegere_Click);
            // 
            // txtKeyVegenere
            // 
            this.txtKeyVegenere.Location = new System.Drawing.Point(366, 59);
            this.txtKeyVegenere.Name = "txtKeyVegenere";
            this.txtKeyVegenere.Size = new System.Drawing.Size(215, 20);
            this.txtKeyVegenere.TabIndex = 28;
            this.txtKeyVegenere.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 437);
            this.Controls.Add(this.txtKeyVegenere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChuyenVigenere);
            this.Controls.Add(this.btnDichVigenere);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vigenereToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChuyenVigenere;
        private System.Windows.Forms.Button btnDichVigenere;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaVigenere;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVigenere;
        private System.Windows.Forms.TextBox txtKeyVegenere;
    }
}