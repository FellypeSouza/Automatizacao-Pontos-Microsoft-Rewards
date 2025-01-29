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
            this.SuspendLayout();
            // 
            // startAutomation
            // 
            this.startAutomation.Location = new System.Drawing.Point(10, 45);
            this.startAutomation.Name = "startAutomation";
            this.startAutomation.Size = new System.Drawing.Size(121, 34);
            this.startAutomation.TabIndex = 1;
            this.startAutomation.Text = "Start Automation";
            this.startAutomation.UseVisualStyleBackColor = true;
            this.startAutomation.Click += new System.EventHandler(this.startAutomation_Click);
            // 
            // pauseAutomation
            // 
            this.pauseAutomation.Location = new System.Drawing.Point(168, 45);
            this.pauseAutomation.Name = "pauseAutomation";
            this.pauseAutomation.Size = new System.Drawing.Size(121, 34);
            this.pauseAutomation.TabIndex = 2;
            this.pauseAutomation.Text = "Pause Automation";
            this.pauseAutomation.UseVisualStyleBackColor = true;
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
            this.languageLabel.Location = new System.Drawing.Point(12, 10);
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
            this.comboBox1.Location = new System.Drawing.Point(168, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "English";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AutomationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 93);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pauseAutomation);
            this.Controls.Add(this.startAutomation);
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
    }
}

