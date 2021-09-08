namespace Yılan_Oyunu
{
    partial class Game
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Pnl = new System.Windows.Forms.Panel();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblpuan1 = new System.Windows.Forms.Label();
            this.lblsüre31 = new System.Windows.Forms.Label();
            this.lblsüre1 = new System.Windows.Forms.Label();
            this.timerYılanHareket = new System.Windows.Forms.Timer(this.components);
            this.timersaat = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl
            // 
            this.Pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl.Location = new System.Drawing.Point(13, 72);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(697, 380);
            this.Pnl.TabIndex = 1;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblpuan.Location = new System.Drawing.Point(72, 28);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(21, 24);
            this.lblpuan.TabIndex = 2;
            this.lblpuan.Text = "0";
            // 
            // lblpuan1
            // 
            this.lblpuan1.AutoSize = true;
            this.lblpuan1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblpuan1.Location = new System.Drawing.Point(3, 28);
            this.lblpuan1.Name = "lblpuan1";
            this.lblpuan1.Size = new System.Drawing.Size(69, 24);
            this.lblpuan1.TabIndex = 3;
            this.lblpuan1.Text = "Puan :";
            // 
            // lblsüre31
            // 
            this.lblsüre31.AutoSize = true;
            this.lblsüre31.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblsüre31.Location = new System.Drawing.Point(610, 28);
            this.lblsüre31.Name = "lblsüre31";
            this.lblsüre31.Size = new System.Drawing.Size(63, 24);
            this.lblsüre31.TabIndex = 5;
            this.lblsüre31.Text = "Süre :";
            // 
            // lblsüre1
            // 
            this.lblsüre1.AutoSize = true;
            this.lblsüre1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblsüre1.Location = new System.Drawing.Point(673, 28);
            this.lblsüre1.Name = "lblsüre1";
            this.lblsüre1.Size = new System.Drawing.Size(21, 24);
            this.lblsüre1.TabIndex = 4;
            this.lblsüre1.Text = "0";
            // 
            // timerYılanHareket
            // 
            this.timerYılanHareket.Tick += new System.EventHandler(this.timerYılanHareket_Tick);
            // 
            // timersaat
            // 
            this.timersaat.Interval = 1000;
            this.timersaat.Tick += new System.EventHandler(this.timersaat_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblsüre31);
            this.groupBox1.Controls.Add(this.lblpuan);
            this.groupBox1.Controls.Add(this.lblpuan1);
            this.groupBox1.Controls.Add(this.lblsüre1);
            this.groupBox1.Location = new System.Drawing.Point(13, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 65);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(722, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pnl);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblpuan1;
        private System.Windows.Forms.Label lblsüre31;
        private System.Windows.Forms.Label lblsüre1;
        private System.Windows.Forms.Timer timerYılanHareket;
        private System.Windows.Forms.Timer timersaat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

