
namespace FlakGame
{
    partial class MasterForm
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
            this.informationPanel = new System.Windows.Forms.Panel();
            this.flakArea = new System.Windows.Forms.Panel();
            this.warPanel = new System.Windows.Forms.Panel();
            this.informationLabel = new System.Windows.Forms.Label();
            this.informationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.informationPanel.Controls.Add(this.informationLabel);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationPanel.Location = new System.Drawing.Point(0, 0);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(1063, 69);
            this.informationPanel.TabIndex = 0;
            // 
            // flakArea
            // 
            this.flakArea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flakArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flakArea.Location = new System.Drawing.Point(0, 534);
            this.flakArea.Name = "flakArea";
            this.flakArea.Size = new System.Drawing.Size(1063, 50);
            this.flakArea.TabIndex = 1;
            // 
            // warPanel
            // 
            this.warPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.warPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.warPanel.Location = new System.Drawing.Point(0, 69);
            this.warPanel.Name = "warPanel";
            this.warPanel.Size = new System.Drawing.Size(1063, 465);
            this.warPanel.TabIndex = 2;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.informationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.informationLabel.Location = new System.Drawing.Point(288, 9);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(487, 25);
            this.informationLabel.TabIndex = 0;
            this.informationLabel.Text = "Press ENTER for start Game. Press SPACE for fire flak";
            this.informationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 584);
            this.Controls.Add(this.warPanel);
            this.Controls.Add(this.flakArea);
            this.Controls.Add(this.informationPanel);
            this.Name = "MasterForm";
            this.Text = "FlakGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasterForm_KeyDown);
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Panel flakArea;
        private System.Windows.Forms.Panel warPanel;
    }
}

