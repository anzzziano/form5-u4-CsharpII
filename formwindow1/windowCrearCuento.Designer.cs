namespace formwindow1
{
    partial class windowCrearCuento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowCrearCuento));
            labelTitleName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            richTextBoxREsumenCuento = new System.Windows.Forms.RichTextBox();
            buttonVerCuento = new System.Windows.Forms.Button();
            textBoxTitleCuento = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // labelTitleName
            // 
            labelTitleName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelTitleName.AutoSize = true;
            labelTitleName.BackColor = System.Drawing.Color.Transparent;
            labelTitleName.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitleName.Location = new System.Drawing.Point(106, 98);
            labelTitleName.Name = "labelTitleName";
            labelTitleName.Size = new System.Drawing.Size(274, 33);
            labelTitleName.TabIndex = 0;
            labelTitleName.Text = "Titulo del libro";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(106, 184);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 24);
            label1.TabIndex = 0;
            label1.Text = "Resumen:";
            // 
            // richTextBoxREsumenCuento
            // 
            richTextBoxREsumenCuento.Location = new System.Drawing.Point(106, 222);
            richTextBoxREsumenCuento.Name = "richTextBoxREsumenCuento";
            richTextBoxREsumenCuento.Size = new System.Drawing.Size(489, 120);
            richTextBoxREsumenCuento.TabIndex = 4;
            richTextBoxREsumenCuento.Text = "";
            // 
            // buttonVerCuento
            // 
            buttonVerCuento.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonVerCuento.Location = new System.Drawing.Point(106, 377);
            buttonVerCuento.Name = "buttonVerCuento";
            buttonVerCuento.Size = new System.Drawing.Size(175, 104);
            buttonVerCuento.TabIndex = 5;
            buttonVerCuento.Text = "Ver Perfil";
            buttonVerCuento.UseVisualStyleBackColor = true;
            buttonVerCuento.Click += buttonVerCuento_Click_1;
            // 
            // textBoxTitleCuento
            // 
            textBoxTitleCuento.Location = new System.Drawing.Point(106, 144);
            textBoxTitleCuento.Name = "textBoxTitleCuento";
            textBoxTitleCuento.Size = new System.Drawing.Size(274, 27);
            textBoxTitleCuento.TabIndex = 6;
            // 
            // windowCrearCuento
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new System.Drawing.Size(783, 629);
            AutoScrollMinSize = new System.Drawing.Size(783, 629);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(765, 582);
            Controls.Add(textBoxTitleCuento);
            Controls.Add(buttonVerCuento);
            Controls.Add(richTextBoxREsumenCuento);
            Controls.Add(label1);
            Controls.Add(labelTitleName);
            MaximumSize = new System.Drawing.Size(783, 629);
            MinimumSize = new System.Drawing.Size(783, 629);
            Name = "windowCrearCuento";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "windowCrearCuento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxREsumenCuento;
        private System.Windows.Forms.Button buttonVerCuento;
        private System.Windows.Forms.TextBox textBoxTitleCuento;
    }
}