namespace ADS_ED1I4_20230918
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
            gerarBtn = new Button();
            listarSenhasBtn = new Button();
            adicionarButton = new Button();
            chamarBtn = new Button();
            listarAtendimentoBtn = new Button();
            qntdGuicheLabel = new Label();
            guicheCounterLabel = new Label();
            guicheLabel = new Label();
            guicheNumberTxtBox = new TextBox();
            senhasListBox = new ListBox();
            atendimentosListBox = new ListBox();
            SuspendLayout();
            // 
            // gerarBtn
            // 
            gerarBtn.Location = new Point(85, 25);
            gerarBtn.Name = "gerarBtn";
            gerarBtn.Size = new Size(75, 23);
            gerarBtn.TabIndex = 0;
            gerarBtn.Text = "Gerar";
            gerarBtn.UseVisualStyleBackColor = true;
            gerarBtn.Click += gerarBtn_Click;
            // 
            // listarSenhasBtn
            // 
            listarSenhasBtn.Location = new Point(12, 396);
            listarSenhasBtn.Name = "listarSenhasBtn";
            listarSenhasBtn.Size = new Size(220, 23);
            listarSenhasBtn.TabIndex = 1;
            listarSenhasBtn.Text = "Listar senhas";
            listarSenhasBtn.UseVisualStyleBackColor = true;
            listarSenhasBtn.Click += listarSenhasBtn_Click;
            // 
            // adicionarButton
            // 
            adicionarButton.Location = new Point(282, 307);
            adicionarButton.Name = "adicionarButton";
            adicionarButton.Size = new Size(75, 23);
            adicionarButton.TabIndex = 2;
            adicionarButton.Text = "Adicionar";
            adicionarButton.UseVisualStyleBackColor = true;
            adicionarButton.Click += adicionarButton_Click;
            // 
            // chamarBtn
            // 
            chamarBtn.Location = new Point(623, 25);
            chamarBtn.Name = "chamarBtn";
            chamarBtn.Size = new Size(75, 23);
            chamarBtn.TabIndex = 3;
            chamarBtn.Text = "Chamar";
            chamarBtn.UseVisualStyleBackColor = true;
            chamarBtn.Click += chamarBtn_Click;
            // 
            // listarAtendimentoBtn
            // 
            listarAtendimentoBtn.Location = new Point(396, 396);
            listarAtendimentoBtn.Name = "listarAtendimentoBtn";
            listarAtendimentoBtn.Size = new Size(392, 23);
            listarAtendimentoBtn.TabIndex = 4;
            listarAtendimentoBtn.Text = "Listar atendimentos";
            listarAtendimentoBtn.UseVisualStyleBackColor = true;
            listarAtendimentoBtn.Click += listarAtendimentoBtn_Click;
            // 
            // qntdGuicheLabel
            // 
            qntdGuicheLabel.AutoSize = true;
            qntdGuicheLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            qntdGuicheLabel.Location = new Point(249, 146);
            qntdGuicheLabel.Name = "qntdGuicheLabel";
            qntdGuicheLabel.Size = new Size(141, 30);
            qntdGuicheLabel.TabIndex = 5;
            qntdGuicheLabel.Text = "Qntd guichês";
            // 
            // guicheCounterLabel
            // 
            guicheCounterLabel.AutoSize = true;
            guicheCounterLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            guicheCounterLabel.Location = new Point(301, 209);
            guicheCounterLabel.Name = "guicheCounterLabel";
            guicheCounterLabel.Size = new Size(37, 45);
            guicheCounterLabel.TabIndex = 6;
            guicheCounterLabel.Text = "0";
            // 
            // guicheLabel
            // 
            guicheLabel.AutoSize = true;
            guicheLabel.Location = new Point(484, 29);
            guicheLabel.Name = "guicheLabel";
            guicheLabel.Size = new Size(44, 15);
            guicheLabel.TabIndex = 7;
            guicheLabel.Text = "Guichê";
            // 
            // guicheNumberTxtBox
            // 
            guicheNumberTxtBox.Location = new Point(534, 25);
            guicheNumberTxtBox.Name = "guicheNumberTxtBox";
            guicheNumberTxtBox.Size = new Size(63, 23);
            guicheNumberTxtBox.TabIndex = 8;
            // 
            // senhasListBox
            // 
            senhasListBox.FormattingEnabled = true;
            senhasListBox.ItemHeight = 15;
            senhasListBox.Location = new Point(12, 69);
            senhasListBox.Name = "senhasListBox";
            senhasListBox.Size = new Size(220, 304);
            senhasListBox.TabIndex = 9;
            // 
            // atendimentosListBox
            // 
            atendimentosListBox.FormattingEnabled = true;
            atendimentosListBox.ItemHeight = 15;
            atendimentosListBox.Location = new Point(396, 69);
            atendimentosListBox.Name = "atendimentosListBox";
            atendimentosListBox.Size = new Size(392, 304);
            atendimentosListBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(atendimentosListBox);
            Controls.Add(senhasListBox);
            Controls.Add(guicheNumberTxtBox);
            Controls.Add(guicheLabel);
            Controls.Add(guicheCounterLabel);
            Controls.Add(qntdGuicheLabel);
            Controls.Add(listarAtendimentoBtn);
            Controls.Add(chamarBtn);
            Controls.Add(adicionarButton);
            Controls.Add(listarSenhasBtn);
            Controls.Add(gerarBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gerarBtn;
        private Button listarSenhasBtn;
        private Button adicionarButton;
        private Button chamarBtn;
        private Button listarAtendimentoBtn;
        private Label qntdGuicheLabel;
        private Label guicheCounterLabel;
        private Label guicheLabel;
        private TextBox guicheNumberTxtBox;
        private ListBox senhasListBox;
        private ListBox atendimentosListBox;
    }
}