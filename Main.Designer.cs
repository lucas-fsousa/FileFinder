namespace FileFinder {
  partial class Main {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.panel1 = new System.Windows.Forms.Panel();
      this.cb_exactMatch = new System.Windows.Forms.CheckBox();
      this.cb_onlyFirst = new System.Windows.Forms.CheckBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btn_find = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.tb_rootPath = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tb_filename = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.dgv_resultr = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_resultr)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Controls.Add(this.cb_exactMatch);
      this.panel1.Controls.Add(this.cb_onlyFirst);
      this.panel1.Location = new System.Drawing.Point(13, 53);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(214, 68);
      this.panel1.TabIndex = 0;
      // 
      // cb_exactMatch
      // 
      this.cb_exactMatch.AutoSize = true;
      this.cb_exactMatch.Location = new System.Drawing.Point(15, 41);
      this.cb_exactMatch.Name = "cb_exactMatch";
      this.cb_exactMatch.Size = new System.Drawing.Size(135, 19);
      this.cb_exactMatch.TabIndex = 1;
      this.cb_exactMatch.Text = "Just search precisely.";
      this.cb_exactMatch.UseVisualStyleBackColor = true;
      // 
      // cb_onlyFirst
      // 
      this.cb_onlyFirst.AutoSize = true;
      this.cb_onlyFirst.Location = new System.Drawing.Point(15, 16);
      this.cb_onlyFirst.Name = "cb_onlyFirst";
      this.cb_onlyFirst.Size = new System.Drawing.Size(187, 19);
      this.cb_onlyFirst.TabIndex = 0;
      this.cb_onlyFirst.Text = "Stop after finding a first match";
      this.cb_onlyFirst.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2.Controls.Add(this.btn_find);
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.panel1);
      this.panel2.Location = new System.Drawing.Point(12, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(507, 159);
      this.panel2.TabIndex = 1;
      // 
      // btn_find
      // 
      this.btn_find.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btn_find.Location = new System.Drawing.Point(129, 127);
      this.btn_find.Name = "btn_find";
      this.btn_find.Size = new System.Drawing.Size(249, 25);
      this.btn_find.TabIndex = 3;
      this.btn_find.Text = "FIND!";
      this.btn_find.UseVisualStyleBackColor = true;
      this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel3.Controls.Add(this.tb_rootPath);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Controls.Add(this.label2);
      this.panel3.Controls.Add(this.tb_filename);
      this.panel3.Location = new System.Drawing.Point(233, 53);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(264, 68);
      this.panel3.TabIndex = 2;
      this.panel3.TabStop = true;
      // 
      // tb_rootPath
      // 
      this.tb_rootPath.Location = new System.Drawing.Point(96, 32);
      this.tb_rootPath.Name = "tb_rootPath";
      this.tb_rootPath.Size = new System.Drawing.Size(189, 23);
      this.tb_rootPath.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(3, 36);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 19);
      this.label3.TabIndex = 2;
      this.label3.Text = "Root Path:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(3, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 19);
      this.label2.TabIndex = 1;
      this.label2.Text = "Filename:";
      // 
      // tb_filename
      // 
      this.tb_filename.Location = new System.Drawing.Point(96, 3);
      this.tb_filename.Name = "tb_filename";
      this.tb_filename.Size = new System.Drawing.Size(189, 23);
      this.tb_filename.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(145, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(196, 28);
      this.label1.TabIndex = 1;
      this.label1.Text = "Search Configuration";
      // 
      // panel4
      // 
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel4.Controls.Add(this.dgv_resultr);
      this.panel4.Location = new System.Drawing.Point(12, 177);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(507, 261);
      this.panel4.TabIndex = 2;
      // 
      // dgv_resultr
      // 
      this.dgv_resultr.AllowUserToAddRows = false;
      this.dgv_resultr.AllowUserToDeleteRows = false;
      this.dgv_resultr.AllowUserToResizeColumns = false;
      this.dgv_resultr.AllowUserToResizeRows = false;
      this.dgv_resultr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgv_resultr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_resultr.Cursor = System.Windows.Forms.Cursors.Hand;
      this.dgv_resultr.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_resultr.Location = new System.Drawing.Point(0, 0);
      this.dgv_resultr.Name = "dgv_resultr";
      this.dgv_resultr.ReadOnly = true;
      this.dgv_resultr.RowTemplate.Height = 25;
      this.dgv_resultr.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv_resultr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_resultr.Size = new System.Drawing.Size(503, 257);
      this.dgv_resultr.TabIndex = 3;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(533, 450);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_resultr)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox cb_exactMatch;
    private System.Windows.Forms.CheckBox cb_onlyFirst;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btn_find;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox tb_rootPath;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb_filename;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.DataGridView dgv_resultr;
  }
}
