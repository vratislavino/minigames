
namespace Minigames
{
    partial class CharacterUI
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
            this.charImage = new System.Windows.Forms.PictureBox();
            this.charName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.charDescription = new System.Windows.Forms.Label();
            this.speedBar = new Minigames.Bar();
            this.chanceToCritBar = new Minigames.Bar();
            this.dexterityBar = new Minigames.Bar();
            this.damageBar = new Minigames.Bar();
            this.hpBar = new Minigames.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.charImage)).BeginInit();
            this.SuspendLayout();
            // 
            // charImage
            // 
            this.charImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.charImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charImage.Location = new System.Drawing.Point(16, 16);
            this.charImage.Name = "charImage";
            this.charImage.Size = new System.Drawing.Size(160, 160);
            this.charImage.TabIndex = 0;
            this.charImage.TabStop = false;
            this.charImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // charName
            // 
            this.charName.AutoSize = true;
            this.charName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.charName.Location = new System.Drawing.Point(182, 16);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(79, 25);
            this.charName.TabIndex = 1;
            this.charName.Text = "Wizard";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(275, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "(played 12x)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // charDescription
            // 
            this.charDescription.Location = new System.Drawing.Point(182, 41);
            this.charDescription.Name = "charDescription";
            this.charDescription.Size = new System.Drawing.Size(214, 57);
            this.charDescription.TabIndex = 3;
            this.charDescription.Text = "Flying creature killing by his huge claws. Flying creature killing by his huge cl" +
    "aws.";
            // 
            // speedBar
            // 
            this.speedBar.Current = 100D;
            this.speedBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.speedBar.Location = new System.Drawing.Point(213, 292);
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(185, 48);
            this.speedBar.TabIndex = 8;
            // 
            // chanceToCritBar
            // 
            this.chanceToCritBar.Current = 300D;
            this.chanceToCritBar.Location = new System.Drawing.Point(16, 292);
            this.chanceToCritBar.Name = "chanceToCritBar";
            this.chanceToCritBar.Size = new System.Drawing.Size(191, 48);
            this.chanceToCritBar.TabIndex = 7;
            // 
            // dexterityBar
            // 
            this.dexterityBar.Current = 300D;
            this.dexterityBar.Location = new System.Drawing.Point(213, 238);
            this.dexterityBar.Name = "dexterityBar";
            this.dexterityBar.Size = new System.Drawing.Size(185, 48);
            this.dexterityBar.TabIndex = 6;
            // 
            // damageBar
            // 
            this.damageBar.Current = 300D;
            this.damageBar.Location = new System.Drawing.Point(16, 238);
            this.damageBar.Name = "damageBar";
            this.damageBar.Size = new System.Drawing.Size(191, 48);
            this.damageBar.TabIndex = 5;
            // 
            // hpBar
            // 
            this.hpBar.Current = 300D;
            this.hpBar.Location = new System.Drawing.Point(16, 182);
            this.hpBar.Name = "hpBar";
            this.hpBar.Size = new System.Drawing.Size(382, 48);
            this.hpBar.TabIndex = 4;
            // 
            // CharacterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.chanceToCritBar);
            this.Controls.Add(this.dexterityBar);
            this.Controls.Add(this.damageBar);
            this.Controls.Add(this.hpBar);
            this.Controls.Add(this.charDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charName);
            this.Controls.Add(this.charImage);
            this.Name = "CharacterUI";
            this.Size = new System.Drawing.Size(401, 347);
            ((System.ComponentModel.ISupportInitialize)(this.charImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox charImage;
        private System.Windows.Forms.Label charName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label charDescription;
        private Bar hpBar;
        private Bar damageBar;
        private Bar dexterityBar;
        private Bar speedBar;
        private Bar chanceToCritBar;
    }
}
