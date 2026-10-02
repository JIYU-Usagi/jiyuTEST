namespace Modless
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(15, 117);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 38);
            button1.TabIndex = 0;
            button1.Text = "슬라브 생성";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "슬라브";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(324, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(19, 15);
            label2.TabIndex = 3;
            label2.Text = "벽";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(324, 117);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(121, 38);
            button2.TabIndex = 2;
            button2.Text = "벽 생성";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(475, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "천장";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(475, 114);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(121, 41);
            button3.TabIndex = 4;
            button3.Text = "천장 생성";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(167, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "기둥";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(167, 117);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(121, 38);
            button4.TabIndex = 6;
            button4.Text = "기둥 생성";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(15, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(324, 49);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(475, 49);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(121, 23);
            comboBox3.TabIndex = 10;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(167, 49);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(121, 23);
            comboBox4.TabIndex = 11;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(633, 191);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Sample Test";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}
