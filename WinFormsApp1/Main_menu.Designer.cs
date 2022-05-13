
namespace WinFormsApp1
{
    partial class Main_menu
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
            this.Start_button = new System.Windows.Forms.Button();
            this.Score_button = new System.Windows.Forms.Button();
            this.Height_input = new System.Windows.Forms.TextBox();
            this.Width_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.Color.IndianRed;
            this.Start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Start_button.Location = new System.Drawing.Point(52, 317);
            this.Start_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(82, 33);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Score_button
            // 
            this.Score_button.BackColor = System.Drawing.Color.BlueViolet;
            this.Score_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Score_button.Location = new System.Drawing.Point(52, 280);
            this.Score_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Score_button.Name = "Score_button";
            this.Score_button.Size = new System.Drawing.Size(82, 33);
            this.Score_button.TabIndex = 1;
            this.Score_button.Text = "Score";
            this.Score_button.UseVisualStyleBackColor = false;
            this.Score_button.Click += new System.EventHandler(this.Score_button_Click);
            // 
            // Height_input
            // 
            this.Height_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Height_input.Location = new System.Drawing.Point(52, 231);
            this.Height_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Height_input.Name = "Height_input";
            this.Height_input.Size = new System.Drawing.Size(28, 24);
            this.Height_input.TabIndex = 2;
            this.Height_input.Text = "4";
            // 
            // Width_input
            // 
            this.Width_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Width_input.Location = new System.Drawing.Point(52, 188);
            this.Width_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Width_input.Name = "Width_input";
            this.Width_input.Size = new System.Drawing.Size(28, 24);
            this.Width_input.TabIndex = 3;
            this.Width_input.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(101, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(101, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(197, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Width_input);
            this.Controls.Add(this.Height_input);
            this.Controls.Add(this.Score_button);
            this.Controls.Add(this.Start_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_menu";
            this.Text = "Main_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Score_button;
        private System.Windows.Forms.TextBox Height_input;
        private System.Windows.Forms.TextBox Width_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}