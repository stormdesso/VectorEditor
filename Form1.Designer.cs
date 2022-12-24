namespace VectorEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonContourColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBarBrush = new System.Windows.Forms.TrackBar();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonFontColor = new System.Windows.Forms.Button();
            this.buttonFontStyle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 380);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // buttonContourColor
            // 
            this.buttonContourColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonContourColor.Location = new System.Drawing.Point(110, 7);
            this.buttonContourColor.Name = "buttonContourColor";
            this.buttonContourColor.Size = new System.Drawing.Size(97, 23);
            this.buttonContourColor.TabIndex = 12;
            this.buttonContourColor.Text = "Brush color";
            this.buttonContourColor.UseVisualStyleBackColor = false;
            this.buttonContourColor.Click += new System.EventHandler(this.buttonContourColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(110, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Fill color";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBarBrush
            // 
            this.trackBarBrush.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBarBrush.Location = new System.Drawing.Point(213, 7);
            this.trackBarBrush.Name = "trackBarBrush";
            this.trackBarBrush.Size = new System.Drawing.Size(248, 45);
            this.trackBarBrush.TabIndex = 14;
            this.trackBarBrush.Value = 5;
            this.trackBarBrush.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "...",
            "Line",
            "Rect",
            "Ellipse",
            "Text"});
            this.comboBox2.Location = new System.Drawing.Point(22, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chosen figure:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ungrouping";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(467, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Grouping";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(587, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Text:";
            // 
            // ButtonFontColor
            // 
            this.ButtonFontColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFontColor.Location = new System.Drawing.Point(672, 29);
            this.ButtonFontColor.Name = "ButtonFontColor";
            this.ButtonFontColor.Size = new System.Drawing.Size(116, 23);
            this.ButtonFontColor.TabIndex = 25;
            this.ButtonFontColor.Text = "Font color";
            this.ButtonFontColor.UseVisualStyleBackColor = false;
            this.ButtonFontColor.Click += new System.EventHandler(this.ButtonFontColor_Click);
            // 
            // buttonFontStyle
            // 
            this.buttonFontStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFontStyle.Location = new System.Drawing.Point(553, 29);
            this.buttonFontStyle.Name = "buttonFontStyle";
            this.buttonFontStyle.Size = new System.Drawing.Size(116, 23);
            this.buttonFontStyle.TabIndex = 27;
            this.buttonFontStyle.Text = "Font style";
            this.buttonFontStyle.UseVisualStyleBackColor = false;
            this.buttonFontStyle.Click += new System.EventHandler(this.buttonFontStyle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonFontColor);
            this.Controls.Add(this.buttonFontStyle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.trackBarBrush);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonContourColor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrush)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonContourColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBarBrush;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonFontColor;
        private System.Windows.Forms.Button buttonFontStyle;
    }
}

