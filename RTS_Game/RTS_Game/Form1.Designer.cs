namespace RTS_Game
{
    partial class Form1
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
            this.tBox_Map = new System.Windows.Forms.TextBox();
            this.lbl_Round = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.lBox1 = new System.Windows.Forms.ListBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBox_Map
            // 
            this.tBox_Map.Location = new System.Drawing.Point(12, 82);
            this.tBox_Map.Multiline = true;
            this.tBox_Map.Name = "tBox_Map";
            this.tBox_Map.Size = new System.Drawing.Size(398, 348);
            this.tBox_Map.TabIndex = 0;
            // 
            // lbl_Round
            // 
            this.lbl_Round.AutoSize = true;
            this.lbl_Round.Location = new System.Drawing.Point(12, 48);
            this.lbl_Round.Name = "lbl_Round";
            this.lbl_Round.Size = new System.Drawing.Size(58, 17);
            this.lbl_Round.TabIndex = 1;
            this.lbl_Round.Text = "Round: ";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(579, 348);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(96, 82);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(692, 348);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(96, 82);
            this.btn_Pause.TabIndex = 3;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.lBox1);
            this.GroupBox.Location = new System.Drawing.Point(4, 13);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(792, 435);
            this.GroupBox.TabIndex = 5;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "groupBox1";
            // 
            // lBox1
            // 
            this.lBox1.FormattingEnabled = true;
            this.lBox1.ItemHeight = 16;
            this.lBox1.Location = new System.Drawing.Point(575, 69);
            this.lBox1.Name = "lBox1";
            this.lBox1.Size = new System.Drawing.Size(209, 260);
            this.lBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Round);
            this.Controls.Add(this.tBox_Map);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = "RTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_Map;
        private System.Windows.Forms.Label lbl_Round;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.ListBox lBox1;
    }
}

