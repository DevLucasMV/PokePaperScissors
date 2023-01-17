namespace PokePaperScissors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.lblCPUChoice = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.lblCPUresult = new System.Windows.Forms.Label();
            this.lblFinalResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(157, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 225);
            this.button1.TabIndex = 0;
            this.button1.Tag = "V";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChooseEvent);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(527, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 225);
            this.button2.TabIndex = 1;
            this.button2.Tag = "C";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChooseEvent);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(901, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 225);
            this.button3.TabIndex = 2;
            this.button3.Tag = "B";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChooseEvent);
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.Location = new System.Drawing.Point(578, 30);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(136, 126);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 3;
            this.CPU_PIC.TabStop = false;
            this.CPU_PIC.Click += new System.EventHandler(this.CPU_PIC_Click);
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.Location = new System.Drawing.Point(578, 283);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(136, 126);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 4;
            this.PLAYER_PIC.TabStop = false;
            this.PLAYER_PIC.Click += new System.EventHandler(this.PLAYER_PIC_Click);
            // 
            // lblCPUChoice
            // 
            this.lblCPUChoice.AutoSize = true;
            this.lblCPUChoice.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPUChoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCPUChoice.Location = new System.Drawing.Point(551, -1);
            this.lblCPUChoice.Name = "lblCPUChoice";
            this.lblCPUChoice.Size = new System.Drawing.Size(183, 28);
            this.lblCPUChoice.TabIndex = 5;
            this.lblCPUChoice.Text = "Computer\'s Choice";
            this.lblCPUChoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCPUChoice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerChoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerChoice.Location = new System.Drawing.Point(578, 412);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(144, 28);
            this.lblPlayerChoice.TabIndex = 6;
            this.lblPlayerChoice.Text = "Player\'s choice";
            this.lblPlayerChoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerResult.Location = new System.Drawing.Point(98, 246);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(128, 28);
            this.lblPlayerResult.TabIndex = 7;
            this.lblPlayerResult.Text = "Player Result";
            this.lblPlayerResult.Click += new System.EventHandler(this.lblPlayerResult_Click);
            // 
            // lblCPUresult
            // 
            this.lblCPUresult.AutoSize = true;
            this.lblCPUresult.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPUresult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCPUresult.Location = new System.Drawing.Point(1056, 246);
            this.lblCPUresult.Name = "lblCPUresult";
            this.lblCPUresult.Size = new System.Drawing.Size(107, 28);
            this.lblCPUresult.TabIndex = 8;
            this.lblCPUresult.Text = "CPU result";
            // 
            // lblFinalResult
            // 
            this.lblFinalResult.AutoSize = true;
            this.lblFinalResult.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinalResult.Location = new System.Drawing.Point(551, 207);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(0, 28);
            this.lblFinalResult.TabIndex = 9;
            this.lblFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1300, 693);
            this.Controls.Add(this.lblFinalResult);
            this.Controls.Add(this.lblCPUresult);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblCPUChoice);
            this.Controls.Add(this.PLAYER_PIC);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Tag = "V";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.ChooseEvent);
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox CPU_PIC;
        private PictureBox PLAYER_PIC;
        private Label lblCPUChoice;
        private Label lblPlayerChoice;
        private Label lblPlayerResult;
        private Label lblCPUresult;
        private Label lblFinalResult;
    }
}