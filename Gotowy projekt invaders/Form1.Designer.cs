namespace Gotowy_projekt_invaders
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zegarGry0 = new System.Windows.Forms.Timer(this.components);
            this.zegarGry1 = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.labelKoniecGry = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // zegarGry0
            // 
            this.zegarGry0.Tick += new System.EventHandler(this.zegarGry0_Tick);
            // 
            // zegarGry1
            // 
            this.zegarGry1.Tick += new System.EventHandler(this.zegarGry1_Tick);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::Gotowy_projekt_invaders.Properties.Resources.player;
            this.pbPlayer.Location = new System.Drawing.Point(340, 373);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(54, 33);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // labelKoniecGry
            // 
            this.labelKoniecGry.AutoSize = true;
            this.labelKoniecGry.BackColor = System.Drawing.Color.Maroon;
            this.labelKoniecGry.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKoniecGry.Location = new System.Drawing.Point(60, 396);
            this.labelKoniecGry.Name = "labelKoniecGry";
            this.labelKoniecGry.Size = new System.Drawing.Size(0, 36);
            this.labelKoniecGry.TabIndex = 1;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.BackColor = System.Drawing.Color.Maroon;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.Location = new System.Drawing.Point(13, 13);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(0, 36);
            this.labelPoints.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelKoniecGry);
            this.Controls.Add(this.pbPlayer);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer zegarGry0;
        private System.Windows.Forms.Timer zegarGry1;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label labelKoniecGry;
        private System.Windows.Forms.Label labelPoints;
    }
}

