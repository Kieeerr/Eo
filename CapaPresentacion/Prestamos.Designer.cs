namespace CapaPresentacion
{
    partial class Morosos
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            txtSueldo = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(0, 0);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 16;
            guna2HtmlLabel1.Text = null;
            // 
            // guna2Button3
            // 
            guna2Button3.BorderRadius = 10;
            guna2Button3.CustomizableEdges = customizableEdges5;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.Orange;
            guna2Button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button3.ForeColor = Color.Black;
            guna2Button3.Location = new Point(648, 116);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button3.Size = new Size(140, 50);
            guna2Button3.TabIndex = 13;
            guna2Button3.Text = "Generar";
            // 
            // txtSueldo
            // 
            txtSueldo.BorderColor = Color.Black;
            txtSueldo.CustomizableEdges = customizableEdges3;
            txtSueldo.DefaultText = "";
            txtSueldo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSueldo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSueldo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSueldo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSueldo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSueldo.Font = new Font("Segoe UI", 9F);
            txtSueldo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSueldo.Location = new Point(73, 186);
            txtSueldo.Margin = new Padding(3, 4, 3, 4);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.PasswordChar = '\0';
            txtSueldo.PlaceholderText = "";
            txtSueldo.SelectedText = "";
            txtSueldo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSueldo.Size = new Size(229, 32);
            txtSueldo.TabIndex = 25;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(32, 12);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(148, 43);
            guna2HtmlLabel2.TabIndex = 26;
            guna2HtmlLabel2.Text = "Prestamos";
            // 
            // Morosos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 76, 116);
            ClientSize = new Size(800, 450);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtSueldo);
            Controls.Add(guna2Button3);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Morosos";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSueldo;
    }
}