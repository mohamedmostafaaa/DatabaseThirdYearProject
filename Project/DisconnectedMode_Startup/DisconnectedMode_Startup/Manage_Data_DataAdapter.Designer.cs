namespace DisconnectedMode_Startup
{
    partial class Manage_Data_DataAdapter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_actors = new System.Windows.Forms.RadioButton();
            this.rdo_members = new System.Windows.Forms.RadioButton();
            this.loadInformation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_actors);
            this.groupBox1.Controls.Add(this.rdo_members);
            this.groupBox1.Location = new System.Drawing.Point(170, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdo_actors
            // 
            this.rdo_actors.AutoSize = true;
            this.rdo_actors.Location = new System.Drawing.Point(30, 48);
            this.rdo_actors.Name = "rdo_actors";
            this.rdo_actors.Size = new System.Drawing.Size(110, 17);
            this.rdo_actors.TabIndex = 1;
            this.rdo_actors.Text = "Actors Information";
            this.rdo_actors.UseVisualStyleBackColor = true;
            // 
            // rdo_members
            // 
            this.rdo_members.AutoSize = true;
            this.rdo_members.Checked = true;
            this.rdo_members.Location = new System.Drawing.Point(29, 24);
            this.rdo_members.Name = "rdo_members";
            this.rdo_members.Size = new System.Drawing.Size(123, 17);
            this.rdo_members.TabIndex = 0;
            this.rdo_members.TabStop = true;
            this.rdo_members.Text = "Members Information";
            this.rdo_members.UseVisualStyleBackColor = true;
            // 
            // loadInformation
            // 
            this.loadInformation.Location = new System.Drawing.Point(207, 101);
            this.loadInformation.Name = "loadInformation";
            this.loadInformation.Size = new System.Drawing.Size(96, 23);
            this.loadInformation.TabIndex = 1;
            this.loadInformation.Text = "Load Information";
            this.loadInformation.UseVisualStyleBackColor = true;
            this.loadInformation.Click += new System.EventHandler(this.loadInformation_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 182);
            this.dataGridView1.TabIndex = 2;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(207, 326);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Manage_Data_DataAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 355);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.loadInformation);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manage_Data_DataAdapter";
            this.Text = "Manage_Data_DataAdapter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_actors;
        private System.Windows.Forms.RadioButton rdo_members;
        private System.Windows.Forms.Button loadInformation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save;
    }
}