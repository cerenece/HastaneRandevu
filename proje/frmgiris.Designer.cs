
namespace oop3
{
    partial class frmgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgiris));
            this.btnhasta = new System.Windows.Forms.Button();
            this.btnhakkinda = new System.Windows.Forms.Button();
            this.btniletisim = new System.Windows.Forms.Button();
            this.btndoktorgiris = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhasta
            // 
            this.btnhasta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhasta.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhasta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhasta.Location = new System.Drawing.Point(568, 267);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(168, 35);
            this.btnhasta.TabIndex = 3;
            this.btnhasta.Text = "HASTA GİRİŞİ";
            this.btnhasta.UseVisualStyleBackColor = false;
            this.btnhasta.Click += new System.EventHandler(this.btnhasta_Click);
            // 
            // btnhakkinda
            // 
            this.btnhakkinda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhakkinda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhakkinda.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhakkinda.Location = new System.Drawing.Point(267, 346);
            this.btnhakkinda.Name = "btnhakkinda";
            this.btnhakkinda.Size = new System.Drawing.Size(168, 35);
            this.btnhakkinda.TabIndex = 4;
            this.btnhakkinda.Text = "HAKKINDA";
            this.btnhakkinda.UseVisualStyleBackColor = false;
            this.btnhakkinda.Click += new System.EventHandler(this.btnhakkinda_Click);
            // 
            // btniletisim
            // 
            this.btniletisim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btniletisim.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniletisim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btniletisim.Location = new System.Drawing.Point(458, 346);
            this.btniletisim.Name = "btniletisim";
            this.btniletisim.Size = new System.Drawing.Size(168, 35);
            this.btniletisim.TabIndex = 5;
            this.btniletisim.Text = "İLETİŞİM";
            this.btniletisim.UseVisualStyleBackColor = false;
            this.btniletisim.Click += new System.EventHandler(this.btniletisim_Click);
            // 
            // btndoktorgiris
            // 
            this.btndoktorgiris.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndoktorgiris.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndoktorgiris.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndoktorgiris.Location = new System.Drawing.Point(142, 267);
            this.btndoktorgiris.Name = "btndoktorgiris";
            this.btndoktorgiris.Size = new System.Drawing.Size(168, 35);
            this.btndoktorgiris.TabIndex = 6;
            this.btndoktorgiris.Text = "DOKTOR GİRİŞİ";
            this.btndoktorgiris.UseVisualStyleBackColor = false;
            this.btndoktorgiris.Click += new System.EventHandler(this.btndoktorgiris_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(359, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(309, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 38);
            this.label9.TabIndex = 88;
            this.label9.Text = "PAÜ POLİKLİNİĞİ";
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 455);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btndoktorgiris);
            this.Controls.Add(this.btniletisim);
            this.Controls.Add(this.btnhakkinda);
            this.Controls.Add(this.btnhasta);
            this.MaximizeBox = false;
            this.Name = "frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Button btnhakkinda;
        private System.Windows.Forms.Button btniletisim;
        private System.Windows.Forms.Button btndoktorgiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
    }
}

