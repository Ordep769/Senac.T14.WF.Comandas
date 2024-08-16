namespace Comandas
{
    partial class frmUsuarios
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
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            btnSalvar = new ReaLTaiizor.Controls.CyberButton();
            btnNovo = new ReaLTaiizor.Controls.CyberButton();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            btnCancelar = new ReaLTaiizor.Controls.CyberButton();
            cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            txtSenha = new ReaLTaiizor.Controls.CyberTextBox();
            txtEmail = new ReaLTaiizor.Controls.CyberTextBox();
            txtNome = new ReaLTaiizor.Controls.CyberTextBox();
            txtId = new ReaLTaiizor.Controls.CyberTextBox();
            thunderLabel4 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel3 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel2 = new ReaLTaiizor.Controls.ThunderLabel();
            thunderLabel1 = new ReaLTaiizor.Controls.ThunderLabel();
            dgvUsuarios = new DataGridView();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            cyberGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(12, 645);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(195, 75);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 0;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Alpha = 20;
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Background = true;
            btnSalvar.Background_WidthPen = 4F;
            btnSalvar.BackgroundPen = true;
            btnSalvar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSalvar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSalvar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSalvar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSalvar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSalvar.Effect_1 = true;
            btnSalvar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSalvar.Effect_1_Transparency = 25;
            btnSalvar.Effect_2 = true;
            btnSalvar.Effect_2_ColorBackground = Color.White;
            btnSalvar.Effect_2_Transparency = 20;
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Arial", 11F);
            btnSalvar.ForeColor = Color.FromArgb(245, 245, 245);
            btnSalvar.Lighting = false;
            btnSalvar.LinearGradient_Background = false;
            btnSalvar.LinearGradientPen = false;
            btnSalvar.Location = new Point(190, 402);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PenWidth = 15;
            btnSalvar.Rounding = true;
            btnSalvar.RoundingInt = 70;
            btnSalvar.Size = new Size(195, 75);
            btnSalvar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSalvar.TabIndex = 1;
            btnSalvar.Tag = "Cyber";
            btnSalvar.TextButton = "Salvar";
            btnSalvar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSalvar.Timer_Effect_1 = 5;
            btnSalvar.Timer_RGB = 300;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Alpha = 20;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Background = true;
            btnNovo.Background_WidthPen = 4F;
            btnNovo.BackgroundPen = true;
            btnNovo.ColorBackground = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnNovo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnNovo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNovo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovo.Effect_1 = true;
            btnNovo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNovo.Effect_1_Transparency = 25;
            btnNovo.Effect_2 = true;
            btnNovo.Effect_2_ColorBackground = Color.White;
            btnNovo.Effect_2_Transparency = 20;
            btnNovo.Font = new Font("Arial", 11F);
            btnNovo.ForeColor = Color.FromArgb(245, 245, 245);
            btnNovo.Lighting = false;
            btnNovo.LinearGradient_Background = false;
            btnNovo.LinearGradientPen = false;
            btnNovo.Location = new Point(-1, 402);
            btnNovo.Name = "btnNovo";
            btnNovo.PenWidth = 15;
            btnNovo.Rounding = true;
            btnNovo.RoundingInt = 70;
            btnNovo.Size = new Size(195, 75);
            btnNovo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovo.TabIndex = 2;
            btnNovo.Tag = "Cyber";
            btnNovo.TextButton = "Novo";
            btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovo.Timer_Effect_1 = 5;
            btnNovo.Timer_RGB = 300;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(382, 402);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(195, 75);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 3;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Alpha = 20;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Background = true;
            btnCancelar.Background_WidthPen = 4F;
            btnCancelar.BackgroundPen = true;
            btnCancelar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCancelar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCancelar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCancelar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancelar.Effect_1 = true;
            btnCancelar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCancelar.Effect_1_Transparency = 25;
            btnCancelar.Effect_2 = true;
            btnCancelar.Effect_2_ColorBackground = Color.White;
            btnCancelar.Effect_2_Transparency = 20;
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Arial", 11F);
            btnCancelar.ForeColor = Color.FromArgb(245, 245, 245);
            btnCancelar.Lighting = false;
            btnCancelar.LinearGradient_Background = false;
            btnCancelar.LinearGradientPen = false;
            btnCancelar.Location = new Point(759, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PenWidth = 15;
            btnCancelar.Rounding = true;
            btnCancelar.RoundingInt = 70;
            btnCancelar.Size = new Size(195, 75);
            btnCancelar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancelar.TabIndex = 4;
            btnCancelar.Tag = "Cyber";
            btnCancelar.TextButton = "Cancelar";
            btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancelar.Timer_Effect_1 = 5;
            btnCancelar.Timer_RGB = 300;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cyberGroupBox1
            // 
            cyberGroupBox1.Alpha = 20;
            cyberGroupBox1.BackColor = Color.Transparent;
            cyberGroupBox1.Background = true;
            cyberGroupBox1.Background_WidthPen = 3F;
            cyberGroupBox1.BackgroundPen = true;
            cyberGroupBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberGroupBox1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberGroupBox1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberGroupBox1.Controls.Add(txtSenha);
            cyberGroupBox1.Controls.Add(txtEmail);
            cyberGroupBox1.Controls.Add(txtNome);
            cyberGroupBox1.Controls.Add(txtId);
            cyberGroupBox1.Controls.Add(thunderLabel4);
            cyberGroupBox1.Controls.Add(thunderLabel3);
            cyberGroupBox1.Controls.Add(thunderLabel2);
            cyberGroupBox1.Controls.Add(thunderLabel1);
            cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberGroupBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberGroupBox1.Lighting = false;
            cyberGroupBox1.LinearGradient_Background = false;
            cyberGroupBox1.LinearGradientPen = false;
            cyberGroupBox1.Location = new Point(48, 12);
            cyberGroupBox1.Name = "cyberGroupBox1";
            cyberGroupBox1.PenWidth = 15;
            cyberGroupBox1.RGB = false;
            cyberGroupBox1.Rounding = true;
            cyberGroupBox1.RoundingInt = 60;
            cyberGroupBox1.Size = new Size(829, 384);
            cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberGroupBox1.TabIndex = 5;
            cyberGroupBox1.Tag = "Cyber";
            cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberGroupBox1.Timer_RGB = 300;
            // 
            // txtSenha
            // 
            txtSenha.Alpha = 20;
            txtSenha.BackColor = Color.Transparent;
            txtSenha.Background_WidthPen = 3F;
            txtSenha.BackgroundPen = true;
            txtSenha.ColorBackground = Color.FromArgb(37, 52, 68);
            txtSenha.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtSenha.ColorLighting = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtSenha.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtSenha.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtSenha.Font = new Font("Arial", 15F);
            txtSenha.ForeColor = Color.FromArgb(245, 245, 245);
            txtSenha.Lighting = false;
            txtSenha.LinearGradientPen = false;
            txtSenha.Location = new Point(180, 245);
            txtSenha.Name = "txtSenha";
            txtSenha.PenWidth = 15;
            txtSenha.RGB = false;
            txtSenha.Rounding = true;
            txtSenha.RoundingInt = 60;
            txtSenha.Size = new Size(300, 60);
            txtSenha.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtSenha.TabIndex = 12;
            txtSenha.Tag = "Cyber";
            txtSenha.TextButton = "";
            txtSenha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtSenha.Timer_RGB = 300;
            // 
            // txtEmail
            // 
            txtEmail.Alpha = 20;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Background_WidthPen = 3F;
            txtEmail.BackgroundPen = true;
            txtEmail.ColorBackground = Color.FromArgb(37, 52, 68);
            txtEmail.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtEmail.ColorLighting = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtEmail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtEmail.Font = new Font("Arial", 15F);
            txtEmail.ForeColor = Color.FromArgb(245, 245, 245);
            txtEmail.Lighting = false;
            txtEmail.LinearGradientPen = false;
            txtEmail.Location = new Point(180, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.PenWidth = 15;
            txtEmail.RGB = false;
            txtEmail.Rounding = true;
            txtEmail.RoundingInt = 60;
            txtEmail.Size = new Size(300, 60);
            txtEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtEmail.TabIndex = 11;
            txtEmail.Tag = "Cyber";
            txtEmail.TextButton = "";
            txtEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtEmail.Timer_RGB = 300;
            // 
            // txtNome
            // 
            txtNome.Alpha = 20;
            txtNome.BackColor = Color.Transparent;
            txtNome.Background_WidthPen = 3F;
            txtNome.BackgroundPen = true;
            txtNome.ColorBackground = Color.FromArgb(37, 52, 68);
            txtNome.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtNome.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNome.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNome.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNome.Font = new Font("Arial", 15F);
            txtNome.ForeColor = Color.FromArgb(245, 245, 245);
            txtNome.Lighting = false;
            txtNome.LinearGradientPen = false;
            txtNome.Location = new Point(180, 89);
            txtNome.Name = "txtNome";
            txtNome.PenWidth = 15;
            txtNome.RGB = false;
            txtNome.Rounding = true;
            txtNome.RoundingInt = 60;
            txtNome.Size = new Size(300, 60);
            txtNome.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNome.TabIndex = 10;
            txtNome.Tag = "Cyber";
            txtNome.TextButton = "";
            txtNome.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNome.Timer_RGB = 300;
            // 
            // txtId
            // 
            txtId.Alpha = 20;
            txtId.BackColor = Color.Transparent;
            txtId.Background_WidthPen = 3F;
            txtId.BackgroundPen = true;
            txtId.ColorBackground = Color.FromArgb(37, 52, 68);
            txtId.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtId.ColorLighting = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtId.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtId.Font = new Font("Arial", 15F);
            txtId.ForeColor = Color.FromArgb(245, 245, 245);
            txtId.Lighting = false;
            txtId.LinearGradientPen = false;
            txtId.Location = new Point(180, 23);
            txtId.Name = "txtId";
            txtId.PenWidth = 15;
            txtId.RGB = false;
            txtId.Rounding = true;
            txtId.RoundingInt = 60;
            txtId.Size = new Size(300, 60);
            txtId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtId.TabIndex = 9;
            txtId.Tag = "Cyber";
            txtId.TextButton = "";
            txtId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtId.Timer_RGB = 300;
            // 
            // thunderLabel4
            // 
            thunderLabel4.BackColor = Color.Transparent;
            thunderLabel4.ForeColor = Color.WhiteSmoke;
            thunderLabel4.Location = new Point(44, 266);
            thunderLabel4.Name = "thunderLabel4";
            thunderLabel4.Size = new Size(144, 24);
            thunderLabel4.TabIndex = 8;
            thunderLabel4.Text = "Senha:";
            // 
            // thunderLabel3
            // 
            thunderLabel3.BackColor = Color.Transparent;
            thunderLabel3.ForeColor = Color.WhiteSmoke;
            thunderLabel3.Location = new Point(44, 180);
            thunderLabel3.Name = "thunderLabel3";
            thunderLabel3.Size = new Size(144, 24);
            thunderLabel3.TabIndex = 7;
            thunderLabel3.Text = "Email:";
            // 
            // thunderLabel2
            // 
            thunderLabel2.BackColor = Color.Transparent;
            thunderLabel2.ForeColor = Color.WhiteSmoke;
            thunderLabel2.Location = new Point(44, 107);
            thunderLabel2.Name = "thunderLabel2";
            thunderLabel2.Size = new Size(144, 24);
            thunderLabel2.TabIndex = 6;
            thunderLabel2.Text = "Nome:";
            // 
            // thunderLabel1
            // 
            thunderLabel1.BackColor = Color.Transparent;
            thunderLabel1.ForeColor = Color.WhiteSmoke;
            thunderLabel1.Location = new Point(44, 44);
            thunderLabel1.Name = "thunderLabel1";
            thunderLabel1.Size = new Size(144, 24);
            thunderLabel1.TabIndex = 5;
            thunderLabel1.Text = "Id:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(48, 494);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(906, 125);
            dgvUsuarios.TabIndex = 6;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background = true;
            btnEditar.Background_WidthPen = 4F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEditar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Effect_1 = true;
            btnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEditar.Effect_1_Transparency = 25;
            btnEditar.Effect_2 = true;
            btnEditar.Effect_2_ColorBackground = Color.White;
            btnEditar.Effect_2_Transparency = 20;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            btnEditar.Lighting = false;
            btnEditar.LinearGradient_Background = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(574, 402);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(195, 75);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 8;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 744);
            Controls.Add(btnEditar);
            Controls.Add(dgvUsuarios);
            Controls.Add(cyberGroupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            cyberGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnVoltar;
        private ReaLTaiizor.Controls.CyberButton btnSalvar;
        private ReaLTaiizor.Controls.CyberButton btnNovo;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private ReaLTaiizor.Controls.CyberButton btnCancelar;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
        private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
        private DataGridView dgvUsuarios;
        private ReaLTaiizor.Controls.CyberButton btnEditar;
        private ReaLTaiizor.Controls.CyberTextBox txtSenha;
        private ReaLTaiizor.Controls.CyberTextBox txtEmail;
        private ReaLTaiizor.Controls.CyberTextBox txtNome;
        private ReaLTaiizor.Controls.CyberTextBox txtId;
    }
}