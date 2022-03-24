
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
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
            this.Start_button.Location = new System.Drawing.Point(60, 423);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(94, 29);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Score_button
            // 
            this.Score_button.Location = new System.Drawing.Point(60, 374);
            this.Score_button.Name = "Score_button";
            this.Score_button.Size = new System.Drawing.Size(94, 29);
            this.Score_button.TabIndex = 1;
            this.Score_button.Text = "Score";
            this.Score_button.UseVisualStyleBackColor = true;
            this.Score_button.Click += new System.EventHandler(this.Score_button_Click);
            // 
            // Height_input
            // 
            this.Height_input.Location = new System.Drawing.Point(60, 308);
            this.Height_input.Name = "Height_input";
            this.Height_input.Size = new System.Drawing.Size(32, 27);
            this.Height_input.TabIndex = 2;
            // 
            // Width_input
            // 
            this.Width_input.Location = new System.Drawing.Point(60, 251);
            this.Width_input.Name = "Width_input";
            this.Width_input.Size = new System.Drawing.Size(32, 27);
            this.Width_input.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(225, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Width_input);
            this.Controls.Add(this.Height_input);
            this.Controls.Add(this.Score_button);
            this.Controls.Add(this.Start_button);
            this.Name = "Main_menu";
            this.Text = "Main_menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Score_button;
        private System.Windows.Forms.TextBox Height_input;
        private System.Windows.Forms.TextBox Width_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}