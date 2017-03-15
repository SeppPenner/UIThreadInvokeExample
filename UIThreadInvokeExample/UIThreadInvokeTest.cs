using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace UIThreadInvokeExample
{
    public partial class UiThreadInvokeTest : Form
    {
        private readonly BackgroundWorker _worker = new BackgroundWorker();
        private Thread _thread;

        public UiThreadInvokeTest()
        {
            InitializeComponent();
            //Initialize Backgroundworker
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += DoWork;
            //Initialize Thread --> More simple than backgroundworker
            _thread = new Thread(DoThreadWork);
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            //Local variable declaration (this variable is only valid in the Backgroundworker thread)
            string text;
            double shit = 0;
            //Invoke the UIThread to avoid cross thread exceptions
            this.UiThreadInvoke(() =>
            {
                //Lock the textbox
                textBox_Test.Enabled = false;
                //Lock the backgroundworker button
                button_Start_Backgroundworker.Enabled = false;
                //Lock the thread button
                button_Start_Thread.Enabled = false;
            });
            //Do some shit to test the application
            for (var i = 1; i < 1000000; i++)
                shit = new Random().NextDouble();
            //Invoke the UIThread to avoid cross thread exceptions
            this.UiThreadInvoke(() =>
            {
                //Get value from GUI thread in Backgroundworker
                text = textBox_Test.Text;
                //Set value to GUI thread from Backgroundworker
                label_Test.Text = string.Concat(text, " ", shit.ToString(CultureInfo.InvariantCulture));
                //Unlock the textbox
                textBox_Test.Enabled = true;
                //Unlock the backgroundworker button
                button_Start_Backgroundworker.Enabled = true;
                //Unlock the thread button
                button_Start_Thread.Enabled = true;
                //--> See also UIThreadInvokeClass.cs
            });
        }

        private void DoThreadWork()
        {
            //Local variable declaration (this variable is only valid in the Thread thread)
            string text;
            double shit = 0;
            //Invoke the UIThread to avoid cross thread exceptions
            this.UiThreadInvoke(() =>
            {
                //Lock the textbox
                textBox_Test.Enabled = false;
                //Lock the backgroundworker button
                button_Start_Backgroundworker.Enabled = false;
                //Lock the thread button
                button_Start_Thread.Enabled = false;
            });
            //Do some shit to test the application
            for (var i = 1; i < 1000000; i++)
                shit = new Random().NextDouble();
            //Invoke the UIThread to avoid cross thread exceptions
            this.UiThreadInvoke(() =>
            {
                //Get value from GUI thread in Backgroundworker
                text = textBox_Test.Text;
                //Set value to GUI thread from Backgroundworker
                label_Test.Text = string.Concat(text, " ", shit.ToString(CultureInfo.InvariantCulture));
                //Unlock the textbox
                textBox_Test.Enabled = true;
                //Unlock the backgroundworker button
                button_Start_Backgroundworker.Enabled = true;
                //Unlock the thread button
                button_Start_Thread.Enabled = true;
                //--> See also UIThreadInvokeClass.cs
            });
        }

        private void Button_Start_Backgroundworker_Click(object sender, EventArgs e)
        {
            if (!_worker.IsBusy)
                _worker.RunWorkerAsync();
        }

        private void Button_Start_Thread_Click(object sender, EventArgs e)
        {
            if (_thread.ThreadState == ThreadState.Running) return;
            _thread = new Thread(DoThreadWork);
            _thread.Start();
        }
    }
}