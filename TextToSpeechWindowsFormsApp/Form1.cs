using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.IO;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;



namespace TextToSpeechWindowsFormsApp
{
    public partial class Form1 : Form
    {
        string dir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic);
        string filename = "TexttoSpeechconverted";


        public Form1()
        {
            InitializeComponent();
        }

        private void bntConvert_Click(object sender, EventArgs e)
        {
           string age = cbVoiceAge.SelectedItem.ToString();
            string gender = cbVoiceGender.SelectedItem.ToString();
            string text = txtTexttoSpeak.Text.ToString();

            System.Speech.Synthesis.SpeechSynthesizer newvoice = Setupvoice(gender, age);



            newvoice.SetOutputToWaveFile(dir + @"\" + filename + ".wav",
          new SpeechAudioFormatInfo(8000, AudioBitsPerSample.Eight, AudioChannel.Mono));

            System.Media.SoundPlayer m_SoundPlayer =
          new System.Media.SoundPlayer(dir + @"\" + filename + ".wav");

            newvoice.Speak(text);

            m_SoundPlayer.Play();

            newvoice.Dispose();

        }

    

    public static System.Speech.Synthesis.SpeechSynthesizer Setupvoice(string gender, string age)
    {

        System.Speech.Synthesis.SpeechSynthesizer voice = new System.Speech.Synthesis.SpeechSynthesizer();


            switch (gender)
            {
                case "Male":

                    if (age == "Child")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Male, System.Speech.Synthesis.VoiceAge.Child);


                    }
                    else if (age == "Teen")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Male, System.Speech.Synthesis.VoiceAge.Teen);

                    }
                    else if (age == "Adult")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Male, System.Speech.Synthesis.VoiceAge.Adult);

                    }
                    else if (age == "Senior")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Male, System.Speech.Synthesis.VoiceAge.Senior);

                    }
                    break;



                case "Female":

                    if (age == "Child")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Female, System.Speech.Synthesis.VoiceAge.Child);

                    }
                    else if (age == "Teen")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Female, System.Speech.Synthesis.VoiceAge.Teen);

                    }
                    else if (age == "Adult")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Female, System.Speech.Synthesis.VoiceAge.Adult);

                    }
                    else if (age == "Senior")
                    {
                        voice.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender.Female, System.Speech.Synthesis.VoiceAge.Senior);

                    }
                    break;

            }



                return voice;

        }
    }
}
