
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BackColor = System.Drawing.Color.LightGray;
            this.GameField.Location = new System.Drawing.Point(0, 110);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(480, 365);
            this.GameField.TabIndex = 0;
            // 
            // Restart_button
            // 
            this.Restart_button.Location = new System.Drawing.Point(10, 10);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(125, 90);
            this.Restart_button.TabIndex = 1;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = true;
            // 
            // Cur_score
            // 
<<<<<<< Updated upstream
            this.Cur_score.Location = new System.Drawing.Point(210, 10);
=======
            this.Cur_score.Enabled = false;
            this.Cur_score.Location = new System.Drawing.Point(210, 12);
>>>>>>> Stashed changes
            this.Cur_score.Name = "Cur_score";
            this.Cur_score.Size = new System.Drawing.Size(125, 88);
            this.Cur_score.TabIndex = 2;
            this.Cur_score.Text = "0\r\n";
            this.Cur_score.UseVisualStyleBackColor = true;
            // 
            // Max_score
            // 
            this.Max_score.Location = new System.Drawing.Point(341, 10);
            this.Max_score.Name = "Max_score";
            this.Max_score.Size = new System.Drawing.Size(125, 94);
            this.Max_score.TabIndex = 3;
            this.Max_score.Text = "\r\n0\r\n";
            this.Max_score.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max score";
            // 
            // Game_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Max_score);
            this.Controls.Add(this.Cur_score);
            this.Controls.Add(this.Restart_button);
            this.Controls.Add(this.GameField);
            this.Name = "Game_Window";
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.Button Cur_score;
        private System.Windows.Forms.Button Max_score;
<<<<<<< Updated upstream
=======
        protected System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
>>>>>>> Stashed changes
    }
}