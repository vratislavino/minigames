﻿
namespace Minigames
{
    partial class WallMinigame
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WallMinigame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.DoubleBuffered = true;
            this.Name = "WallMinigame";
            this.Size = new System.Drawing.Size(800, 738);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WallMinigame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WallMinigame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WallMinigame_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
