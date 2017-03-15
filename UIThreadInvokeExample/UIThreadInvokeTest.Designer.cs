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
            this.textBox_Test = new System.Windows.Forms.TextBox();
            this.label_Test = new System.Windows.Forms.Label();
            this.button_Start_Backgroundworker = new System.Windows.Forms.Button();
            this.tableLayoutPanelDesign = new System.Windows.Forms.TableLayoutPanel();
            this.button_Start_Thread = new System.Windows.Forms.Button();
            this.tableLayoutPanelDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Test
            // 
            this.textBox_Test.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_Test.Location = new System.Drawing.Point(3, 3);
            this.textBox_Test.Name = "textBox_Test";
            this.textBox_Test.Size = new System.Drawing.Size(113, 20);
            this.textBox_Test.TabIndex = 0;
            // 
            // label_Test
            // 
            this.label_Test.AutoSize = true;
            this.label_Test.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Test.Location = new System.Drawing.Point(3, 31);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(0, 31);
            this.label_Test.TabIndex = 1;
            this.label_Test.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Start_Backgroundworker
            // 
            this.button_Start_Backgroundworker.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Start_Backgroundworker.Location = new System.Drawing.Point(122, 3);
            this.button_Start_Backgroundworker.Name = "button_Start_Backgroundworker";
            this.button_Start_Backgroundworker.Size = new System.Drawing.Size(134, 25);
            this.button_Start_Backgroundworker.TabIndex = 2;
            this.button_Start_Backgroundworker.Text = "Start Backgroundworker";
            this.button_Start_Backgroundworker.UseVisualStyleBackColor = true;
            this.button_Start_Backgroundworker.Click += new System.EventHandler(this.Button_Start_Backgroundworker_Click);
            // 
            // tableLayoutPanelDesign
            // 
            this.tableLayoutPanelDesign.ColumnCount = 2;
            this.tableLayoutPanelDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDesign.Controls.Add(this.button_Start_Thread, 1, 1);
            this.tableLayoutPanelDesign.Controls.Add(this.textBox_Test, 0, 0);
            this.tableLayoutPanelDesign.Controls.Add(this.label_Test, 0, 1);
            this.tableLayoutPanelDesign.Controls.Add(this.button_Start_Backgroundworker, 1, 0);
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
            this.button_Start_Thread.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Start_Thread.Location = new System.Drawing.Point(122, 34);
            this.button_Start_Thread.Name = "button_Start_Thread";
            this.button_Start_Thread.Size = new System.Drawing.Size(134, 25);
            this.button_Start_Thread.TabIndex = 3;
            this.button_Start_Thread.Text = "Start thread";
            this.button_Start_Thread.UseVisualStyleBackColor = true;
            this.button_Start_Thread.Click += new System.EventHandler(this.Button_Start_Thread_Click);
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

        private System.Windows.Forms.TextBox textBox_Test;
        private System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.Button button_Start_Backgroundworker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDesign;
        private System.Windows.Forms.Button button_Start_Thread;
    }
}

