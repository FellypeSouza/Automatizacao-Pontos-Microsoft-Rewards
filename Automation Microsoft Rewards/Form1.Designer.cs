namespace Automation_Microsoft_Rewards
{
    partial class AutomationScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.startAutomation = new System.Windows.Forms.Button();
            this.pauseAutomation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.restart = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startAutomation
            // 
            this.startAutomation.BackColor = System.Drawing.SystemColors.Control;
            this.startAutomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAutomation.Location = new System.Drawing.Point(13, 11);
            this.startAutomation.Name = "startAutomation";
            this.startAutomation.Size = new System.Drawing.Size(121, 34);
            this.startAutomation.TabIndex = 1;
            this.startAutomation.Text = "Start Automation";
            this.startAutomation.UseVisualStyleBackColor = false;
            this.startAutomation.Click += new System.EventHandler(this.startAutomation_Click);
            // 
            // pauseAutomation
            // 
            this.pauseAutomation.BackColor = System.Drawing.SystemColors.Control;
            this.pauseAutomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseAutomation.Location = new System.Drawing.Point(140, 12);
            this.pauseAutomation.Name = "pauseAutomation";
            this.pauseAutomation.Size = new System.Drawing.Size(121, 34);
            this.pauseAutomation.TabIndex = 2;
            this.pauseAutomation.Text = "Pause Automation";
            this.pauseAutomation.UseVisualStyleBackColor = false;
            this.pauseAutomation.Click += new System.EventHandler(this.pauseAutomation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageLabel.Location = new System.Drawing.Point(10, 78);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(146, 17);
            this.languageLabel.TabIndex = 4;
            this.languageLabel.Text = "Select your language:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Português PT-BR"});
            this.comboBox1.Location = new System.Drawing.Point(163, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "English";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.SystemColors.Control;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(267, 12);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(121, 34);
            this.restart.TabIndex = 6;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(313, 72);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 23);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // AutomationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(400, 111);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseAutomation);
            this.Controls.Add(this.startAutomation);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AutomationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automation Microsoft Rewards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startAutomation;
        private System.Windows.Forms.Button pauseAutomation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button helpButton;
    }
}

