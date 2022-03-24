
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
            this.Restart_button.Location = new System.Drawing.Point(13, 13);
            this.Restart_button.Name = "Restart_button";
            this.Restart_button.Size = new System.Drawing.Size(125, 91);
            this.Restart_button.TabIndex = 1;
            this.Restart_button.Text = "Restart";
            this.Restart_button.UseVisualStyleBackColor = true;
            // 
            // Game_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 475);
            this.Controls.Add(this.Restart_button);
            this.Controls.Add(this.GameField);
            this.Name = "Game_Window";
            this.Text = "Game_field";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GameField;
        private System.Windows.Forms.Button Restart_button;
    }
}