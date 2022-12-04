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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {           
            if (e.Button == MouseButtons.Left & comboBox2.SelectedIndex != -1 & comboBox2.SelectedIndex != 0)
            {
                int x = e.X;
                int y = e.Y;
                IContrl.IEvHandler.LeftMouseUp(x, y);                
                IContrl.Model.GrController.Repaint();               
            }
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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            IContrl.Model.GrProperties.ContourProps.Thickness = trackBar1.Value;
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
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
            if (e.Button == MouseButtons.Left & comboBox2.SelectedIndex != -1 & comboBox2.SelectedIndex != 0)
            {
                int x = e.X;
                int y = e.Y;
                IContrl.IEvHandler.LeftMouseDown(x, y);
                IContrl.Model.GrController.Repaint();
            }
        }
    }
}