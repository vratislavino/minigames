namespace Minigames
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.char1UI = new Minigames.CharacterGameUI();
            this.char2UI = new Minigames.CharacterGameUI();
            this.minigamePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // char1UI
            // 
            this.char1UI.Character = null;
            this.char1UI.Location = new System.Drawing.Point(12, 12);
            this.char1UI.Name = "char1UI";
            this.char1UI.Size = new System.Drawing.Size(182, 270);
            this.char1UI.TabIndex = 0;
            // 
            // char2UI
            // 
            this.char2UI.Character = null;
            this.char2UI.Location = new System.Drawing.Point(806, 12);
            this.char2UI.Name = "char2UI";
            this.char2UI.Size = new System.Drawing.Size(182, 270);
            this.char2UI.TabIndex = 1;
            // 
            // minigamePanel
            // 
            this.minigamePanel.BackColor = System.Drawing.Color.White;
            this.minigamePanel.Location = new System.Drawing.Point(200, 12);
            this.minigamePanel.Name = "minigamePanel";
            this.minigamePanel.Size = new System.Drawing.Size(600, 600);
            this.minigamePanel.TabIndex = 2;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 629);
            this.Controls.Add(this.minigamePanel);
            this.Controls.Add(this.char2UI);
            this.Controls.Add(this.char1UI);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Shown += new System.EventHandler(this.GameForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private CharacterGameUI char1UI;
        private CharacterGameUI char2UI;
        private System.Windows.Forms.Panel minigamePanel;
    }
}