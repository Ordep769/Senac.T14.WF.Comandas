namespace Comandas
{
    partial class FrmComandaCad
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
            Voltar = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // Voltar
            // 
            Voltar.Alpha = 20;
            Voltar.BackColor = Color.Transparent;
            Voltar.Background = true;
            Voltar.Background_WidthPen = 4F;
            Voltar.BackgroundPen = true;
            Voltar.ColorBackground = Color.FromArgb(37, 52, 68);
            Voltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            Voltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            Voltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            Voltar.ColorLighting = Color.FromArgb(29, 200, 238);
            Voltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            Voltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            Voltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            Voltar.Effect_1 = true;
            Voltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            Voltar.Effect_1_Transparency = 25;
            Voltar.Effect_2 = true;
            Voltar.Effect_2_ColorBackground = Color.White;
            Voltar.Effect_2_Transparency = 20;
            Voltar.Font = new Font("Arial", 11F);
            Voltar.ForeColor = Color.FromArgb(245, 245, 245);
            Voltar.Lighting = false;
            Voltar.LinearGradient_Background = false;
            Voltar.LinearGradientPen = false;
            Voltar.Location = new Point(12, 552);
            Voltar.Name = "Voltar";
            Voltar.PenWidth = 15;
            Voltar.Rounding = true;
            Voltar.RoundingInt = 70;
            Voltar.Size = new Size(195, 75);
            Voltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Voltar.TabIndex = 0;
            Voltar.Tag = "Cyber";
            Voltar.TextButton = "Voltar";
            Voltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            Voltar.Timer_Effect_1 = 5;
            Voltar.Timer_RGB = 300;
            Voltar.Click += Voltar_Click;
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 639);
            Controls.Add(Voltar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "FrmComandaCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComandaCad";
            TransparencyKey = Color.Fuchsia;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton Voltar;
    }
}