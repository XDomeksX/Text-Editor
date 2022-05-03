namespace Text_Editor
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
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.CMBfile = new System.Windows.Forms.ComboBox();
            this.CMBtools = new System.Windows.Forms.ComboBox();
            this.BTNopen = new System.Windows.Forms.Button();
            this.BTNsave = new System.Windows.Forms.Button();
            this.BTNnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB
            // 
            this.RTB.Location = new System.Drawing.Point(12, 40);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(523, 398);
            this.RTB.TabIndex = 0;
            this.RTB.Text = "";
            // 
            // CMBfile
            // 
            this.CMBfile.FormattingEnabled = true;
            this.CMBfile.Items.AddRange(new object[] {
            "Open",
            "Save"});
            this.CMBfile.Location = new System.Drawing.Point(13, 13);
            this.CMBfile.Name = "CMBfile";
            this.CMBfile.Size = new System.Drawing.Size(121, 21);
            this.CMBfile.TabIndex = 1;
            // 
            // CMBtools
            // 
            this.CMBtools.FormattingEnabled = true;
            this.CMBtools.Items.AddRange(new object[] {
            "Bold",
            "Italic",
            "Underline"});
            this.CMBtools.Location = new System.Drawing.Point(154, 13);
            this.CMBtools.Name = "CMBtools";
            this.CMBtools.Size = new System.Drawing.Size(121, 21);
            this.CMBtools.TabIndex = 2;
            // 
            // BTNopen
            // 
            this.BTNopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNopen.Location = new System.Drawing.Point(584, 193);
            this.BTNopen.Name = "BTNopen";
            this.BTNopen.Size = new System.Drawing.Size(171, 72);
            this.BTNopen.TabIndex = 3;
            this.BTNopen.Text = "Open";
            this.BTNopen.UseVisualStyleBackColor = true;
            this.BTNopen.Click += new System.EventHandler(this.BTNopen_Click);
            // 
            // BTNsave
            // 
            this.BTNsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNsave.Location = new System.Drawing.Point(584, 319);
            this.BTNsave.Name = "BTNsave";
            this.BTNsave.Size = new System.Drawing.Size(171, 72);
            this.BTNsave.TabIndex = 4;
            this.BTNsave.Text = "Save";
            this.BTNsave.UseVisualStyleBackColor = true;
            this.BTNsave.Click += new System.EventHandler(this.BTNsave_Click);
            // 
            // BTNnew
            // 
            this.BTNnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNnew.Location = new System.Drawing.Point(584, 64);
            this.BTNnew.Name = "BTNnew";
            this.BTNnew.Size = new System.Drawing.Size(171, 72);
            this.BTNnew.TabIndex = 5;
            this.BTNnew.Text = "New";
            this.BTNnew.UseVisualStyleBackColor = true;
            this.BTNnew.Click += new System.EventHandler(this.BTNnew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNnew);
            this.Controls.Add(this.BTNsave);
            this.Controls.Add(this.BTNopen);
            this.Controls.Add(this.CMBtools);
            this.Controls.Add(this.CMBfile);
            this.Controls.Add(this.RTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB;
        private System.Windows.Forms.ComboBox CMBfile;
        private System.Windows.Forms.ComboBox CMBtools;
        private System.Windows.Forms.Button BTNopen;
        private System.Windows.Forms.Button BTNsave;
        private System.Windows.Forms.Button BTNnew;
    }
}

