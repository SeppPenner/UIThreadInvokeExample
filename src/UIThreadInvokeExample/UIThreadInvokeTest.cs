// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UIThreadInvokeTest.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The test form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UIThreadInvokeExample;

/// <summary>
/// The test form.
/// </summary>
public partial class UiThreadInvokeTest : Form
{
    /// <summary>
    /// The background worker.
    /// </summary>
    private readonly BackgroundWorker worker = new();

    /// <summary>
    /// The thread.
    /// </summary>
    private Thread thread;

    /// <summary>
    /// Initializes a new instance of the <see cref="UiThreadInvokeTest"/> class.
    /// </summary>
    public UiThreadInvokeTest()
    {
        this.InitializeComponent();

        // Initialize the background worker
        this.worker.WorkerSupportsCancellation = true;
        this.worker.DoWork += this.DoWork;

        // Initialize the thread --> More simple than a background worker
        this.thread = new Thread(this.DoThreadWork);
    }

    /// <summary>
    /// Runs the background worker's work.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void DoWork(object sender, DoWorkEventArgs e)
    {
        // Local variable declaration (this variable is only valid in the background worker thread)
        string text;
        double shit = 0;

        // Invoke the UIThread to avoid cross thread exceptions
        this.UiThreadInvoke(
            () =>
            {
                // Lock the text box
                this.textBoxTest.Enabled = false;

                // Lock the background worker button
                this.buttonStartBackgroundWorker.Enabled = false;

                // Lock the thread button
                this.buttonStartThread.Enabled = false;
            });

        // Do some shit to test the application
        for (var i = 1; i < 1000000; i++)
        {
            shit = new Random().NextDouble();
        }

        // Invoke the UIThread to avoid cross thread exceptions
        this.UiThreadInvoke(
            () =>
            {
                // Get value from GUI thread in the background worker
                text = this.textBoxTest.Text;

                // Set value to GUI thread from the background worker
                this.labelTest.Text = string.Concat(text, " ", shit.ToString(CultureInfo.InvariantCulture));

                // Unlock the text box
                this.textBoxTest.Enabled = true;

                // Unlock the the background worker button
                this.buttonStartBackgroundWorker.Enabled = true;

                // Unlock the thread button
                this.buttonStartThread.Enabled = true;

                // --> See also UIThreadInvokeClass.cs
            });
    }

    /// <summary>
    /// Runs the thread's work.
    /// </summary>
    private void DoThreadWork()
    {
        // Local variable declaration (this variable is only valid in the Thread thread)
        string text;
        double shit = 0;

        // Invoke the UIThread to avoid cross thread exceptions
        this.UiThreadInvoke(
            () =>
            {
                // Lock the text box
                this.textBoxTest.Enabled = false;

                // Lock the background worker button
                this.buttonStartBackgroundWorker.Enabled = false;

                // Lock the thread button
                this.buttonStartThread.Enabled = false;
            });

        // Do some shit to test the application
        for (var i = 1; i < 1000000; i++)
        {
            shit = new Random().NextDouble();
        }

        // Invoke the UIThread to avoid cross thread exceptions
        this.UiThreadInvoke(
            () =>
            {
                // Get value from GUI thread in the background worker
                text = this.textBoxTest.Text;

                // Set value to GUI thread from the background worker
                this.labelTest.Text = string.Concat(text, " ", shit.ToString(CultureInfo.InvariantCulture));

                // Unlock the text box
                this.textBoxTest.Enabled = true;

                // Unlock the background worker button
                this.buttonStartBackgroundWorker.Enabled = true;

                // Unlock the thread button
                this.buttonStartThread.Enabled = true;

                // --> See also UIThreadInvokeClass.cs
            });
    }

    /// <summary>
    /// Handles the button click to start the background worker.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void ButtonStartBackgroundWorkerClick(object sender, EventArgs e)
    {
        if (!this.worker.IsBusy)
        {
            this.worker.RunWorkerAsync();
        }
    }

    /// <summary>
    /// Handles the button click to start the thread.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void ButtonStartThreadClick(object sender, EventArgs e)
    {
        if (this.thread.ThreadState == ThreadState.Running)
        {
            return;
        }

        this.thread = new Thread(this.DoThreadWork);
        this.thread.Start();
    }
}
