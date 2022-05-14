
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
            this.GameField.Location = new System.Drawing.Point(0, 82);
            this.GameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(420, 274);
            this.GameField.TabIndex = 2;
            this.GameField.TabStop = true;
            // 
            // Restart_button
            // 
            this.Restart_button.BackColor = System.Drawing.Color.Yellow;
            this.Restart_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Restart_button.Location = new System.Drawing.Point(9, 8);
            this.Restart_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(109, 68);
            this.Restart_button.TabIndex = 0;
            this.Restart_button.TabStop = false;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = false;
            this.Restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // Cur_score
            // 
            this.Cur_score.BackColor = System.Drawing.Color.Green;
            this.Cur_score.Enabled = false;
            this.Cur_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Cur_score.Location = new System.Drawing.Point(183, 8);
            this.Cur_score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cur_score.Name = "Cur_score";
            this.Cur_score.Size = new System.Drawing.Size(109, 68);
            this.Cur_score.TabIndex = 2;
            this.Cur_score.Text = "0";
            this.Cur_score.UseVisualStyleBackColor = false;
            // 
            // Max_score
            // 
            this.Max_score.BackColor = System.Drawing.Color.Green;
            this.Max_score.Enabled = false;
            this.Max_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Max_score.Location = new System.Drawing.Point(298, 8);
            this.Max_score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Max_score.Name = "Max_score";
            this.Max_score.Size = new System.Drawing.Size(109, 68);
            this.Max_score.TabIndex = 3;
            this.Max_score.Text = "0";
            this.Max_score.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(322, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max score";
            // 
            // Game_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(418, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Max_score);
            this.Controls.Add(this.Cur_score);
            this.Controls.Add(this.Restart_button);
            this.Controls.Add(this.GameField);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game_Window";
            this.Text = "2048";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_Window_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Button Cur_score;
        private System.Windows.Forms.Button Max_score;
        protected System.Windows.Forms.Button Restart_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}