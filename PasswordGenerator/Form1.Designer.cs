namespace PasswordGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelNameGenerated = new System.Windows.Forms.Label();
            this.labeName = new System.Windows.Forms.Label();
            this.textBoxUsernamePassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameGenerated
            // 
            this.labelNameGenerated.AutoSize = true;
            this.labelNameGenerated.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameGenerated.Location = new System.Drawing.Point(292, 9);
            this.labelNameGenerated.Name = "labelNameGenerated";
            this.labelNameGenerated.Size = new System.Drawing.Size(239, 14);
            this.labelNameGenerated.TabIndex = 5;
            this.labelNameGenerated.Text = "Genererade namn samt lösenord";
            this.labelNameGenerated.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeName.Location = new System.Drawing.Point(9, 9);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(47, 14);
            this.labeName.TabIndex = 4;
            this.labeName.Text = "Namn:";
            // 
            // textBoxUsernamePassword
            // 
            this.textBoxUsernamePassword.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernamePassword.Location = new System.Drawing.Point(295, 26);
            this.textBoxUsernamePassword.Multiline = true;
            this.textBoxUsernamePassword.Name = "textBoxUsernamePassword";
            this.textBoxUsernamePassword.ReadOnly = true;
            this.textBoxUsernamePassword.Size = new System.Drawing.Size(236, 113);
            this.textBoxUsernamePassword.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(12, 26);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(170, 113);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerate.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerate.Location = new System.Drawing.Point(188, 70);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(101, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generera ➡️";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(545, 152);
            this.Controls.Add(this.labelNameGenerated);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.textBoxUsernamePassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonGenerate);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameGenerated;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.TextBox textBoxUsernamePassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonGenerate;
    }
}

