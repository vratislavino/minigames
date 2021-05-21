namespace Minigames
{
    partial class CharSelectForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.characterUI1 = new CharacterUI();
            this.characterUI2 = new CharacterUI();
            this.fightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 362);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(874, 146);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(419, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "VS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characterUI1
            // 
            this.characterUI1.Character = null;
            this.characterUI1.Location = new System.Drawing.Point(9, 10);
            this.characterUI1.Name = "characterUI1";
            this.characterUI1.Size = new System.Drawing.Size(401, 347);
            this.characterUI1.TabIndex = 4;
            // 
            // characterUI2
            // 
            this.characterUI2.Character = null;
            this.characterUI2.Location = new System.Drawing.Point(482, 10);
            this.characterUI2.Name = "characterUI2";
            this.characterUI2.Size = new System.Drawing.Size(401, 347);
            this.characterUI2.TabIndex = 5;
            // 
            // fightButton
            // 
            this.fightButton.Enabled = false;
            this.fightButton.Location = new System.Drawing.Point(336, 513);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(220, 38);
            this.fightButton.TabIndex = 6;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // CharSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 556);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.characterUI2);
            this.Controls.Add(this.characterUI1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CharSelectForm";
            this.Text = "CharSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private CharacterUI characterUI1;
        private CharacterUI characterUI2;
        private System.Windows.Forms.Button fightButton;
    }
}