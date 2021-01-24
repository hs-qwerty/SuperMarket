
namespace Supermarket
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginGrsTbl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LoginGrsNameTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginGrsPassTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(324, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(104, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(104, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PASSWORD";
            // 
            // LoginGrsTbl
            // 
            this.LoginGrsTbl.ActiveBorderThickness = 1;
            this.LoginGrsTbl.ActiveCornerRadius = 20;
            this.LoginGrsTbl.ActiveFillColor = System.Drawing.Color.Black;
            this.LoginGrsTbl.ActiveForecolor = System.Drawing.Color.White;
            this.LoginGrsTbl.ActiveLineColor = System.Drawing.Color.White;
            this.LoginGrsTbl.BackColor = System.Drawing.SystemColors.Control;
            this.LoginGrsTbl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginGrsTbl.BackgroundImage")));
            this.LoginGrsTbl.ButtonText = "Login";
            this.LoginGrsTbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginGrsTbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGrsTbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.LoginGrsTbl.IdleBorderThickness = 1;
            this.LoginGrsTbl.IdleCornerRadius = 20;
            this.LoginGrsTbl.IdleFillColor = System.Drawing.Color.Brown;
            this.LoginGrsTbl.IdleForecolor = System.Drawing.Color.DarkOrange;
            this.LoginGrsTbl.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.LoginGrsTbl.Location = new System.Drawing.Point(227, 317);
            this.LoginGrsTbl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LoginGrsTbl.Name = "LoginGrsTbl";
            this.LoginGrsTbl.Size = new System.Drawing.Size(274, 43);
            this.LoginGrsTbl.TabIndex = 5;
            this.LoginGrsTbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginGrsTbl.Click += new System.EventHandler(this.LoginGrsTbl_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox1.Location = new System.Drawing.Point(227, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "SELECT ROLE";
            // 
            // LoginGrsNameTbl
            // 
            this.LoginGrsNameTbl.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LoginGrsNameTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginGrsNameTbl.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.LoginGrsNameTbl.ForeColor = System.Drawing.Color.Black;
            this.LoginGrsNameTbl.HintForeColor = System.Drawing.Color.Empty;
            this.LoginGrsNameTbl.HintText = "";
            this.LoginGrsNameTbl.isPassword = false;
            this.LoginGrsNameTbl.LineFocusedColor = System.Drawing.Color.Black;
            this.LoginGrsNameTbl.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.LoginGrsNameTbl.LineMouseHoverColor = System.Drawing.Color.Black;
            this.LoginGrsNameTbl.LineThickness = 4;
            this.LoginGrsNameTbl.Location = new System.Drawing.Point(227, 185);
            this.LoginGrsNameTbl.Margin = new System.Windows.Forms.Padding(5);
            this.LoginGrsNameTbl.Name = "LoginGrsNameTbl";
            this.LoginGrsNameTbl.Size = new System.Drawing.Size(274, 41);
            this.LoginGrsNameTbl.TabIndex = 7;
            this.LoginGrsNameTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginGrsPassTbl
            // 
            this.LoginGrsPassTbl.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LoginGrsPassTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginGrsPassTbl.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.LoginGrsPassTbl.ForeColor = System.Drawing.Color.Black;
            this.LoginGrsPassTbl.HintForeColor = System.Drawing.Color.Empty;
            this.LoginGrsPassTbl.HintText = "";
            this.LoginGrsPassTbl.isPassword = false;
            this.LoginGrsPassTbl.LineFocusedColor = System.Drawing.Color.Black;
            this.LoginGrsPassTbl.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.LoginGrsPassTbl.LineMouseHoverColor = System.Drawing.Color.Black;
            this.LoginGrsPassTbl.LineThickness = 4;
            this.LoginGrsPassTbl.Location = new System.Drawing.Point(227, 242);
            this.LoginGrsPassTbl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginGrsPassTbl.Name = "LoginGrsPassTbl";
            this.LoginGrsPassTbl.Size = new System.Drawing.Size(274, 39);
            this.LoginGrsPassTbl.TabIndex = 8;
            this.LoginGrsPassTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(361, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clear";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(631, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginGrsPassTbl);
            this.Controls.Add(this.LoginGrsNameTbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoginGrsTbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginGrsTbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginGrsNameTbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginGrsPassTbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

