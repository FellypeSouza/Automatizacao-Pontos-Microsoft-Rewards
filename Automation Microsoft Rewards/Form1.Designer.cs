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
            this.SuspendLayout();
            // 
            // startAutomation
            // 
            this.startAutomation.Location = new System.Drawing.Point(12, 14);
            this.startAutomation.Name = "startAutomation";
            this.startAutomation.Size = new System.Drawing.Size(121, 34);
            this.startAutomation.TabIndex = 1;
            this.startAutomation.Text = "Start Automation";
            this.startAutomation.UseVisualStyleBackColor = true;
            this.startAutomation.Click += new System.EventHandler(this.startAutomation_Click);
            // 
            // pauseAutomation
            // 
            this.pauseAutomation.Location = new System.Drawing.Point(151, 14);
            this.pauseAutomation.Name = "pauseAutomation";
            this.pauseAutomation.Size = new System.Drawing.Size(121, 34);
            this.pauseAutomation.TabIndex = 2;
            this.pauseAutomation.Text = "Pause Automation";
            this.pauseAutomation.UseVisualStyleBackColor = true;
            this.pauseAutomation.Click += new System.EventHandler(this.pauseAutomation_Click);
            // 
            // AutomationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 60);
            this.Controls.Add(this.pauseAutomation);
            this.Controls.Add(this.startAutomation);
            this.Name = "AutomationScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automation Microsoft Rewards";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startAutomation;
        private System.Windows.Forms.Button pauseAutomation;
    }
}

