
namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_input = new System.Windows.Forms.TextBox();
            this.Enter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imput your name";
            // 
            // Name_input
            // 
            this.Name_input.Location = new System.Drawing.Point(100, 134);
            this.Name_input.Name = "Name_input";
            this.Name_input.Size = new System.Drawing.Size(311, 27);
            this.Name_input.TabIndex = 4;
            // 
            // Enter_button
            // 
            this.Enter_button.Location = new System.Drawing.Point(204, 167);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(94, 29);
            this.Enter_button.TabIndex = 5;
            this.Enter_button.Text = "Enter";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 486);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.Name_input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_input;
        private System.Windows.Forms.Button Enter_button;
    }
}