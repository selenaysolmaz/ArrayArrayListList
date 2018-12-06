namespace WindowsFormsApp5
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
            this.btnarray = new System.Windows.Forms.Button();
            this.btnarraylist = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnbutonlar = new System.Windows.Forms.Button();
            this.btnrenk = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnarray
            // 
            this.btnarray.Location = new System.Drawing.Point(12, 23);
            this.btnarray.Name = "btnarray";
            this.btnarray.Size = new System.Drawing.Size(93, 41);
            this.btnarray.TabIndex = 0;
            this.btnarray.Text = "array";
            this.btnarray.UseVisualStyleBackColor = true;
            this.btnarray.Click += new System.EventHandler(this.btnarray_Click);
            // 
            // btnarraylist
            // 
            this.btnarraylist.Location = new System.Drawing.Point(114, 23);
            this.btnarraylist.Name = "btnarraylist";
            this.btnarraylist.Size = new System.Drawing.Size(99, 41);
            this.btnarraylist.TabIndex = 1;
            this.btnarraylist.Text = "array list";
            this.btnarraylist.UseVisualStyleBackColor = true;
            this.btnarraylist.Click += new System.EventHandler(this.btnarraylist_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(219, 23);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(108, 41);
            this.btnlist.TabIndex = 2;
            this.btnlist.Text = "list";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnbutonlar
            // 
            this.btnbutonlar.Location = new System.Drawing.Point(333, 23);
            this.btnbutonlar.Name = "btnbutonlar";
            this.btnbutonlar.Size = new System.Drawing.Size(105, 41);
            this.btnbutonlar.TabIndex = 3;
            this.btnbutonlar.Text = "butonlar";
            this.btnbutonlar.UseVisualStyleBackColor = true;
            this.btnbutonlar.Click += new System.EventHandler(this.btnbutonlar_Click);
            // 
            // btnrenk
            // 
            this.btnrenk.Location = new System.Drawing.Point(444, 23);
            this.btnrenk.Name = "btnrenk";
            this.btnrenk.Size = new System.Drawing.Size(101, 41);
            this.btnrenk.TabIndex = 4;
            this.btnrenk.Text = "renk";
            this.btnrenk.UseVisualStyleBackColor = true;
            this.btnrenk.Click += new System.EventHandler(this.btnrenk_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 85);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(266, 199);
            this.listbox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(293, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 196);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btnrenk);
            this.Controls.Add(this.btnbutonlar);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.btnarraylist);
            this.Controls.Add(this.btnarray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnarray;
        private System.Windows.Forms.Button btnarraylist;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnbutonlar;
        private System.Windows.Forms.Button btnrenk;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}

