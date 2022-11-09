using Microsoft.VisualBasic.Devices;
using System.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;

namespace Lab2__Dzwięk
{
    public partial class Form1 : Form
    {

        private string filePath = "";
        private string fileRecordPath = "";

        private SoundPlayer soundPlayer;
        private WaveOut waveOutDevice = new WaveOut();
        private DirectSoundOut directSoundOut = new DirectSoundOut();
        private AudioFileReader audioFileReader;

        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut soundOut = null;
        NAudio.Wave.WaveFileWriter waveFileWriter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            fileExplorer.Filter = "Audio files (.wav)|*.wav";
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                filePath = fileExplorer.FileName;         
                //FillListBox();
                soundPlayer = new SoundPlayer(@filePath);
                audioFileReader = new AudioFileReader(filePath);
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (filePath == String.Empty)
                MessageBox.Show("Wybierz plik!");

            else
            {
                if (Play.Text == "PLAY")
                {
                    Play.Text = "STOP";

                    if (SoundPlay.Checked)
                    {
                        soundPlayer.Play();
                    }

                  

                    if (Wave.Checked)
                    {
                        var waveOut = new WaveChannel32(new WaveFileReader(filePath));
                        waveOutDevice.Init(waveOut);
                        waveOutDevice.Play();
                    }

                    if (DirectSound.Checked)
                    {
                        directSoundOut.Init(audioFileReader);
                        directSoundOut.Play();
                    }
                }

                else
                {
                    Play.Text = "PLAY";

                    if (SoundPlay.Checked)
                    {
                        soundPlayer.Stop();
                    }

                    if (Wave.Checked)
                    {
                        waveOutDevice.Stop();
                    }

                    if (DirectSound.Checked)
                    {
                        directSoundOut.Stop();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
                sources.Add(WaveIn.GetCapabilities(i));

            listBoxMicrophones.Items.Clear();

            int counter = 0;
            foreach (var source in sources)
            {
                string item = source.ProductName;
                listBoxMicrophones.Items.Add("Microfon " + counter + "->" + item);
                counter++;
            }
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileExplorer = new SaveFileDialog();
            fileExplorer.Filter = "Wave File (*.wav)|*.wav;";
            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                fileRecordPath = fileExplorer.FileName;
                //labelSaveFilePath.Text = $"Save to: {fileRecordPath}";
            }
        }

        private void sourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFileWriter == null)
                return;

            waveFileWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveFileWriter.Flush();
        }


        private void Record_Click(object sender, EventArgs e)
        {

            if (Record.Text == "Record")
            {
                if (listBoxMicrophones.SelectedItems.Count == 0)
                    return;

                if (fileRecordPath == "")
                {
                    MessageBox.Show("Select save file");
                }
                else
                {
                    int deviceNumber = listBoxMicrophones.SelectedIndex;

                    sourceStream = new WaveIn();
                    sourceStream.DeviceNumber = deviceNumber;
                    sourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceNumber).Channels);
                    sourceStream.DataAvailable += new EventHandler<WaveInEventArgs>(sourceStream_DataAvailable);
                    waveFileWriter = new WaveFileWriter(fileRecordPath, sourceStream.WaveFormat);

                    sourceStream.StartRecording();

                    Record.Text = "Stop recording";
                }
            }
            else
            {
                if (soundOut != null)
                {
                    soundOut.Stop();
                    soundOut.Dispose();
                    soundOut = null;
                    Record.Text = "Record";
                }
                if (sourceStream != null)
                {
                    sourceStream.StopRecording();
                    sourceStream.Dispose();
                    sourceStream = null;
                    Record.Text = "Record";
                }
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                    waveFileWriter = null;
                    Record.Text = "Record";
                }
  
            }
        }

        private void Slow_Click(object sender, EventArgs e)
        {
            int Rate = 2;
            byte[] B = File.ReadAllBytes(filePath);
            int SampleRate = BitConverter.ToInt32(B, 24) / Rate;
            Array.Copy(BitConverter.GetBytes(SampleRate), 0, B, 24, 4);
            using (System.Media.SoundPlayer SP = new System.Media.SoundPlayer(new MemoryStream(B)))
            {
                SP.Play();
            }
        }
    }
}