using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.DirectSound;

namespace AudioTest
{
    public partial class Main_Frm : Form
    {
        WaveFormat waveFormat;
        BufferDescription bufferDesc;
        Device device;
        SecondaryBuffer bufferSound;
        int samples;
        int vol =10;
        short[] buffer;
        bool syncLR = false;
        bool isSweep = false;
        int sweepCnt = 0;

        private void EnableWin(bool Is_Enabled)//Disable button while playing
        {
            tB_L.Enabled = Is_Enabled;
            tB_R.Enabled = Is_Enabled;
            btn_play.Enabled = Is_Enabled;
            btn_stop.Enabled = !Is_Enabled;
        }

        public Main_Frm()
        {
            InitializeComponent();
            EnableWin(true);

            // Set up wave format 
            waveFormat = new WaveFormat();
            waveFormat.FormatTag = WaveFormatTag.Pcm;
            waveFormat.Channels = 2;
            waveFormat.BitsPerSample = 16;
            waveFormat.SamplesPerSecond = 44100;
            waveFormat.BlockAlign = (short)(waveFormat.Channels * waveFormat.BitsPerSample / 8);
            waveFormat.AverageBytesPerSecond = waveFormat.BlockAlign * waveFormat.SamplesPerSecond;

            // Set up buffer description 
            bufferDesc = new BufferDescription(waveFormat);
            bufferDesc.Control3D = false;
            bufferDesc.ControlEffects = false;
            bufferDesc.ControlFrequency = true;
            bufferDesc.ControlPan = true;
            bufferDesc.ControlVolume = true;
            bufferDesc.DeferLocation = true;
            bufferDesc.GlobalFocus = true;

            device = new Device();
            device.SetCooperativeLevel(new System.Windows.Forms.Control(), CooperativeLevel.Priority);


            samples = 1 * waveFormat.SamplesPerSecond * waveFormat.Channels;
            buffer = new short[samples];

            // Set buffer length 
            //bufferDesc.BufferBytes = buffer.Length * waveFormat.BlockAlign;
            bufferDesc.BufferBytes = buffer.Length * sizeof(short);//字节数

            bufferSound = new SecondaryBuffer(bufferDesc, device);
        }

        private void btn_play_Click(object sender, EventArgs e)//press play button;
        {
            // Set initial amplitude and frequency 
            try
            {

                bool Is_input_OK = true;
                double frequency_L = 1000;
                double frequency_R = 1000;
                if (syncLR == false)
                {
                    frequency_L = Convert.ToDouble(tB_L.Text);
                    frequency_R = Convert.ToDouble(tB_R.Text);
                }
                else
                {
                    frequency_R = frequency_L;
                    tB_R.Text = tB_L.Text;
                }
                if (frequency_L > 20000 || frequency_L < 20) Is_input_OK = false;
                if (frequency_R > 20000 || frequency_R < 20) Is_input_OK = false;
                if (!Is_input_OK)
                {
                    MessageBox.Show("输入频率范围在：20-20000");
                    return;
                }
                double amplitude = short.MaxValue;
                double two_pi = 2 * Math.PI;
                // Iterate through time 
                for (int i = 0; i < buffer.Length / 2; i++)
                {
                    // Add to sine 
                    buffer[2 * i] = (short)(amplitude * Math.Sin(i * two_pi * frequency_L / waveFormat.SamplesPerSecond));
                    buffer[2 * i + 1] = (short)(amplitude * Math.Sin(i * two_pi * frequency_R / waveFormat.SamplesPerSecond));
                }

                bufferSound.Volume = (vol==0)?-10000:-600*(10-vol);//(int)Volume.Max;
                bufferSound.Write(0, buffer, LockFlag.None);
                bufferSound.Play(0, BufferPlayFlags.Looping);

                isSync.Enabled = false;//disable sync checkbox;
            }
            catch
            {
                MessageBox.Show("输入错误！");
            }

            if (bufferSound.Status.Playing) { btn_play.Enabled = false; Sweep.Enabled = false; btn_stop.Enabled = true; }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            
            bufferSound.Stop();

            isSync.Enabled = true;//enable sync checkbox;
            timer1.Enabled = false;//stop timer1
            sweepCnt = 0;

            if (!bufferSound.Status.Playing) { btn_play.Enabled = true; Sweep.Enabled = true; }
        }

        private void label_L_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void VolBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                //bufferSound = new SecondaryBuffer(bufferDesc, device);

                vol = VolBar.Value;
                //bufferSound.Stop();

                if (vol == 10)
                {
                    VolTxt.Text = "Max";
                }
                else if (vol == 0)
                {
                    VolTxt.Text = "Mute";
                }
                else
                {
                    VolTxt.Text = Convert.ToString(VolBar.Value*10);
                }

                if (bufferSound.Status.Playing)
                {
                    bufferSound.Stop();
                    bufferSound.Volume = (vol == 0) ? -10000 : -600 * (10 - vol);//(int)Volume.Max;
                    //bufferSound.Write(0, buffer, LockFlag.None);
                    bufferSound.Play(0, BufferPlayFlags.Looping);
                }
            }
            catch
            {
                MessageBox.Show("Volume Error!");
            }
        }

        private void VolTxt_Click(object sender, EventArgs e)
        {

        }

        private void isSync_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (isSync.Checked == true)
                {
                    tB_R.Text = tB_L.Text;
                    tB_R.Enabled = false;
                }
                else
                {
                    tB_R.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Checkbox Error!");
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {
            //
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //
        }

        private void Sweep_Click(object sender, EventArgs e)
        {
            try
            {
                int interval_ms = 0;
                int tickTime = 0;
                int fStart = Convert.ToInt32(FS.Text);
                int fStop = Convert.ToInt32(FE.Text);
                int fStep = Convert.ToInt32(Fstep.Text);

                if ((FS.Text == null) && (FE.Text == null) && (Fstep.Text == null) && (sweepTime == null))
                {
                    MessageBox.Show("Sweep parameters couldn't be null!");
                    return;
                }
                else
                {
                    interval_ms = 1000 * Convert.ToInt32(sweepTime.Text);
                    tickTime = interval_ms / ((fStop - fStart) / fStep);

                    btn_play.Enabled = false; 
                    Sweep.Enabled = false; 
                    btn_stop.Enabled = true;

                    timer1.Interval = 100;//tickTime;
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
            catch { 
                
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                bufferSound.Stop();

                double amplitude = short.MaxValue;
                double two_pi = 2 * Math.PI;
                // Iterate through time 
                for (int i = 0; i < buffer.Length / 2; i++)
                {
                    // Add to sine 
                    buffer[2 * i] = (short)(amplitude * Math.Sin(i * two_pi * (Convert.ToInt32(FS.Text) + i * Convert.ToInt32(sweepTime.Text)) / waveFormat.SamplesPerSecond));
                    buffer[2 * i + 1] = (short)(amplitude * Math.Sin(i * two_pi * (Convert.ToInt32(FS.Text) + i * Convert.ToInt32(sweepTime.Text)) / waveFormat.SamplesPerSecond));
                }

                sweepCnt = sweepCnt + 1;

                bufferSound.Volume = (vol == 0) ? -10000 : -600 * (10 - vol);//(int)Volume.Max;
                bufferSound.Write(0, buffer, LockFlag.None);
                bufferSound.Play(0, BufferPlayFlags.Looping);

                timer1.Start(); ;
            }
            catch
            {

            }
        }
    }
}
