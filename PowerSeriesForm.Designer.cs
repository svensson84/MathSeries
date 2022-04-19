namespace MathSeries
{
    public partial class PowerSeriesForm
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
            this.btnPiAsync = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnEulersNumber = new System.Windows.Forms.Button();
            this.btnFibSync = new System.Windows.Forms.Button();
            this.btnAutoResetEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPiAsync
            // 
            this.btnPiAsync.Location = new System.Drawing.Point(43, 39);
            this.btnPiAsync.Name = "btnPiAsync";
            this.btnPiAsync.Size = new System.Drawing.Size(94, 29);
            this.btnPiAsync.TabIndex = 0;
            this.btnPiAsync.Text = "Pi - async";
            this.btnPiAsync.UseVisualStyleBackColor = true;
            this.btnPiAsync.Click += new System.EventHandler(this.btnPiAsync_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(43, 166);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 20);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "None";
            // 
            // btnEulersNumber
            // 
            this.btnEulersNumber.Location = new System.Drawing.Point(43, 74);
            this.btnEulersNumber.Name = "btnEulersNumber";
            this.btnEulersNumber.Size = new System.Drawing.Size(94, 29);
            this.btnEulersNumber.TabIndex = 2;
            this.btnEulersNumber.Text = "e - sync";
            this.btnEulersNumber.UseVisualStyleBackColor = true;
            this.btnEulersNumber.Click += new System.EventHandler(this.btnEulersNumber_Click);
            // 
            // btnFibSync
            // 
            this.btnFibSync.Location = new System.Drawing.Point(43, 109);
            this.btnFibSync.Name = "btnFibSync";
            this.btnFibSync.Size = new System.Drawing.Size(94, 29);
            this.btnFibSync.TabIndex = 4;
            this.btnFibSync.Text = "fib - sync";
            this.btnFibSync.UseVisualStyleBackColor = true;
            this.btnFibSync.Click += new System.EventHandler(this.btnFibSync_Click);
            // 
            // btnAutoResetEvent
            // 
            this.btnAutoResetEvent.Location = new System.Drawing.Point(166, 39);
            this.btnAutoResetEvent.Name = "btnAutoResetEvent";
            this.btnAutoResetEvent.Size = new System.Drawing.Size(121, 29);
            this.btnAutoResetEvent.TabIndex = 5;
            this.btnAutoResetEvent.Text = "AutoResetEvent";
            this.btnAutoResetEvent.UseVisualStyleBackColor = true;
            this.btnAutoResetEvent.Click += new System.EventHandler(this.btnAutoResetEvent_Click);
            // 
            // PowerSeriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 281);
            this.Controls.Add(this.btnAutoResetEvent);
            this.Controls.Add(this.btnFibSync);
            this.Controls.Add(this.btnEulersNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPiAsync);
            this.Name = "PowerSeriesForm";
            this.Text = "Power Series";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPiAsync;
        private Label lblResult;
        private Button btnEulersNumber;
        private Button btnFibSync;
        private Button btnAutoResetEvent;
    }
}