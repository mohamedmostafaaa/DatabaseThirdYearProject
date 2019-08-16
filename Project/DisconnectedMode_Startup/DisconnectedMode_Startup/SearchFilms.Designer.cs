namespace DisconnectedMode_Startup
{
    partial class SearchFilms
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
            this.txt_ActorName = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.dgv_Films = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Films)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actor Name";
            // 
            // txt_ActorName
            // 
            this.txt_ActorName.Location = new System.Drawing.Point(83, 24);
            this.txt_ActorName.Name = "txt_ActorName";
            this.txt_ActorName.Size = new System.Drawing.Size(141, 20);
            this.txt_ActorName.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(157, 62);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(84, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dgv_Films
            // 
            this.dgv_Films.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Films.Location = new System.Drawing.Point(56, 91);
            this.dgv_Films.Name = "dgv_Films";
            this.dgv_Films.Size = new System.Drawing.Size(285, 170);
            this.dgv_Films.TabIndex = 4;
            // 
            // SearchFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 275);
            this.Controls.Add(this.dgv_Films);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_ActorName);
            this.Controls.Add(this.label1);
            this.Name = "SearchFilms";
            this.Text = "SearchFilms";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Films)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ActorName;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dgv_Films;
    }
}