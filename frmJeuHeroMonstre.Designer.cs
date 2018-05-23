namespace CombatHeroMonstre_WF
{
    partial class frmJeuHeroMonstre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJeuHeroMonstre));
            this.lblNbrMonstre = new System.Windows.Forms.Label();
            this.btnCombatAuto = new System.Windows.Forms.Button();
            this.btnHero = new System.Windows.Forms.Button();
            this.pnlHeart = new System.Windows.Forms.Panel();
            this.picHeart5 = new System.Windows.Forms.PictureBox();
            this.picHeart4 = new System.Windows.Forms.PictureBox();
            this.picHeart3 = new System.Windows.Forms.PictureBox();
            this.picHeart2 = new System.Windows.Forms.PictureBox();
            this.picHeart1 = new System.Windows.Forms.PictureBox();
            this.picMonstre = new System.Windows.Forms.PictureBox();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCombatManuel = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlHeart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonstre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNbrMonstre
            // 
            this.lblNbrMonstre.AutoSize = true;
            this.lblNbrMonstre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrMonstre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNbrMonstre.Location = new System.Drawing.Point(126, 442);
            this.lblNbrMonstre.Name = "lblNbrMonstre";
            this.lblNbrMonstre.Size = new System.Drawing.Size(169, 13);
            this.lblNbrMonstre.TabIndex = 1;
            this.lblNbrMonstre.Text = "Nombre de monstres tués : 0";
            // 
            // btnCombatAuto
            // 
            this.btnCombatAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombatAuto.Location = new System.Drawing.Point(129, 480);
            this.btnCombatAuto.Name = "btnCombatAuto";
            this.btnCombatAuto.Size = new System.Drawing.Size(189, 52);
            this.btnCombatAuto.TabIndex = 2;
            this.btnCombatAuto.Text = "Combat automatique";
            this.btnCombatAuto.UseVisualStyleBackColor = true;
            this.btnCombatAuto.Click += new System.EventHandler(this.btnCombatAuto_Click);
            // 
            // btnHero
            // 
            this.btnHero.Enabled = false;
            this.btnHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHero.Location = new System.Drawing.Point(129, 395);
            this.btnHero.Name = "btnHero";
            this.btnHero.Size = new System.Drawing.Size(101, 23);
            this.btnHero.TabIndex = 3;
            this.btnHero.Text = "Héro attaque";
            this.btnHero.UseVisualStyleBackColor = true;
            this.btnHero.Click += new System.EventHandler(this.btnHero_Click);
            // 
            // pnlHeart
            // 
            this.pnlHeart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlHeart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeart.Controls.Add(this.picHeart5);
            this.pnlHeart.Controls.Add(this.picHeart4);
            this.pnlHeart.Controls.Add(this.picHeart3);
            this.pnlHeart.Controls.Add(this.picHeart2);
            this.pnlHeart.Controls.Add(this.picHeart1);
            this.pnlHeart.ForeColor = System.Drawing.Color.Coral;
            this.pnlHeart.Location = new System.Drawing.Point(81, 213);
            this.pnlHeart.Name = "pnlHeart";
            this.pnlHeart.Size = new System.Drawing.Size(30, 142);
            this.pnlHeart.TabIndex = 12;
            // 
            // picHeart5
            // 
            this.picHeart5.Image = global::CombatHeroMonstre_WF.Properties.Resources.if_heart_299063;
            this.picHeart5.Location = new System.Drawing.Point(4, 111);
            this.picHeart5.Name = "picHeart5";
            this.picHeart5.Size = new System.Drawing.Size(20, 20);
            this.picHeart5.TabIndex = 16;
            this.picHeart5.TabStop = false;
            // 
            // picHeart4
            // 
            this.picHeart4.Image = global::CombatHeroMonstre_WF.Properties.Resources.if_heart_299063;
            this.picHeart4.Location = new System.Drawing.Point(4, 85);
            this.picHeart4.Name = "picHeart4";
            this.picHeart4.Size = new System.Drawing.Size(20, 20);
            this.picHeart4.TabIndex = 15;
            this.picHeart4.TabStop = false;
            // 
            // picHeart3
            // 
            this.picHeart3.Image = global::CombatHeroMonstre_WF.Properties.Resources.if_heart_299063;
            this.picHeart3.Location = new System.Drawing.Point(4, 59);
            this.picHeart3.Name = "picHeart3";
            this.picHeart3.Size = new System.Drawing.Size(20, 20);
            this.picHeart3.TabIndex = 14;
            this.picHeart3.TabStop = false;
            // 
            // picHeart2
            // 
            this.picHeart2.Image = global::CombatHeroMonstre_WF.Properties.Resources.if_heart_299063;
            this.picHeart2.Location = new System.Drawing.Point(4, 33);
            this.picHeart2.Name = "picHeart2";
            this.picHeart2.Size = new System.Drawing.Size(20, 20);
            this.picHeart2.TabIndex = 13;
            this.picHeart2.TabStop = false;
            // 
            // picHeart1
            // 
            this.picHeart1.Image = global::CombatHeroMonstre_WF.Properties.Resources.if_heart_299063;
            this.picHeart1.Location = new System.Drawing.Point(4, 7);
            this.picHeart1.Name = "picHeart1";
            this.picHeart1.Size = new System.Drawing.Size(20, 20);
            this.picHeart1.TabIndex = 12;
            this.picHeart1.TabStop = false;
            // 
            // picMonstre
            // 
            this.picMonstre.Image = global::CombatHeroMonstre_WF.Properties.Resources.Monstre;
            this.picMonstre.Location = new System.Drawing.Point(334, 213);
            this.picMonstre.Name = "picMonstre";
            this.picMonstre.Size = new System.Drawing.Size(178, 156);
            this.picMonstre.TabIndex = 6;
            this.picMonstre.TabStop = false;
            // 
            // picHero
            // 
            this.picHero.Image = global::CombatHeroMonstre_WF.Properties.Resources.Hero;
            this.picHero.Location = new System.Drawing.Point(129, 213);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(87, 187);
            this.picHero.TabIndex = 5;
            this.picHero.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Le but du jeu : Connaitre le nombre de monstrés tués par notre héro avant de mour" +
    "ir";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(307, 372);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(70, 13);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "Information";
            this.lblInfo.Visible = false;
            // 
            // btnCombatManuel
            // 
            this.btnCombatManuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombatManuel.Location = new System.Drawing.Point(347, 480);
            this.btnCombatManuel.Name = "btnCombatManuel";
            this.btnCombatManuel.Size = new System.Drawing.Size(234, 52);
            this.btnCombatManuel.TabIndex = 17;
            this.btnCombatManuel.Text = "Combat manuel \r\n(en utilisant le bouton \"Héro attaque\")";
            this.btnCombatManuel.UseVisualStyleBackColor = true;
            this.btnCombatManuel.Click += new System.EventHandler(this.btnCombatManuel_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Yellow;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(129, 548);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(452, 52);
            this.btnNewGame.TabIndex = 18;
            this.btnNewGame.Text = "Nouvelle partie";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(622, 152);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmJeuHeroMonstre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 624);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnHero);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnCombatManuel);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlHeart);
            this.Controls.Add(this.picMonstre);
            this.Controls.Add(this.picHero);
            this.Controls.Add(this.btnCombatAuto);
            this.Controls.Add(this.lblNbrMonstre);
            this.Name = "frmJeuHeroMonstre";
            this.Text = "Combat Héro - Monstre";
            this.pnlHeart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHeart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonstre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNbrMonstre;
        private System.Windows.Forms.Button btnCombatAuto;
        private System.Windows.Forms.Button btnHero;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.PictureBox picMonstre;
        private System.Windows.Forms.Panel pnlHeart;
        private System.Windows.Forms.PictureBox picHeart5;
        private System.Windows.Forms.PictureBox picHeart4;
        private System.Windows.Forms.PictureBox picHeart3;
        private System.Windows.Forms.PictureBox picHeart2;
        private System.Windows.Forms.PictureBox picHeart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCombatManuel;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

