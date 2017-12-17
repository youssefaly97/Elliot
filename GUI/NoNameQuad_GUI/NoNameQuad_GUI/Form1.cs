using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    public partial class Form1 : Form
    {
        Controller myController;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Serv180_Click(object sender, EventArgs e)
        {

        }

        private void button_applyChanges_t1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkbox_leg_t1.Checked == false)
                    myController.moveServo(byte.Parse(comboBox_legNumber_t1.Text), byte.Parse(textbox_alpha_t1.Text), byte.Parse(textbox_beta_t1.Text), byte.Parse(textbox_gamma_t1.Text));
                else
                    for (byte i = 0; i < 4; ++i)
                        myController.moveServo(i, byte.Parse(textbox_alpha_t1.Text), byte.Parse(textbox_beta_t1.Text), byte.Parse(textbox_gamma_t1.Text));
            }
            catch
            {
                MessageBox.Show("ERROR");

            }
       }

        private void button_apply_t2_Click(object sender, EventArgs e)
        {
            try
            {
                myController.moveLeg(int.Parse(comboBox_legChoice_t2.Text), int.Parse(textbox_xHold_t2.Text), int.Parse(textbox_yHold_t2.Text), int.Parse(textbox_zHold_t2.Text));
                label_xCoord_t2.Text = "X: " + comboBox_legChoice_t2.Text;
                label_xCoord_t2.Text = "Y: " + comboBox_legChoice_t2.Text;
                label_xCoord_t2.Text = "Z: " + comboBox_legChoice_t2.Text;
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
         }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;

            myController = new Controller('s');
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            myController = new Controller('b');
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            myController = new Controller('s');
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            myController = new Controller('b');
        }

        private void pictureBox_servos_t2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkbox_leg_t1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_leg_t1.Checked == true)
                comboBox_legNumber_t1.Enabled = false;
            else
                comboBox_legNumber_t1.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            myController = new Controller('s');
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            myController = new Controller('b');
        }

        private void comboBox_legNumber_t1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_legChoice_t2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textbox_gamma_t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}