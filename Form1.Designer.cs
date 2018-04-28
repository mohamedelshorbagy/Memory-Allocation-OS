namespace MemoryAllocation
{
    partial class Memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memory));
            this.grpBox_Allocate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Memory_From = new System.Windows.Forms.Label();
            this.lbl_Memory_Size = new System.Windows.Forms.Label();
            this.txtBox_Memory_From = new System.Windows.Forms.TextBox();
            this.txtBox_Memory_Size = new System.Windows.Forms.TextBox();
            this.btn_Allocate = new System.Windows.Forms.Button();
            this.grpBox_Grid_Process = new System.Windows.Forms.GroupBox();
            this.dataGridView_Process = new System.Windows.Forms.DataGridView();
            this.grpBox_Grid_Memory = new System.Windows.Forms.GroupBox();
            this.dataGridView_Memory = new System.Windows.Forms.DataGridView();
            this.grpBox_Process = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Process_Size = new System.Windows.Forms.Label();
            this.lbl_Process_ID = new System.Windows.Forms.Label();
            this.radio_WF = new System.Windows.Forms.RadioButton();
            this.txtBox_Process_Size = new System.Windows.Forms.TextBox();
            this.txtBox_Process_ID = new System.Windows.Forms.TextBox();
            this.radio_BF = new System.Windows.Forms.RadioButton();
            this.radio_FF = new System.Windows.Forms.RadioButton();
            this.btn_Ad = new System.Windows.Forms.Button();
            this.grpBox_Deallocate = new System.Windows.Forms.GroupBox();
            this.btn_Deallocate = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Holes = new System.Windows.Forms.Button();
            this.Process1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.grpBox_Allocate.SuspendLayout();
            this.grpBox_Grid_Process.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Process)).BeginInit();
            this.grpBox_Grid_Memory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Memory)).BeginInit();
            this.grpBox_Process.SuspendLayout();
            this.grpBox_Deallocate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Allocate
            // 
            this.grpBox_Allocate.Controls.Add(this.label3);
            this.grpBox_Allocate.Controls.Add(this.lbl_Memory_From);
            this.grpBox_Allocate.Controls.Add(this.lbl_Memory_Size);
            this.grpBox_Allocate.Controls.Add(this.txtBox_Memory_From);
            this.grpBox_Allocate.Controls.Add(this.txtBox_Memory_Size);
            this.grpBox_Allocate.Controls.Add(this.btn_Allocate);
            this.grpBox_Allocate.Location = new System.Drawing.Point(34, 20);
            this.grpBox_Allocate.Name = "grpBox_Allocate";
            this.grpBox_Allocate.Size = new System.Drawing.Size(344, 77);
            this.grpBox_Allocate.TabIndex = 0;
            this.grpBox_Allocate.TabStop = false;
            this.grpBox_Allocate.Text = "Memory Allocation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aldhabi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(182, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "In KB";
            // 
            // lbl_Memory_From
            // 
            this.lbl_Memory_From.AutoSize = true;
            this.lbl_Memory_From.Location = new System.Drawing.Point(42, 58);
            this.lbl_Memory_From.Name = "lbl_Memory_From";
            this.lbl_Memory_From.Size = new System.Drawing.Size(30, 13);
            this.lbl_Memory_From.TabIndex = 4;
            this.lbl_Memory_From.Text = "From";
            // 
            // lbl_Memory_Size
            // 
            this.lbl_Memory_Size.AutoSize = true;
            this.lbl_Memory_Size.Location = new System.Drawing.Point(42, 25);
            this.lbl_Memory_Size.Name = "lbl_Memory_Size";
            this.lbl_Memory_Size.Size = new System.Drawing.Size(27, 13);
            this.lbl_Memory_Size.TabIndex = 4;
            this.lbl_Memory_Size.Text = "Size";
            // 
            // txtBox_Memory_From
            // 
            this.txtBox_Memory_From.Location = new System.Drawing.Point(89, 51);
            this.txtBox_Memory_From.Name = "txtBox_Memory_From";
            this.txtBox_Memory_From.Size = new System.Drawing.Size(87, 20);
            this.txtBox_Memory_From.TabIndex = 1;
            // 
            // txtBox_Memory_Size
            // 
            this.txtBox_Memory_Size.Location = new System.Drawing.Point(89, 19);
            this.txtBox_Memory_Size.Name = "txtBox_Memory_Size";
            this.txtBox_Memory_Size.Size = new System.Drawing.Size(87, 20);
            this.txtBox_Memory_Size.TabIndex = 1;
            // 
            // btn_Allocate
            // 
            this.btn_Allocate.Location = new System.Drawing.Point(243, 14);
            this.btn_Allocate.Name = "btn_Allocate";
            this.btn_Allocate.Size = new System.Drawing.Size(78, 48);
            this.btn_Allocate.TabIndex = 0;
            this.btn_Allocate.Text = "Add Hole";
            this.btn_Allocate.UseVisualStyleBackColor = true;
            this.btn_Allocate.Click += new System.EventHandler(this.btn_Allocate_Click);
            // 
            // grpBox_Grid_Process
            // 
            this.grpBox_Grid_Process.Controls.Add(this.dataGridView_Process);
            this.grpBox_Grid_Process.Location = new System.Drawing.Point(394, 12);
            this.grpBox_Grid_Process.Name = "grpBox_Grid_Process";
            this.grpBox_Grid_Process.Size = new System.Drawing.Size(360, 530);
            this.grpBox_Grid_Process.TabIndex = 2;
            this.grpBox_Grid_Process.TabStop = false;
            this.grpBox_Grid_Process.Text = "Process";
            // 
            // dataGridView_Process
            // 
            this.dataGridView_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Process.Location = new System.Drawing.Point(6, 13);
            this.dataGridView_Process.Name = "dataGridView_Process";
            this.dataGridView_Process.Size = new System.Drawing.Size(343, 511);
            this.dataGridView_Process.TabIndex = 2;
            // 
            // grpBox_Grid_Memory
            // 
            this.grpBox_Grid_Memory.Controls.Add(this.dataGridView_Memory);
            this.grpBox_Grid_Memory.Location = new System.Drawing.Point(760, 12);
            this.grpBox_Grid_Memory.Name = "grpBox_Grid_Memory";
            this.grpBox_Grid_Memory.Size = new System.Drawing.Size(352, 530);
            this.grpBox_Grid_Memory.TabIndex = 3;
            this.grpBox_Grid_Memory.TabStop = false;
            this.grpBox_Grid_Memory.Text = "Memory";
            // 
            // dataGridView_Memory
            // 
            this.dataGridView_Memory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Memory.Location = new System.Drawing.Point(0, 13);
            this.dataGridView_Memory.Name = "dataGridView_Memory";
            this.dataGridView_Memory.Size = new System.Drawing.Size(346, 511);
            this.dataGridView_Memory.TabIndex = 0;
            // 
            // grpBox_Process
            // 
            this.grpBox_Process.Controls.Add(this.label6);
            this.grpBox_Process.Controls.Add(this.lbl_Process_Size);
            this.grpBox_Process.Controls.Add(this.lbl_Process_ID);
            this.grpBox_Process.Controls.Add(this.radio_WF);
            this.grpBox_Process.Controls.Add(this.txtBox_Process_Size);
            this.grpBox_Process.Controls.Add(this.txtBox_Process_ID);
            this.grpBox_Process.Controls.Add(this.radio_BF);
            this.grpBox_Process.Controls.Add(this.radio_FF);
            this.grpBox_Process.Controls.Add(this.btn_Ad);
            this.grpBox_Process.Location = new System.Drawing.Point(34, 103);
            this.grpBox_Process.Name = "grpBox_Process";
            this.grpBox_Process.Size = new System.Drawing.Size(344, 130);
            this.grpBox_Process.TabIndex = 4;
            this.grpBox_Process.TabStop = false;
            this.grpBox_Process.Text = "Process";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Aldhabi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(176, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "In KB";
            // 
            // lbl_Process_Size
            // 
            this.lbl_Process_Size.AutoSize = true;
            this.lbl_Process_Size.Location = new System.Drawing.Point(36, 105);
            this.lbl_Process_Size.Name = "lbl_Process_Size";
            this.lbl_Process_Size.Size = new System.Drawing.Size(27, 13);
            this.lbl_Process_Size.TabIndex = 5;
            this.lbl_Process_Size.Text = "Size";
            // 
            // lbl_Process_ID
            // 
            this.lbl_Process_ID.AutoSize = true;
            this.lbl_Process_ID.Location = new System.Drawing.Point(46, 62);
            this.lbl_Process_ID.Name = "lbl_Process_ID";
            this.lbl_Process_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_Process_ID.TabIndex = 5;
            this.lbl_Process_ID.Text = "ID";
            // 
            // radio_WF
            // 
            this.radio_WF.AutoSize = true;
            this.radio_WF.Location = new System.Drawing.Point(236, 19);
            this.radio_WF.Name = "radio_WF";
            this.radio_WF.Size = new System.Drawing.Size(67, 17);
            this.radio_WF.TabIndex = 1;
            this.radio_WF.TabStop = true;
            this.radio_WF.Text = "Worst Fit";
            this.radio_WF.UseVisualStyleBackColor = true;
            // 
            // txtBox_Process_Size
            // 
            this.txtBox_Process_Size.Location = new System.Drawing.Point(83, 98);
            this.txtBox_Process_Size.Name = "txtBox_Process_Size";
            this.txtBox_Process_Size.Size = new System.Drawing.Size(87, 20);
            this.txtBox_Process_Size.TabIndex = 1;
            // 
            // txtBox_Process_ID
            // 
            this.txtBox_Process_ID.Location = new System.Drawing.Point(83, 55);
            this.txtBox_Process_ID.Name = "txtBox_Process_ID";
            this.txtBox_Process_ID.Size = new System.Drawing.Size(87, 20);
            this.txtBox_Process_ID.TabIndex = 1;
            // 
            // radio_BF
            // 
            this.radio_BF.AutoSize = true;
            this.radio_BF.Location = new System.Drawing.Point(129, 19);
            this.radio_BF.Name = "radio_BF";
            this.radio_BF.Size = new System.Drawing.Size(60, 17);
            this.radio_BF.TabIndex = 1;
            this.radio_BF.TabStop = true;
            this.radio_BF.Text = "Best Fit";
            this.radio_BF.UseVisualStyleBackColor = true;
            // 
            // radio_FF
            // 
            this.radio_FF.AutoSize = true;
            this.radio_FF.Location = new System.Drawing.Point(39, 19);
            this.radio_FF.Name = "radio_FF";
            this.radio_FF.Size = new System.Drawing.Size(58, 17);
            this.radio_FF.TabIndex = 1;
            this.radio_FF.TabStop = true;
            this.radio_FF.Text = "First Fit";
            this.radio_FF.UseVisualStyleBackColor = true;
            // 
            // btn_Ad
            // 
            this.btn_Ad.Location = new System.Drawing.Point(243, 42);
            this.btn_Ad.Name = "btn_Ad";
            this.btn_Ad.Size = new System.Drawing.Size(78, 80);
            this.btn_Ad.TabIndex = 0;
            this.btn_Ad.Text = "Add Process";
            this.btn_Ad.UseVisualStyleBackColor = true;
            this.btn_Ad.Click += new System.EventHandler(this.btn_Ad_Click);
            // 
            // grpBox_Deallocate
            // 
            this.grpBox_Deallocate.Controls.Add(this.btn_Deallocate);
            this.grpBox_Deallocate.Location = new System.Drawing.Point(34, 239);
            this.grpBox_Deallocate.Name = "grpBox_Deallocate";
            this.grpBox_Deallocate.Size = new System.Drawing.Size(344, 52);
            this.grpBox_Deallocate.TabIndex = 5;
            this.grpBox_Deallocate.TabStop = false;
            this.grpBox_Deallocate.Text = "Memory Deallocation";
            // 
            // btn_Deallocate
            // 
            this.btn_Deallocate.Location = new System.Drawing.Point(105, 19);
            this.btn_Deallocate.Name = "btn_Deallocate";
            this.btn_Deallocate.Size = new System.Drawing.Size(149, 23);
            this.btn_Deallocate.TabIndex = 0;
            this.btn_Deallocate.Text = "Remove Prcoess";
            this.btn_Deallocate.UseVisualStyleBackColor = true;
            this.btn_Deallocate.Click += new System.EventHandler(this.btn_Deallocate_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(139, 358);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(150, 50);
            this.btn_Help.TabIndex = 7;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1118, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Memory";
            // 
            // Holes
            // 
            this.Holes.BackColor = System.Drawing.Color.FromArgb(231,70,69);
            this.Holes.Enabled = false;
            this.Holes.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Holes.Location = new System.Drawing.Point(1207, 1);
            this.Holes.Name = "Holes";
            this.Holes.Size = new System.Drawing.Size(64, 26);
            this.Holes.TabIndex = 9;
            this.Holes.Text = "Holes";
            this.Holes.UseVisualStyleBackColor = false;
            // 
            // Process1
            // 
            this.Process1.BackColor = System.Drawing.Color.FromArgb(42,204,113);
            this.Process1.Enabled = false;
            this.Process1.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process1.Location = new System.Drawing.Point(1286, 1);
            this.Process1.Name = "Process1";
            this.Process1.Size = new System.Drawing.Size(64, 26);
            this.Process1.TabIndex = 9;
            this.Process1.Text = "Process";
            this.Process1.UseVisualStyleBackColor = false;
            this.Process1.Click += new System.EventHandler(this.Process1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1135, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 512);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(139, 459);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(150, 50);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1362, 554);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Process1);
            this.Controls.Add(this.Holes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.grpBox_Deallocate);
            this.Controls.Add(this.grpBox_Process);
            this.Controls.Add(this.grpBox_Grid_Memory);
            this.Controls.Add(this.grpBox_Grid_Process);
            this.Controls.Add(this.grpBox_Allocate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Memory";
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Memory_Load);
            this.grpBox_Allocate.ResumeLayout(false);
            this.grpBox_Allocate.PerformLayout();
            this.grpBox_Grid_Process.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Process)).EndInit();
            this.grpBox_Grid_Memory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Memory)).EndInit();
            this.grpBox_Process.ResumeLayout(false);
            this.grpBox_Process.PerformLayout();
            this.grpBox_Deallocate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Allocate;
        private System.Windows.Forms.GroupBox grpBox_Grid_Process;
        private System.Windows.Forms.DataGridView dataGridView_Process;
        private System.Windows.Forms.GroupBox grpBox_Grid_Memory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Memory_From;
        private System.Windows.Forms.Label lbl_Memory_Size;
        private System.Windows.Forms.TextBox txtBox_Memory_From;
        private System.Windows.Forms.TextBox txtBox_Memory_Size;
        private System.Windows.Forms.Button btn_Allocate;
        private System.Windows.Forms.GroupBox grpBox_Process;
        private System.Windows.Forms.RadioButton radio_WF;
        private System.Windows.Forms.RadioButton radio_BF;
        private System.Windows.Forms.RadioButton radio_FF;
        private System.Windows.Forms.Button btn_Ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Process_Size;
        private System.Windows.Forms.Label lbl_Process_ID;
        private System.Windows.Forms.TextBox txtBox_Process_Size;
        private System.Windows.Forms.TextBox txtBox_Process_ID;
        private System.Windows.Forms.GroupBox grpBox_Deallocate;
        private System.Windows.Forms.Button btn_Deallocate;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Holes;
        private System.Windows.Forms.Button Process1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Memory;
        private System.Windows.Forms.Button btn_Reset;
    }
}

