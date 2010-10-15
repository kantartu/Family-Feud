using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fast_Money
{
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer myPlayer;

        public Form1()
        {
            InitializeComponent();
             myPlayer = new System.Media.SoundPlayer();
        }

        //int TimerStart = 25;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    label2.Text = TimerStart--.ToString();
        //    if (label2.Text == "0")
        //    {
        //        timer1.Stop();
        //    }
        //}

        //private void textBox1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        timer1.Start();
        //    }
        //    if (e.KeyCode == Keys.F12)
        //    {
        //        myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\DUPLICATE.wav";
        //        myPlayer.Play();
        //    }
        //}

        private void SetQuestions1Enabled()
        {
            textBox1.Enabled = false; textBox2.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false; textBox5.Enabled = false;
            textBox20.Enabled = false; textBox19.Enabled = false; textBox18.Enabled = false; textBox17.Enabled = false; textBox16.Enabled = false;
        }

        private void SetQuestions2Enabled()
        {
            textBox6.Enabled = false; textBox7.Enabled = false; textBox8.Enabled = false; textBox9.Enabled = false; textBox10.Enabled = false;
            textBox11.Enabled = false; textBox12.Enabled = false; textBox13.Enabled = false; textBox14.Enabled = false; textBox15.Enabled = false;
        }

        private void SetQuestions1Invisible()
        {
            textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false; textBox4.Visible = false; textBox5.Visible = false;
            textBox20.Visible = false; textBox19.Visible = false; textBox18.Visible = false; textBox17.Visible = false; textBox16.Visible = false;
        }

        private void SetQuestions1Visible()
        {
            textBox1.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true;
            textBox20.Visible = true; textBox19.Visible = true; textBox18.Visible = true; textBox17.Visible = true; textBox16.Visible = true;
        }

        private void SetQuestions2Invisible()
        {
            textBox6.Visible = false; textBox7.Visible = false; textBox8.Visible = false; textBox9.Visible = false; textBox10.Visible = false;
            textBox11.Visible = false; textBox12.Visible = false; textBox13.Visible = false; textBox14.Visible = false; textBox15.Visible = false;
        }

        private void SetQuestions2Visible()
        {
            textBox6.Visible = true; textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true; textBox10.Visible = true;
            textBox11.Visible = true; textBox12.Visible = true; textBox13.Visible = true; textBox14.Visible = true; textBox15.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SetQuestions1Enabled(); SetQuestions1Invisible();
            timer1.Stop();
            label2.Text = "25";
            TimerStart = 25;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SetQuestions2Enabled(); SetQuestions2Invisible();
            timer1.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SetQuestions1Visible();
            }
            if (e.KeyCode == Keys.F2)
            {
                SetQuestions2Visible();
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox1.Visible = true; textBox20.Visible = true;
                textBox21.Text = int.Parse(textBox20.Text).ToString();
            }
            if (e.KeyCode == Keys.D2)
            {
                textBox2.Visible = true; textBox19.Visible = true;
                textBox21.Text = int.Parse(textBox21.Text + textBox19.Text).ToString();
            }
            if (e.KeyCode == Keys.D3)
            {
                textBox3.Visible = true; textBox18.Visible = true;
                textBox21.Text = int.Parse(textBox21.Text + textBox18.Text).ToString();
            }
            if (e.KeyCode == Keys.D4)
            {
                textBox4.Visible = true; textBox17.Visible = true;
                textBox21.Text = int.Parse(textBox21.Text + textBox17.Text).ToString();
            }
            if (e.KeyCode == Keys.D5)
            {
                textBox5.Visible = true; textBox16.Visible = true;
                textBox21.Text = int.Parse(textBox21.Text + textBox16.Text).ToString();
            }


            if (e.KeyCode == Keys.D6)
            {
                textBox6.Visible = true; textBox11.Visible = true;
                textBox22.Text = int.Parse(textBox21.Text + textBox11.Text).ToString();
            }
            if (e.KeyCode == Keys.D7)
            {
                textBox7.Visible = true; textBox12.Visible = true;
                textBox22.Text = int.Parse(textBox21.Text + textBox12.Text).ToString();
            }
            if (e.KeyCode == Keys.D8)
            {
                textBox7.Visible = true; textBox13.Visible = true;
                textBox22.Text = int.Parse(textBox21.Text + textBox13.Text).ToString();
            }
            if (e.KeyCode == Keys.D9)
            {
                textBox7.Visible = true; textBox14.Visible = true;
                textBox22.Text = int.Parse(textBox21.Text + textBox14.Text).ToString();
            }
            if (e.KeyCode == Keys.D0)
            {
                textBox7.Visible = true; textBox15.Visible = true;
                textBox22.Text = int.Parse(textBox21.Text + textBox15.Text).ToString();
            }
        }

        //private void textBox6_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        label2.Text = TimerStart.ToString();
        //        timer1.Start();
        //        TimerStart = 25;
        //        this.timer1_Tick(this, new EventArgs());
        //    }
        //    if (e.KeyCode == Keys.F12)
        //    {
        //        myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\DUPLICATE.wav";
        //        myPlayer.Play();
        //    }
        //}

        SQL sql = new SQL();
        int QuestionNo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (QuestionNo == 5)
            {
                QuestionNo = 0; label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
                sql.Questions();
                label1.Text = (sql.dt.Rows[QuestionNo][1]).ToString();
                QuestionNo++;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\DUPLICATE.wav";
                myPlayer.Play();
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
            }

            if (e.KeyCode == Keys.F1)
            {
                SetQuestions1Visible();
                textBox21.Visible = true;
            }
            if (e.KeyCode == Keys.F2)
            {
                SetQuestions2Visible();
                textBox22.Visible = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                SetQuestions1Invisible();
                textBox21.Visible = false;
            }
            if (e.KeyCode == Keys.F4)
            {
                SetQuestions2Invisible();
                textBox22.Visible = false;
            }
            if (e.KeyCode == Keys.D1)
            {
                textBox21.Visible = true;
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox1.Visible = true;

            }
            if (e.KeyCode == Keys.Q)
            {
                textBox20.Visible = true;
                if (textBox20.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox20.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox21.Text = int.Parse(textBox20.Text).ToString();
            }
            if (e.KeyCode == Keys.D2)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox2.Visible = true;
            }
            if (e.KeyCode == Keys.W)
            {
                if (textBox19.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox19.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox21.Text = (int.Parse(textBox21.Text) + int.Parse(textBox19.Text)).ToString();
                textBox19.Visible = true;
            }
            if (e.KeyCode == Keys.D3)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox3.Visible = true;
            }
            if (e.KeyCode == Keys.E)
            {
                if (textBox18.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox18.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox18.Visible = true; 
                textBox21.Text = (int.Parse(textBox21.Text) + int.Parse(textBox18.Text)).ToString();
            }
            if (e.KeyCode == Keys.D4)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox4.Visible = true;
            }
            if (e.KeyCode == Keys.R)
            {
                if (textBox17.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox17.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox17.Visible = true;
                textBox21.Text = (int.Parse(textBox21.Text) + int.Parse(textBox17.Text)).ToString();
            }
            if (e.KeyCode == Keys.D5)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox5.Visible = true;
            }
            if (e.KeyCode == Keys.T)
            {
                if (textBox16.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox16.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox16.Visible = true;
                textBox21.Text = (int.Parse(textBox21.Text) + int.Parse(textBox16.Text)).ToString();
                SetQuestions2Visible();
            }




            if (e.KeyCode == Keys.D6)
            {
                textBox22.Visible = true;
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox6.Visible = true;
            }
            if (e.KeyCode == Keys.Y)
            {
                if (textBox11.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox11.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox11.Visible = true;
                textBox22.Text = (int.Parse(textBox21.Text) + int.Parse(textBox11.Text)).ToString();
            }
            if (e.KeyCode == Keys.D7)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox7.Visible = true;
            }
            if (e.KeyCode == Keys.U)
            {
                if (textBox12.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox12.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox12.Visible = true;
                textBox22.Text = (int.Parse(textBox22.Text) + int.Parse(textBox12.Text)).ToString();
            }
            if (e.KeyCode == Keys.D8)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox8.Visible = true;
            }
            if (e.KeyCode == Keys.I)
            {
                if (textBox13.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox13.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox13.Visible = true;
                textBox22.Text = (int.Parse(textBox22.Text) + int.Parse(textBox13.Text)).ToString();
            }
            if (e.KeyCode == Keys.D9)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox9.Visible = true;
            }
            if (e.KeyCode == Keys.O)
            {
                if (textBox14.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox14.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox14.Visible = true;
                textBox22.Text = (int.Parse(textBox22.Text) + int.Parse(textBox14.Text)).ToString();
            }
            if (e.KeyCode == Keys.D0)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\BLIP.wav";
                myPlayer.Play();
                textBox10.Visible = true;
            }
            if (e.KeyCode == Keys.P)
            {
                if (textBox15.Text == "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\WRONGBUZZER.wav";
                    myPlayer.Play();
                }
                else if (textBox15.Text != "0")
                {
                    myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\RIGHT.wav";
                    myPlayer.Play();
                }
                textBox15.Visible = true;
                textBox22.Text = (int.Parse(textBox22.Text) + int.Parse(textBox15.Text)).ToString();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\DUPLICATE.wav";
                myPlayer.Play();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\DUPLICATE.wav";
                myPlayer.Play();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\DUPLICATE.wav";
                myPlayer.Play();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                myPlayer.SoundLocation = @"E:\Visual Studio 2010\Projects\Fast Money\Fast Money\Sounds\DUPLICATE.wav";
                myPlayer.Play();
            }
        }
    }
}
