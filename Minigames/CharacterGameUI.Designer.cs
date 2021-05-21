
namespace Minigames
{
    partial class CharacterGameUI
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent() {
            this.nameLabel = new System.Windows.Forms.Label();
            this.charImage = new System.Windows.Forms.PictureBox();
            this.hpBar = new Bar();
            ((System.ComponentModel.ISupportInitialize)(this.charImage)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(12, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Wizard";
            // 
            // charImage
            // 
            this.charImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.charImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charImage.Location = new System.Drawing.Point(16, 41);
            this.charImage.Name = "charImage";
            this.charImage.Size = new System.Drawing.Size(150, 150);
            this.charImage.TabIndex = 1;
            this.charImage.TabStop = false;
            // 
            // hpBar
            // 
            this.hpBar.Current = 500D;
            this.hpBar.Location = new System.Drawing.Point(16, 207);
            this.hpBar.Name = "hpBar";
            this.hpBar.Size = new System.Drawing.Size(150, 48);
            this.hpBar.TabIndex = 2;
            // 
            // CharacterGameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hpBar);
            this.Controls.Add(this.charImage);
            this.Controls.Add(this.nameLabel);
            this.Name = "CharacterGameUI";
            this.Size = new System.Drawing.Size(182, 270);
            ((System.ComponentModel.ISupportInitialize)(this.charImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox charImage;
        private Bar hpBar;
    }
}
