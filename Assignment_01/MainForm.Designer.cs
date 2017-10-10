namespace Assignment_01
{
    partial class MainForm
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
            this.btnBuildShip = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSteel = new System.Windows.Forms.CheckBox();
            this.chkNano = new System.Windows.Forms.CheckBox();
            this.chkHoney = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWeightOutput = new System.Windows.Forms.Label();
            this.lblDescriptionOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuildShip
            // 
            this.btnBuildShip.Location = new System.Drawing.Point(257, 427);
            this.btnBuildShip.Name = "btnBuildShip";
            this.btnBuildShip.Size = new System.Drawing.Size(146, 52);
            this.btnBuildShip.TabIndex = 0;
            this.btnBuildShip.Text = "Build Ship";
            this.btnBuildShip.UseVisualStyleBackColor = true;
            this.btnBuildShip.Click += new System.EventHandler(this.btnBuildShip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHoney);
            this.groupBox1.Controls.Add(this.chkNano);
            this.groupBox1.Controls.Add(this.chkSteel);
            this.groupBox1.Location = new System.Drawing.Point(219, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Armour Options:";
            // 
            // chkSteel
            // 
            this.chkSteel.AutoSize = true;
            this.chkSteel.Location = new System.Drawing.Point(27, 40);
            this.chkSteel.Name = "chkSteel";
            this.chkSteel.Size = new System.Drawing.Size(62, 21);
            this.chkSteel.TabIndex = 0;
            this.chkSteel.Text = "Steel";
            this.chkSteel.UseVisualStyleBackColor = true;
            // 
            // chkNano
            // 
            this.chkNano.AutoSize = true;
            this.chkNano.Location = new System.Drawing.Point(27, 99);
            this.chkNano.Name = "chkNano";
            this.chkNano.Size = new System.Drawing.Size(64, 21);
            this.chkNano.TabIndex = 1;
            this.chkNano.Text = "Nano";
            this.chkNano.UseVisualStyleBackColor = true;
            // 
            // chkHoney
            // 
            this.chkHoney.AutoSize = true;
            this.chkHoney.Location = new System.Drawing.Point(27, 161);
            this.chkHoney.Name = "chkHoney";
            this.chkHoney.Size = new System.Drawing.Size(105, 21);
            this.chkHoney.TabIndex = 2;
            this.chkHoney.Text = "Honeycomb";
            this.chkHoney.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Ship Designer 2.0";
            // 
            // lblWeightOutput
            // 
            this.lblWeightOutput.AutoSize = true;
            this.lblWeightOutput.Location = new System.Drawing.Point(219, 316);
            this.lblWeightOutput.Name = "lblWeightOutput";
            this.lblWeightOutput.Size = new System.Drawing.Size(119, 17);
            this.lblWeightOutput.TabIndex = 3;
            this.lblWeightOutput.Text = "Your ship weighs:";
            // 
            // lblDescriptionOutput
            // 
            this.lblDescriptionOutput.AutoSize = true;
            this.lblDescriptionOutput.Location = new System.Drawing.Point(222, 348);
            this.lblDescriptionOutput.Name = "lblDescriptionOutput";
            this.lblDescriptionOutput.Size = new System.Drawing.Size(149, 17);
            this.lblDescriptionOutput.TabIndex = 4;
            this.lblDescriptionOutput.Text = "Your ship description: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 491);
            this.Controls.Add(this.lblDescriptionOutput);
            this.Controls.Add(this.lblWeightOutput);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuildShip);
            this.Name = "Form1";
            this.Text = "Ship Designer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuildShip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkHoney;
        private System.Windows.Forms.CheckBox chkNano;
        private System.Windows.Forms.CheckBox chkSteel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWeightOutput;
        private System.Windows.Forms.Label lblDescriptionOutput;
    }
}

