namespace hyst
{
    partial class Home
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            WindowProp = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            MinimizeB = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            CloseB = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            timer1 = new System.Windows.Forms.Timer(components);
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
            // MinimizeB
            // 
            MinimizeB.CheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            MinimizeB.CheckedState.BorderThickness = 2;
            MinimizeB.CheckedState.FillColor = Color.Transparent;
            MinimizeB.CheckedState.InnerColor = Color.Transparent;
            MinimizeB.Location = new Point(311, 10);
            MinimizeB.Name = "MinimizeB";
            MinimizeB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            MinimizeB.Size = new Size(20, 20);
            MinimizeB.TabIndex = 3;
            MinimizeB.Text = "Minimize";
            MinimizeB.UncheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            MinimizeB.UncheckedState.BorderThickness = 2;
            MinimizeB.UncheckedState.FillColor = Color.Transparent;
            MinimizeB.UncheckedState.InnerColor = Color.Transparent;
            MinimizeB.CheckedChanged += MinimizeB_CheckedChanged;
            // 
            // CloseB
            // 
            CloseB.Animated = true;
            CloseB.BackColor = Color.Transparent;
            CloseB.CheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            CloseB.CheckedState.BorderThickness = 2;
            CloseB.CheckedState.FillColor = Color.FromArgb(128, 128, 255);
            CloseB.CheckedState.InnerColor = Color.FromArgb(128, 128, 255);
            CloseB.Location = new Point(339, 10);
            CloseB.Name = "CloseB";
            CloseB.ShadowDecoration.BorderRadius = 9;
            CloseB.ShadowDecoration.CustomizableEdges = customizableEdges3;
            CloseB.Size = new Size(20, 20);
            CloseB.TabIndex = 2;
            CloseB.Text = "Close";
            CloseB.UncheckedState.BorderColor = Color.FromArgb(128, 128, 255);
            CloseB.UncheckedState.BorderThickness = 2;
            CloseB.UncheckedState.FillColor = Color.FromArgb(128, 128, 255);
            CloseB.UncheckedState.InnerColor = Color.FromArgb(128, 128, 255);
            CloseB.UseTransparentBackground = true;
            CloseB.CheckedChanged += CloseB_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 6;
            label1.Text = "Loader";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 16, 16);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(guna2WinProgressIndicator1);
            panel1.Location = new Point(-7, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 145);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(156, 63);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 9;
            label3.Text = "Injected!";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(97, 102);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 8;
            label2.Text = "Waiting To Open Game";
            label2.Click += label2_Click;
            // 
            // guna2WinProgressIndicator1
            // 
            guna2WinProgressIndicator1.AnimationSpeed = 65;
            guna2WinProgressIndicator1.AutoStart = true;
            guna2WinProgressIndicator1.Location = new Point(156, 19);
            guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            guna2WinProgressIndicator1.ProgressColor = Color.FromArgb(128, 128, 255);
            guna2WinProgressIndicator1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2WinProgressIndicator1.Size = new Size(73, 65);
            guna2WinProgressIndicator1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(371, 185);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(MinimizeB);
            Controls.Add(CloseB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "hyst";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm WindowProp;
        private Guna.UI2.WinForms.Guna2CustomRadioButton MinimizeB;
        private Guna.UI2.WinForms.Guna2CustomRadioButton CloseB;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}