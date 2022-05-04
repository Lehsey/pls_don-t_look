
namespace WinFormsApp1
{
    partial class Game_Window
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
            this.GameField = new System.Windows.Forms.Panel();
            this.Restart_button = new System.Windows.Forms.Button();
            this.Cur_score = new System.Windows.Forms.Button();
            this.Max_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BackColor = System.Drawing.Color.LightGray;
            this.GameField.Location = new System.Drawing.Point(0, 110);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(480, 365);
            this.GameField.TabIndex = 2;
            this.GameField.TabStop = true;
            // 
            // Restart_button
            // 
            this.Restart_button.Location = new System.Drawing.Point(10, 10);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(125, 90);
            this.Restart_button.TabIndex = 0;
            this.Restart_button.TabStop = false;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = true;
            this.Restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // Cur_score
            // 
            this.Cur_score.Enabled = false;
            this.Cur_score.Location = new System.Drawing.Point(210, 10);
            this.Cur_score.Name = "Cur_score";
            this.Cur_score.Size = new System.Drawing.Size(125, 90);
            this.Cur_score.TabIndex = 2;
            this.Cur_score.Text = "Current score\r\n0\r\n";
            this.Cur_score.UseVisualStyleBackColor = true;
            // 
            // Max_score
            // 
            this.Max_score.Enabled = false;
            this.Max_score.Location = new System.Drawing.Point(341, 10);
            this.Max_score.Name = "Max_score";
            this.Max_score.Size = new System.Drawing.Size(125, 90);
            this.Max_score.TabIndex = 3;
            this.Max_score.Text = "Max score\r\n0\r\n";
            this.Max_score.UseVisualStyleBackColor = true;
            // 
            // Game_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 475);
            this.Controls.Add(this.Max_score);
            this.Controls.Add(this.Cur_score);
            this.Controls.Add(this.Restart_button);
            this.Controls.Add(this.GameField);
            this.Name = "Game_Window";
            this.Text = "2048";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_Window_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Button Cur_score;
        private System.Windows.Forms.Button Max_score;
        protected System.Windows.Forms.Button Restart_button;
    }
}