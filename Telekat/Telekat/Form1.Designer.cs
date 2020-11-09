namespace ExternalTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStatue = new System.Windows.Forms.Label();
            this.textBoxStatue = new System.Windows.Forms.TextBox();
            this.labelTreasure = new System.Windows.Forms.Label();
            this.textBoxTreasure = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.defaultButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.textBoxLever = new System.Windows.Forms.TextBox();
            this.labelLever = new System.Windows.Forms.Label();
            this.textBoxButton = new System.Windows.Forms.TextBox();
            this.labelButton = new System.Windows.Forms.Label();
            this.textBoxCrate = new System.Windows.Forms.TextBox();
            this.labelCrate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStatue
            // 
            this.labelStatue.AutoSize = true;
            this.labelStatue.Location = new System.Drawing.Point(35, 116);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(57, 20);
            this.labelStatue.TabIndex = 4;
            this.labelStatue.Text = "Statues";
            this.labelStatue.Click += new System.EventHandler(this.labelStatue_Click);
            // 
            // textBoxStatue
            // 
            this.textBoxStatue.Location = new System.Drawing.Point(98, 113);
            this.textBoxStatue.Name = "textBoxStatue";
            this.textBoxStatue.Size = new System.Drawing.Size(125, 27);
            this.textBoxStatue.TabIndex = 3;
            this.textBoxStatue.Text = "0";
            this.textBoxStatue.TextChanged += new System.EventHandler(this.textBoxStatue_TextChanged);
            // 
            // labelTreasure
            // 
            this.labelTreasure.AutoSize = true;
            this.labelTreasure.Location = new System.Drawing.Point(28, 83);
            this.labelTreasure.Name = "labelTreasure";
            this.labelTreasure.Size = new System.Drawing.Size(64, 20);
            this.labelTreasure.TabIndex = 2;
            this.labelTreasure.Text = "Treasure";
            this.labelTreasure.Click += new System.EventHandler(this.labelTreasure_Click);
            // 
            // textBoxTreasure
            // 
            this.textBoxTreasure.Location = new System.Drawing.Point(98, 80);
            this.textBoxTreasure.Name = "textBoxTreasure";
            this.textBoxTreasure.Size = new System.Drawing.Size(125, 27);
            this.textBoxTreasure.TabIndex = 2;
            this.textBoxTreasure.Text = "0";
            this.textBoxTreasure.TextChanged += new System.EventHandler(this.textBoxTreasure_TextChanged);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(53, 50);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(39, 20);
            this.labelKey.TabIndex = 1;
            this.labelKey.Text = "Keys";
            this.labelKey.Click += new System.EventHandler(this.labelKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(98, 47);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(125, 27);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.Text = "0";
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // defaultButton
            // 
            this.defaultButton.Location = new System.Drawing.Point(406, 293);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(94, 29);
            this.defaultButton.TabIndex = 1;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(294, 293);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(94, 29);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // textBoxLever
            // 
            this.textBoxLever.Location = new System.Drawing.Point(98, 146);
            this.textBoxLever.Name = "textBoxLever";
            this.textBoxLever.Size = new System.Drawing.Size(125, 27);
            this.textBoxLever.TabIndex = 5;
            this.textBoxLever.Text = "0";
            this.textBoxLever.TextChanged += new System.EventHandler(this.textBoxLever_TextChanged);
            // 
            // labelLever
            // 
            this.labelLever.AutoSize = true;
            this.labelLever.Location = new System.Drawing.Point(42, 149);
            this.labelLever.Name = "labelLever";
            this.labelLever.Size = new System.Drawing.Size(50, 20);
            this.labelLever.TabIndex = 6;
            this.labelLever.Text = "Levers";
            this.labelLever.Click += new System.EventHandler(this.labelLever_Click);
            // 
            // textBoxButton
            // 
            this.textBoxButton.Location = new System.Drawing.Point(98, 179);
            this.textBoxButton.Name = "textBoxButton";
            this.textBoxButton.Size = new System.Drawing.Size(125, 27);
            this.textBoxButton.TabIndex = 7;
            this.textBoxButton.Text = "0";
            this.textBoxButton.TextChanged += new System.EventHandler(this.textBoxButton_TextChanged);
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Location = new System.Drawing.Point(33, 182);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(59, 20);
            this.labelButton.TabIndex = 8;
            this.labelButton.Text = "Buttons";
            this.labelButton.Click += new System.EventHandler(this.labelButton_Click);
            // 
            // textBoxCrate
            // 
            this.textBoxCrate.Location = new System.Drawing.Point(98, 212);
            this.textBoxCrate.Name = "textBoxCrate";
            this.textBoxCrate.Size = new System.Drawing.Size(125, 27);
            this.textBoxCrate.TabIndex = 9;
            this.textBoxCrate.Text = "0";
            this.textBoxCrate.TextChanged += new System.EventHandler(this.textBoxCrate_TextChanged);
            // 
            // labelCrate
            // 
            this.labelCrate.AutoSize = true;
            this.labelCrate.Location = new System.Drawing.Point(42, 215);
            this.labelCrate.Name = "labelCrate";
            this.labelCrate.Size = new System.Drawing.Size(50, 20);
            this.labelCrate.TabIndex = 10;
            this.labelCrate.Text = "Crates";
            this.labelCrate.Click += new System.EventHandler(this.labelCrate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 334);
            this.Controls.Add(this.labelCrate);
            this.Controls.Add(this.textBoxCrate);
            this.Controls.Add(this.labelButton);
            this.Controls.Add(this.textBoxButton);
            this.Controls.Add(this.labelLever);
            this.Controls.Add(this.textBoxLever);
            this.Controls.Add(this.labelStatue);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.textBoxStatue);
            this.Controls.Add(this.labelTreasure);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.textBoxTreasure);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label labelTreasure;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxTreasure;
        private System.Windows.Forms.Label labelStatue;
        private System.Windows.Forms.TextBox textBoxStatue;
        private System.Windows.Forms.TextBox textBoxLever;
        private System.Windows.Forms.Label labelLever;
        private System.Windows.Forms.TextBox textBoxButton;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.TextBox textBoxCrate;
        private System.Windows.Forms.Label labelCrate;
    }
}

