using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;
using NAudio.Wave;

using System.Windows.Forms;

namespace SoundModificationApp
{
    public partial class MainForm : Form
    {
        //global variable for the input device
        WaveInEvent InputDevice;
        //global variable for the output device
        WaveOutEvent OutputDevice;
        //global variable for the  WaveFormat
        WaveFormat AudioWaveFormat;
        //global variable for the  SampleRateCal
        int SampleRateCal;
        //global variable for the  IsRecording
        bool IsRecording = false;
        //global variable for the ModWaveFormat 
        WaveFormat ModWaveFormat;
        //global variable for the OutputAudioBuffer
        BufferedWaveProvider OutputAudioBuffer;
        public MainForm()
        {
            InitializeComponent();
            //this will set SampleRateCal to value 1000*n more then the default sample rate of the WaveFormat()
            SampleRateCal = 44000 + (1000 * TracBarPitchInput.Value);
            //this add all the names for of capable input audio device to CmbBoxInputDevice items
            for (int counter = 0; counter < WaveIn.DeviceCount; counter++)
            {
                CmbBoxInputDevice.Items.Add(WaveIn.GetCapabilities(counter).ProductName);
            }
            //this add all the names for of capable output audio device to CmbBoxOutputDevice 
            for (int counter = 0; counter < WaveOut.DeviceCount; counter++)
            {
                CmbBoxOutputDevice.Items.Add(WaveOut.GetCapabilities(counter).ProductName);
            }
            //set comboboxs to first item
            CmbBoxInputDevice.SelectedIndex = 0;
            CmbBoxOutputDevice.SelectedIndex = 0;
            //this will create a new wave format for AudioWaveFormat
            AudioWaveFormat = new WaveFormat();
            //this will create a new wave format for ModWaveFormat
            ModWaveFormat = new WaveFormat(SampleRateCal, 2);

        }
        void StartAndStopCapture()
        {
            //case statment to check bool of IsRecording
            switch (IsRecording)
            {
                //if false
                case false:
                    {
                        //this will call StartCapture
                        StartCapture();
                        //this will leave the case statment
                        break;
                    }
                //if true
                case true:
                    {
                        //this will call StopCapture
                        StopCapture();
                        //this will leave the case statment
                        break;
                    }
            }

          

       
        }
        void StopCapture()
        {
            //this will stop recording for InputDevice
            InputDevice.StopRecording();
            //this will stop playing for OutputDevice
            OutputDevice.Stop();
            //next will dispose  OutputDevice and InputDevice
            OutputDevice.Dispose();
            InputDevice.Dispose();
            //this will set IsRecording to false
            IsRecording = false;
        }
        void StartCapture()
        {
            //this will create a new in ModWaveFormat
            ModWaveFormat = new WaveFormat(SampleRateCal, 2);
            //this will create a new output device using the information from the CmbBoxOutputDevice
            OutputDevice = new WaveOutEvent() { DeviceNumber = CmbBoxOutputDevice.SelectedIndex };
            //this will create a new input device using the information from the CmbBoxInputDevice and AudioWaveFormat
            InputDevice = new WaveInEvent() { DeviceNumber = CmbBoxInputDevice.SelectedIndex, WaveFormat = AudioWaveFormat };
            //creates a handle for if there is available data and calls InputDevice_DataAvailable
            InputDevice.DataAvailable += InputDevice_DataAvailable;
            //this will start the recording for InputDevice
            InputDevice.StartRecording();
            //this will create a new BufferedWaveProvider using ModWaveFormat in OutputAudioBuffer
            OutputAudioBuffer = new BufferedWaveProvider(ModWaveFormat);
            //this will initiate
            OutputDevice.Init(OutputAudioBuffer);
            //this will play the audio from OutputAudioBuffer
            OutputDevice.Play();
            //this will set IsRecording to true
            IsRecording = true;
        }



        private void InputDevice_DataAvailable(object sender, WaveInEventArgs e)
        {
            //this will add a sample to OutputAudioBuffer
            OutputAudioBuffer.AddSamples(e.Buffer, 0, e.Buffer.Length);
            //this will display the sound wave on WavViewModedOutput
            WavViewModedOutput.WaveStream = new RawSourceWaveStream(e.Buffer, 0 ,e.Buffer.Length, ModWaveFormat);
            //this will display the sound wave on WavViewUnmodeOutput
            WavViewUnmodeOutput.WaveStream = new RawSourceWaveStream(e.Buffer, 0, e.Buffer.Length, AudioWaveFormat);
  

        }

        private void BtnStartAndStopSound_Click(object sender, EventArgs e)
        {
            //this will call StartAndStopCapture
            StartAndStopCapture();
        }

        private void TracBarPitchInput_Scroll(object sender, EventArgs e)
        {
            //this will set SampleRateCal to value 1000*n more then the default sample rate of the WaveFormat()
            SampleRateCal = 44000 + (1000 * TracBarPitchInput.Value);
            //next will stop and start the capture to change the audio
            StopCapture();
            StartCapture();
        }
    }
}
