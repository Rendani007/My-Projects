using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Speech.V1;
using Grpc.Auth;
using NAudio.Wave;
using System.IO;

namespace speech2Text
{
    public partial class Form1 : Form
    {
        private BufferedWaveProvider bwp;

        WaveIn waveIn;
        WaveOut waveOut;
        WaveFileWriter writer;
        WaveFileReader reader;
        string output = "audio.raw";
        int numlines = 0;
        public Form1()
        {
            InitializeComponent();
            waveOut = new WaveOut();
            waveIn = new WaveIn();

            waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
            waveIn.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);
            bwp = new BufferedWaveProvider(waveIn.WaveFormat);
            bwp.DiscardOnBufferOverflow = true;

            recordBtn.Enabled = true;
            audioSaveBtn.Enabled = false;
            convertBtn.Enabled = false;
        }
        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void speechTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
       

        }

        private void audioSaveBtn_Click(object sender, EventArgs e)
        {
 
        }
        private void waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            waveOut.Stop();
            reader.Close();
            reader = null;
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {

        }

        private void playAudioTxt_Click(object sender, EventArgs e)
        {
          
        }

        private void exportToTxtBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {

        }

       

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            numlines = richTextBox1.Lines.Count();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button_WOC1_Click(object sender, EventArgs e)//////Record/////
        {
            if (NAudio.Wave.WaveIn.DeviceCount < 1)
            {
                Console.WriteLine("No microphone!");
                return;
            }

            waveIn.StartRecording();

            recordBtn.Enabled = false;
            audioSaveBtn.Enabled = true;
            convertBtn.Enabled = false;

            // string path = @"C:\\Audio.txt";
            // File.Create(path);
        }

     

        private void Button_WOC4_Click(object sender, EventArgs e)//////Play audio again//////
        {
            if (File.Exists("audio.raw"))
            {
                reader = new WaveFileReader("audio.raw");
                waveOut.Init(reader);
                waveOut.Play();
            }
            else
            {
                MessageBox.Show("No Audio File Found");
            }
        }

        private void Button_WOC5_Click(object sender, EventArgs e)/////Export to text file/////
        {
            string path = @"C:\Users\Rendi\Documents\Test file\file.txt";
            using (StreamWriter sr = new StreamWriter(path))
            {
                int start = 1;
                while (start <= numlines)
                {
                    sr.WriteLine(richTextBox1.Lines[start - 1]);
                    start++;
                    MessageBox.Show("Saved to Desktop as file.txt");

                }
            }






            /* if (Browser.ShowDialog() == DialogResult.OK)
            {
                // create a writer and open the file
                TextWriter tw = new StreamWriter(Browser.SelectedPath + "Audio.txt");
                // write a line of text to the file
                tw.WriteLine(speechTxt.Text);
                // close the stream
                tw.Close();
                MessageBox.Show("Saved to " + Browser.SelectedPath + "\\Audio.txt", "Saved File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

            /* SaveFileDialog saveFileDialog1 = new SaveFileDialog();
             saveFileDialog1.InitialDirectory = @"C:\";      
     saveFileDialog1.Title = "Save text Files";
             saveFileDialog1.CheckFileExists = false;
             saveFileDialog1.CheckPathExists = false;
             saveFileDialog1.DefaultExt = "txt";
             saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
             saveFileDialog1.FilterIndex = 2;
             saveFileDialog1.RestoreDirectory = true;
             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 speechTxt.Text = saveFileDialog1.FileName;
             }
             */
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_WOC1_Click_1(object sender, EventArgs e)/////Save//////
        {
            waveIn.StopRecording();

            if (File.Exists("audio.raw"))
                File.Delete("audio.raw");

            writer = new WaveFileWriter(output, waveIn.WaveFormat);//thaking audiio buffer and writing to disk

            recordBtn.Enabled = false;
            audioSaveBtn.Enabled = false;
            convertBtn.Enabled = true;

            byte[] buffer = new byte[bwp.BufferLength];
            int offset = 0;
            int count = bwp.BufferLength;

            var read = bwp.Read(buffer, offset, count);
            if (count > 0)
            {
                writer.Write(buffer, offset, read);
            }

            waveIn.Dispose();
            waveIn = null;
            writer.Close();
            writer = null;

            reader = new WaveFileReader("audio.raw"); // (new MemoryStream(bytes));
            waveOut.Init(reader);
            waveOut.PlaybackStopped += new EventHandler<StoppedEventArgs>(waveOut_PlaybackStopped);
            waveOut.Play();

        }

        private void Button_WOC2_Click_1(object sender, EventArgs e)///Convert to text/////
        {
            recordBtn.Enabled = true;
            audioSaveBtn.Enabled = false;
            convertBtn.Enabled = false;

            if (File.Exists("audio.raw"))
            {

                var speech = SpeechClient.Create();
                var response = speech.Recognize(new RecognitionConfig()
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRateHertz = 16000,
                    LanguageCode = "en",
                }, RecognitionAudio.FromFile("audio.raw"));


                richTextBox1.Text = "";

                foreach (var result in response.Results)
                {
                    foreach (var alternative in result.Alternatives)
                    {
                        richTextBox1.Text = richTextBox1.Text + " " + alternative.Transcript;
                    }
                }

                if (richTextBox1.Text.Length == 0)
                    richTextBox1.Text = "No Data ";

            }
            else
            {

                richTextBox1.Text = "Audio File Missing ";

            }

        }
    }
}
   