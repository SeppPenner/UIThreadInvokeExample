namespace UIThreadInvokeExample
{
    partial class UiThreadInvokeTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UiThreadInvokeTest));
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonStartBackgroundWorker = new System.Windows.Forms.Button();
            this.tableLayoutPanelDesign = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStartThread = new System.Windows.Forms.Button();
            this.tableLayoutPanelDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Test
            // 
            this.textBoxTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxTest.Location = new System.Drawing.Point(3, 3);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(113, 20);
            this.textBoxTest.TabIndex = 0;
            // 
            // label_Test
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTest.Location = new System.Drawing.Point(3, 31);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 31);
            this.labelTest.TabIndex = 1;
            this.labelTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Start_Backgroundworker
            // 
            this.buttonStartBackgroundWorker.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStartBackgroundWorker.Location = new System.Drawing.Point(122, 3);
            this.buttonStartBackgroundWorker.Name = "buttonStartBackgroundWorker";
            this.buttonStartBackgroundWorker.Size = new System.Drawing.Size(134, 25);
            this.buttonStartBackgroundWorker.TabIndex = 2;
            this.buttonStartBackgroundWorker.Text = "Start Backgroundworker";
            this.buttonStartBackgroundWorker.UseVisualStyleBackColor = true;
            this.buttonStartBackgroundWorker.Click += new System.EventHandler(this.ButtonStartBackgroundWorkerClick);
            // 
            // tableLayoutPanelDesign
            // 
            this.tableLayoutPanelDesign.ColumnCount = 2;
            this.tableLayoutPanelDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDesign.Controls.Add(this.buttonStartThread, 1, 1);
            this.tableLayoutPanelDesign.Controls.Add(this.textBoxTest, 0, 0);
            this.tableLayoutPanelDesign.Controls.Add(this.labelTest, 0, 1);
            this.tableLayoutPanelDesign.Controls.Add(this.buttonStartBackgroundWorker, 1, 0);
            this.tableLayoutPanelDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDesign.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDesign.Name = "tableLayoutPanelDesign";
            this.tableLayoutPanelDesign.RowCount = 3;
            this.tableLayoutPanelDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDesign.Size = new System.Drawing.Size(261, 60);
            this.tableLayoutPanelDesign.TabIndex = 3;
            // 
            // button_Start_Thread
            // 
            this.buttonStartThread.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStartThread.Location = new System.Drawing.Point(122, 34);
            this.buttonStartThread.Name = "buttonStartThread";
            this.buttonStartThread.Size = new System.Drawing.Size(134, 25);
            this.buttonStartThread.TabIndex = 3;
            this.buttonStartThread.Text = "Start thread";
            this.buttonStartThread.UseVisualStyleBackColor = true;
            this.buttonStartThread.Click += new System.EventHandler(this.ButtonStartThreadClick);
            // 
            // UiThreadInvokeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 60);
            this.Controls.Add(this.tableLayoutPanelDesign);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UiThreadInvokeTest";
            this.Text = "UIThreadInvokeTest";
            this.tableLayoutPanelDesign.ResumeLayout(false);
            this.tableLayoutPanelDesign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonStartBackgroundWorker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDesign;
        private System.Windows.Forms.Button buttonStartThread;
    }
}

