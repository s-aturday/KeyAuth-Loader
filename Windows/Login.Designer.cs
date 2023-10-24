namespace hyst
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            WindowProp = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            CloseB = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            MinimizeB = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            LoginB = new Guna.UI2.WinForms.Guna2GradientButton();
            keyt = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WindowProp
            // 
            WindowProp.BorderRadius = 9;
            WindowProp.ContainerControl = this;
            WindowProp.DockIndicatorTransparencyValue = 0.6D;
            WindowProp.ResizeForm = false;
            WindowProp.TransparentWhileDrag = true;
            // 
            // CloseB
            // 
            CloseB.Animated = true;
            CloseB.BackColor = Color.Transparent;
            CloseB.CheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            CloseB.CheckedState.BorderThickness = 2;
            CloseB.CheckedState.FillColor = Color.FromArgb(128, 128, 255);
            CloseB.CheckedState.InnerColor = Color.FromArgb(128, 128, 255);
            CloseB.Location = new Point(316, 9);
            CloseB.Name = "CloseB";
            CloseB.ShadowDecoration.BorderRadius = 9;
            CloseB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CloseB.Size = new Size(20, 20);
            CloseB.TabIndex = 0;
            CloseB.Text = "Close";
            CloseB.UncheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            CloseB.UncheckedState.BorderThickness = 2;
            CloseB.UncheckedState.FillColor = Color.FromArgb(128, 128, 255);
            CloseB.UncheckedState.InnerColor = Color.FromArgb(128, 128, 255);
            CloseB.UseTransparentBackground = true;
            CloseB.CheckedChanged += CloseB_Click;
            // 
            // MinimizeB
            // 
            MinimizeB.CheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            MinimizeB.CheckedState.BorderThickness = 2;
            MinimizeB.CheckedState.FillColor = Color.Transparent;
            MinimizeB.CheckedState.InnerColor = Color.Transparent;
            MinimizeB.Location = new Point(288, 9);
            MinimizeB.Name = "MinimizeB";
            MinimizeB.ShadowDecoration.CustomizableEdges = customizableEdges1;
            MinimizeB.Size = new Size(20, 20);
            MinimizeB.TabIndex = 1;
            MinimizeB.Text = "guna2CustomRadioButton2";
            MinimizeB.UncheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            MinimizeB.UncheckedState.BorderThickness = 2;
            MinimizeB.UncheckedState.FillColor = Color.Transparent;
            MinimizeB.UncheckedState.InnerColor = Color.Transparent;
            MinimizeB.CheckedChanged += MinimizeB_CheckedChanged;
            // 
            // LoginB
            // 
            LoginB.BorderRadius = 4;
            LoginB.CustomizableEdges = customizableEdges3;
            LoginB.DisabledState.BorderColor = Color.DarkGray;
            LoginB.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginB.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginB.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            LoginB.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginB.FillColor = Color.FromArgb(128, 128, 255);
            LoginB.FillColor2 = Color.FromArgb(128, 128, 255);
            LoginB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginB.ForeColor = Color.White;
            LoginB.Location = new Point(23, 138);
            LoginB.Name = "LoginB";
            LoginB.ShadowDecoration.CustomizableEdges = customizableEdges4;
            LoginB.Size = new Size(289, 36);
            LoginB.TabIndex = 2;
            LoginB.Text = "Enter";
            LoginB.Click += LoginB_Click;
            // 
            // keyt
            // 
            keyt.BorderColor = Color.FromArgb(20, 20, 20);
            keyt.BorderRadius = 3;
            keyt.CustomizableEdges = customizableEdges5;
            keyt.DefaultText = "";
            keyt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            keyt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            keyt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            keyt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            keyt.FillColor = Color.FromArgb(15, 15, 15);
            keyt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            keyt.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            keyt.ForeColor = Color.White;
            keyt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            keyt.Location = new Point(38, 91);
            keyt.Name = "keyt";
            keyt.PasswordChar = '●';
            keyt.PlaceholderForeColor = Color.White;
            keyt.PlaceholderText = "Key";
            keyt.SelectedText = "";
            keyt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            keyt.Size = new Size(257, 30);
            keyt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 45);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 16, 16);
            panel1.Controls.Add(LoginB);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(keyt);
            panel1.Location = new Point(0, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 249);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 7;
            label2.Text = "Loader";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(342, 261);
            Controls.Add(label2);
            Controls.Add(MinimizeB);
            Controls.Add(CloseB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "hyst";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm WindowProp;
        private Guna.UI2.WinForms.Guna2CustomRadioButton MinimizeB;
        private Guna.UI2.WinForms.Guna2CustomRadioButton CloseB;
        private Guna.UI2.WinForms.Guna2GradientButton LoginB;
        private Guna.UI2.WinForms.Guna2TextBox keyt;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}