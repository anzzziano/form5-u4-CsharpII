namespace formwindow1
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
            titleProfileUser = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            labelApellido = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxApellido = new System.Windows.Forms.TextBox();
            radioButtonMen = new System.Windows.Forms.RadioButton();
            radioButtonWomen = new System.Windows.Forms.RadioButton();
            labelGenero = new System.Windows.Forms.Label();
            buttonViewProfile = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // titleProfileUser
            // 
            titleProfileUser.AutoSize = true;
            titleProfileUser.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            titleProfileUser.Location = new System.Drawing.Point(45, 37);
            titleProfileUser.Name = "titleProfileUser";
            titleProfileUser.Size = new System.Drawing.Size(300, 37);
            titleProfileUser.TabIndex = 0;
            titleProfileUser.Text = "Perfil De Usuario";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            labelName.Location = new System.Drawing.Point(116, 164);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(71, 18);
            labelName.TabIndex = 1;
            labelName.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelApellido.Location = new System.Drawing.Point(109, 211);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new System.Drawing.Size(78, 18);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(220, 160);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(125, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new System.Drawing.Point(220, 206);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new System.Drawing.Size(125, 27);
            textBoxApellido.TabIndex = 4;
            // 
            // radioButtonMen
            // 
            radioButtonMen.AutoSize = true;
            radioButtonMen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            radioButtonMen.Location = new System.Drawing.Point(208, 291);
            radioButtonMen.Name = "radioButtonMen";
            radioButtonMen.Size = new System.Drawing.Size(102, 22);
            radioButtonMen.TabIndex = 5;
            radioButtonMen.TabStop = true;
            radioButtonMen.Text = "Masculino?";
            radioButtonMen.UseVisualStyleBackColor = true;
            radioButtonMen.CheckedChanged += radioButtonMen_CheckedChanged;
            // 
            // radioButtonWomen
            // 
            radioButtonWomen.AutoSize = true;
            radioButtonWomen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioButtonWomen.ForeColor = System.Drawing.SystemColors.ControlText;
            radioButtonWomen.Location = new System.Drawing.Point(339, 291);
            radioButtonWomen.Name = "radioButtonWomen";
            radioButtonWomen.Size = new System.Drawing.Size(106, 24);
            radioButtonWomen.TabIndex = 6;
            radioButtonWomen.TabStop = true;
            radioButtonWomen.Text = "Femenino?";
            radioButtonWomen.UseVisualStyleBackColor = true;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelGenero.Location = new System.Drawing.Point(95, 291);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new System.Drawing.Size(70, 18);
            labelGenero.TabIndex = 7;
            labelGenero.Text = "Genero:";
            // 
            // buttonViewProfile
            // 
            buttonViewProfile.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            buttonViewProfile.Location = new System.Drawing.Point(177, 362);
            buttonViewProfile.Name = "buttonViewProfile";
            buttonViewProfile.Size = new System.Drawing.Size(221, 66);
            buttonViewProfile.TabIndex = 8;
            buttonViewProfile.Text = "Ver Perfil";
            buttonViewProfile.UseVisualStyleBackColor = true;
            buttonViewProfile.Click += buttonViewProfile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(609, 598);
            Controls.Add(buttonViewProfile);
            Controls.Add(labelGenero);
            Controls.Add(radioButtonWomen);
            Controls.Add(radioButtonMen);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxName);
            Controls.Add(labelApellido);
            Controls.Add(labelName);
            Controls.Add(titleProfileUser);
            MaximumSize = new System.Drawing.Size(627, 645);
            MinimumSize = new System.Drawing.Size(627, 645);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleProfileUser;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonWomen;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Button buttonViewProfile;
    }
}
