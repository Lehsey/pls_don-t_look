
namespace WinFormsApp1
{
    partial class Scores_list
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Player_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player_name,
            this.Player_score});
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(694, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // Player_name
            // 
            this.Player_name.HeaderText = "Name";
            this.Player_name.MinimumWidth = 6;
            this.Player_name.Name = "Player_name";
            this.Player_name.ReadOnly = true;
            this.Player_name.Width = 320;
            // 
            // Player_score
            // 
            this.Player_score.HeaderText = "Score";
            this.Player_score.MinimumWidth = 6;
            this.Player_score.Name = "Player_score";
            this.Player_score.ReadOnly = true;
            this.Player_score.Width = 320;
            // 
            // Scores_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 395);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Scores_list";
            this.Text = "Scores_list";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_score;
    }
}