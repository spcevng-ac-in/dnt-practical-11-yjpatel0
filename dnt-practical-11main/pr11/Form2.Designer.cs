namespace DemoNotepad
{
    partial class replaceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.replacebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.findtextBox = new System.Windows.Forms.TextBox();
            this.replacetextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace";
            // 
            // replacebutton
            // 
            this.replacebutton.Location = new System.Drawing.Point(39, 117);
            this.replacebutton.Name = "replacebutton";
            this.replacebutton.Size = new System.Drawing.Size(75, 23);
            this.replacebutton.TabIndex = 4;
            this.replacebutton.Text = "Replace";
            this.replacebutton.UseVisualStyleBackColor = true;
            this.replacebutton.Click += new System.EventHandler(this.replacebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(142, 117);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // findtextBox
            // 
            this.findtextBox.Location = new System.Drawing.Point(100, 27);
            this.findtextBox.Name = "findtextBox";
            this.findtextBox.Size = new System.Drawing.Size(100, 20);
            this.findtextBox.TabIndex = 6;
            // 
            // replacetextBox
            // 
            this.replacetextBox.Location = new System.Drawing.Point(100, 75);
            this.replacetextBox.Name = "replacetextBox";
            this.replacetextBox.Size = new System.Drawing.Size(100, 20);
            this.replacetextBox.TabIndex = 7;
            // 
            // replaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 174);
            this.Controls.Add(this.replacetextBox);
            this.Controls.Add(this.findtextBox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.replacebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "replaceForm";
            this.Text = "Find & Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button replacebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.TextBox findtextBox;
        private System.Windows.Forms.TextBox replacetextBox;
    }
}