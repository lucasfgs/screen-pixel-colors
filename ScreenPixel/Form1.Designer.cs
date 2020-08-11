namespace ScreenPixel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mousePos = new System.Windows.Forms.Label();
            this.topLeftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.resolutionTxt = new System.Windows.Forms.Label();
            this.topRightPanel = new System.Windows.Forms.Panel();
            this.botLeftPanel = new System.Windows.Forms.Panel();
            this.botRightPanel = new System.Windows.Forms.Panel();
            this.txtResolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mousePos
            // 
            this.mousePos.AutoSize = true;
            this.mousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mousePos.Location = new System.Drawing.Point(102, 9);
            this.mousePos.Name = "mousePos";
            this.mousePos.Size = new System.Drawing.Size(0, 25);
            this.mousePos.TabIndex = 0;
            // 
            // topLeftPanel
            // 
            this.topLeftPanel.Location = new System.Drawing.Point(0, 60);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(275, 151);
            this.topLeftPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position:";
            // 
            // resolutionTxt
            // 
            this.resolutionTxt.Location = new System.Drawing.Point(0, 0);
            this.resolutionTxt.Name = "resolutionTxt";
            this.resolutionTxt.Size = new System.Drawing.Size(100, 23);
            this.resolutionTxt.TabIndex = 0;
            // 
            // topRightPanel
            // 
            this.topRightPanel.Location = new System.Drawing.Point(281, 60);
            this.topRightPanel.Name = "topRightPanel";
            this.topRightPanel.Size = new System.Drawing.Size(275, 151);
            this.topRightPanel.TabIndex = 2;
            // 
            // botLeftPanel
            // 
            this.botLeftPanel.Location = new System.Drawing.Point(0, 217);
            this.botLeftPanel.Name = "botLeftPanel";
            this.botLeftPanel.Size = new System.Drawing.Size(275, 151);
            this.botLeftPanel.TabIndex = 2;
            // 
            // botRightPanel
            // 
            this.botRightPanel.Location = new System.Drawing.Point(281, 217);
            this.botRightPanel.Name = "botRightPanel";
            this.botRightPanel.Size = new System.Drawing.Size(275, 151);
            this.botRightPanel.TabIndex = 3;
            // 
            // txtResolution
            // 
            this.txtResolution.AutoSize = true;
            this.txtResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResolution.Location = new System.Drawing.Point(303, 9);
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(0, 25);
            this.txtResolution.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 372);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.botRightPanel);
            this.Controls.Add(this.botLeftPanel);
            this.Controls.Add(this.topRightPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topLeftPanel);
            this.Controls.Add(this.mousePos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label mousePos;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topRightPanel;
        private System.Windows.Forms.Panel botLeftPanel;
        private System.Windows.Forms.Panel botRightPanel;
        private System.Windows.Forms.Label resolutionTxt;
        private System.Windows.Forms.Label txtResolution;
    }
}

