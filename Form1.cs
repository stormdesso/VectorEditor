using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorEditor
{
    public partial class Form1 : Form
    {
        Controller.IController IContrl;
        
        public Form1(object model)
        {            
            InitializeComponent();
            IContrl = new Controller.Controller(model);
            IContrl.Model.GrController.SetPort(panel1.CreateGraphics());

            this.KeyPreview = true;
        }        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {           
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
                           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonContourColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog d = new ColorDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    IContrl.Model.GrProperties.ContourProps.Color = d.Color;   
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ColorDialog d = new ColorDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    IContrl.Model.GrProperties.FillProps.Color = d.Color;   
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            IContrl.Model.GrProperties.ContourProps.Thickness = trackBarBrush.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
                IContrl.Model.Factory.itemType = Model.Interface.ItemType.Line;
            else
                if (comboBox2.SelectedIndex == 2)
                    IContrl.Model.Factory.itemType = Model.Interface.ItemType.Rect;
            else
                if (comboBox2.SelectedIndex == 3)
                    IContrl.Model.Factory.itemType = Model.Interface.ItemType.Ellipse;
            else
                if (comboBox2.SelectedIndex == 4)
                    IContrl.Model.Factory.itemType = Model.Interface.ItemType.Text;

            IContrl.IEvHandler.EscPress();//сбрасываем всё
            IContrl.IEvHandler.SetDefaultState();//принудительно переходим в состояние create state
            IContrl.Model.GrController.Repaint();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //IContrl.Model.GrController.SetPort(panel1.CreateGraphics());
            IContrl.Model.GrController.Repaint();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            IContrl.IEvHandler.CtrlIsPressed = (Control.ModifierKeys == Keys.Control);

            if (e.Button == MouseButtons.Left & comboBox2.SelectedIndex != -1 & comboBox2.SelectedIndex != 0)
            {
                int x = e.X;
                int y = e.Y;
                IContrl.IEvHandler.LeftMouseUp(x, y);
                IContrl.Model.GrController.Repaint();

                string text = IContrl.IEvHandler.SetCurrentTextInTextBox();
                if (text != null)
                    textBox1.Text = text;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {           
            IContrl.IEvHandler.CtrlIsPressed = (Control.ModifierKeys == Keys.Control);            

            if (e.Button == MouseButtons.Left & comboBox2.SelectedIndex != -1 & comboBox2.SelectedIndex != 0)
            {
                int x = e.X;
                int y = e.Y;
                IContrl.IEvHandler.LeftMouseMove(x, y);
                IContrl.Model.GrController.Repaint();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IContrl.IEvHandler.CtrlIsPressed = (Control.ModifierKeys == Keys.Control);

            if (e.Button == MouseButtons.Left & comboBox2.SelectedIndex != -1 & comboBox2.SelectedIndex != 0)
            {
                int x = e.X;
                int y = e.Y;
                IContrl.IEvHandler.LeftMouseDown(x, y);
                IContrl.Model.GrController.Repaint();

                              
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                IContrl.IEvHandler.EscPress();
            }

            if (e.KeyValue == (char)Keys.Delete)
            {
                IContrl.IEvHandler.Delete();
            }
                        
            IContrl.Model.GrController.Repaint();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IContrl.IEvHandler.CtrlIsPressed = !(IContrl.IEvHandler.CtrlIsPressed);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            IContrl.IEvHandler.Grouping();
            IContrl.Model.GrController.Repaint();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            IContrl.IEvHandler.Ungrouping();
            IContrl.Model.GrController.Repaint();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            //textBox1.Text = IContrl.IEvHandler.SetCurrentTextInTextBox();
            IContrl.IEvHandler.UpdateText(textBox1.Text);
            IContrl.Model.GrController.Repaint();
        }

        private void ButtonFontColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog d = new ColorDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {
                    IContrl.Model.GrProperties.TextProps.Color = d.Color;
                }
            }
        }

        private void trackBarFont_Scroll(object sender, EventArgs e)
        {
        }

        private void buttonFontStyle_Click(object sender, EventArgs e)
        {
            using (FontDialog d = new FontDialog())
            {
                if (d.ShowDialog() == DialogResult.OK)
                {                    
                    IContrl.Model.GrProperties.TextProps.GeneralFontSettings = d.Font;
                }
            }
        }
    }
}