namespace Databaza_Skupin
{
    partial class EditForm
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
            this.textBox_nazov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_rok = new System.Windows.Forms.NumericUpDown();
            this.listBox_albums = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_albumAdd = new System.Windows.Forms.Button();
            this.textBox_albumName = new System.Windows.Forms.TextBox();
            this.button_albumRemove = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Názov";
            // 
            // textBox_nazov
            // 
            this.textBox_nazov.Location = new System.Drawing.Point(54, 10);
            this.textBox_nazov.Name = "textBox_nazov";
            this.textBox_nazov.Size = new System.Drawing.Size(148, 20);
            this.textBox_nazov.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rok založenia";
            // 
            // numericUpDown_rok
            // 
            this.numericUpDown_rok.Location = new System.Drawing.Point(288, 10);
            this.numericUpDown_rok.Maximum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numericUpDown_rok.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown_rok.Name = "numericUpDown_rok";
            this.numericUpDown_rok.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_rok.TabIndex = 3;
            this.numericUpDown_rok.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // listBox_albums
            // 
            this.listBox_albums.FormattingEnabled = true;
            this.listBox_albums.Location = new System.Drawing.Point(16, 59);
            this.listBox_albums.Name = "listBox_albums";
            this.listBox_albums.Size = new System.Drawing.Size(339, 95);
            this.listBox_albums.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diskografia";
            // 
            // button_albumAdd
            // 
            this.button_albumAdd.Location = new System.Drawing.Point(184, 160);
            this.button_albumAdd.Name = "button_albumAdd";
            this.button_albumAdd.Size = new System.Drawing.Size(75, 23);
            this.button_albumAdd.TabIndex = 6;
            this.button_albumAdd.Text = "Pridaj album";
            this.button_albumAdd.UseVisualStyleBackColor = true;
            this.button_albumAdd.Click += new System.EventHandler(this.button_albumAdd_Click);
            // 
            // textBox_albumName
            // 
            this.textBox_albumName.Location = new System.Drawing.Point(16, 160);
            this.textBox_albumName.Name = "textBox_albumName";
            this.textBox_albumName.Size = new System.Drawing.Size(162, 20);
            this.textBox_albumName.TabIndex = 7;
            // 
            // button_albumRemove
            // 
            this.button_albumRemove.Location = new System.Drawing.Point(265, 160);
            this.button_albumRemove.Name = "button_albumRemove";
            this.button_albumRemove.Size = new System.Drawing.Size(90, 23);
            this.button_albumRemove.TabIndex = 8;
            this.button_albumRemove.Text = "Vymaž album";
            this.button_albumRemove.UseVisualStyleBackColor = true;
            this.button_albumRemove.Click += new System.EventHandler(this.button_albumRemove_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(16, 246);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Uložiť";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(97, 246);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Zrušiť";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 281);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_albumRemove);
            this.Controls.Add(this.textBox_albumName);
            this.Controls.Add(this.button_albumAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_albums);
            this.Controls.Add(this.numericUpDown_rok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nazov);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "Skupina";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nazov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_rok;
        private System.Windows.Forms.ListBox listBox_albums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_albumAdd;
        private System.Windows.Forms.TextBox textBox_albumName;
        private System.Windows.Forms.Button button_albumRemove;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}