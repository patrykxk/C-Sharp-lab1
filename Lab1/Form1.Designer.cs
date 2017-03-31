namespace Lab1
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
            this.button1 = new System.Windows.Forms.Button();
            this.classList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.objectComboBox = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add);
            // 
            // classList
            // 
            this.classList.FormattingEnabled = true;
            this.classList.Items.AddRange(new object[] {
            "Car",
            "Plane",
            "Submarine",
            "Computer"});
            this.classList.Location = new System.Drawing.Point(12, 12);
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(204, 21);
            this.classList.TabIndex = 3;
            this.classList.Text = "Choose type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // objectComboBox
            // 
            this.objectComboBox.FormattingEnabled = true;
            this.objectComboBox.Location = new System.Drawing.Point(12, 63);
            this.objectComboBox.Name = "objectComboBox";
            this.objectComboBox.Size = new System.Drawing.Size(270, 21);
            this.objectComboBox.TabIndex = 5;
            this.objectComboBox.Text = "Choose object";
            this.objectComboBox.SelectedIndexChanged += new System.EventHandler(this.objectList_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(158, 124);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(124, 126);
            this.panel.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(20, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 126);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 265);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.objectComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classList);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox objectComboBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox classList;
    }
}

