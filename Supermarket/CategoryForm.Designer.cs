
namespace Supermarket
{
    partial class CategoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCategoryDelete = new System.Windows.Forms.Button();
            this.BtnCategoryEdit = new System.Windows.Forms.Button();
            this.BtnCategoryAdd = new System.Windows.Forms.Button();
            this.CatDescTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.CatNameTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.CatIdTbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.BtnCategoryDelete);
            this.panel1.Controls.Add(this.BtnCategoryEdit);
            this.panel1.Controls.Add(this.BtnCategoryAdd);
            this.panel1.Controls.Add(this.CatDescTbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CatNameTbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CatIdTbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(158, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 562);
            this.panel1.TabIndex = 27;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(707, 34);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 42);
            this.button8.TabIndex = 22;
            this.button8.Text = "REFRESH";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox2.Location = new System.Drawing.Point(449, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Text = "SELECT ROLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 417);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnCategoryDelete
            // 
            this.BtnCategoryDelete.FlatAppearance.BorderSize = 0;
            this.BtnCategoryDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoryDelete.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCategoryDelete.Location = new System.Drawing.Point(232, 335);
            this.BtnCategoryDelete.Name = "BtnCategoryDelete";
            this.BtnCategoryDelete.Size = new System.Drawing.Size(112, 42);
            this.BtnCategoryDelete.TabIndex = 19;
            this.BtnCategoryDelete.Text = "DELETE";
            this.BtnCategoryDelete.UseVisualStyleBackColor = true;
            this.BtnCategoryDelete.Click += new System.EventHandler(this.BtnCategoryDelete_Click);
            // 
            // BtnCategoryEdit
            // 
            this.BtnCategoryEdit.FlatAppearance.BorderSize = 0;
            this.BtnCategoryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoryEdit.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCategoryEdit.Location = new System.Drawing.Point(114, 335);
            this.BtnCategoryEdit.Name = "BtnCategoryEdit";
            this.BtnCategoryEdit.Size = new System.Drawing.Size(112, 42);
            this.BtnCategoryEdit.TabIndex = 18;
            this.BtnCategoryEdit.Text = "EDIT";
            this.BtnCategoryEdit.UseVisualStyleBackColor = true;
            this.BtnCategoryEdit.Click += new System.EventHandler(this.BtnCategoryEdit_Click);
            // 
            // BtnCategoryAdd
            // 
            this.BtnCategoryAdd.FlatAppearance.BorderSize = 0;
            this.BtnCategoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoryAdd.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCategoryAdd.Location = new System.Drawing.Point(16, 335);
            this.BtnCategoryAdd.Name = "BtnCategoryAdd";
            this.BtnCategoryAdd.Size = new System.Drawing.Size(112, 42);
            this.BtnCategoryAdd.TabIndex = 17;
            this.BtnCategoryAdd.Text = "ADD";
            this.BtnCategoryAdd.UseVisualStyleBackColor = true;
            this.BtnCategoryAdd.Click += new System.EventHandler(this.BtnCategoryAdd_Click);
            // 
            // CatDescTbl
            // 
            this.CatDescTbl.BackColor = System.Drawing.Color.DarkOrange;
            this.CatDescTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatDescTbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CatDescTbl.ForeColor = System.Drawing.Color.Black;
            this.CatDescTbl.HintForeColor = System.Drawing.Color.Empty;
            this.CatDescTbl.HintText = "";
            this.CatDescTbl.isPassword = false;
            this.CatDescTbl.LineFocusedColor = System.Drawing.Color.White;
            this.CatDescTbl.LineIdleColor = System.Drawing.Color.White;
            this.CatDescTbl.LineMouseHoverColor = System.Drawing.Color.BlanchedAlmond;
            this.CatDescTbl.LineThickness = 5;
            this.CatDescTbl.Location = new System.Drawing.Point(135, 237);
            this.CatDescTbl.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CatDescTbl.Name = "CatDescTbl";
            this.CatDescTbl.Size = new System.Drawing.Size(210, 31);
            this.CatDescTbl.TabIndex = 12;
            this.CatDescTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "DESCRIPTION";
            // 
            // CatNameTbl
            // 
            this.CatNameTbl.BackColor = System.Drawing.Color.DarkOrange;
            this.CatNameTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CatNameTbl.ForeColor = System.Drawing.Color.Black;
            this.CatNameTbl.HintForeColor = System.Drawing.Color.Empty;
            this.CatNameTbl.HintText = "";
            this.CatNameTbl.isPassword = false;
            this.CatNameTbl.LineFocusedColor = System.Drawing.Color.White;
            this.CatNameTbl.LineIdleColor = System.Drawing.Color.White;
            this.CatNameTbl.LineMouseHoverColor = System.Drawing.Color.BlanchedAlmond;
            this.CatNameTbl.LineThickness = 5;
            this.CatNameTbl.Location = new System.Drawing.Point(135, 175);
            this.CatNameTbl.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CatNameTbl.Name = "CatNameTbl";
            this.CatNameTbl.Size = new System.Drawing.Size(210, 31);
            this.CatNameTbl.TabIndex = 10;
            this.CatNameTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "NAME";
            // 
            // CatIdTbl
            // 
            this.CatIdTbl.BackColor = System.Drawing.Color.DarkOrange;
            this.CatIdTbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIdTbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CatIdTbl.ForeColor = System.Drawing.Color.Black;
            this.CatIdTbl.HintForeColor = System.Drawing.Color.Empty;
            this.CatIdTbl.HintText = "";
            this.CatIdTbl.isPassword = false;
            this.CatIdTbl.LineFocusedColor = System.Drawing.Color.White;
            this.CatIdTbl.LineIdleColor = System.Drawing.Color.White;
            this.CatIdTbl.LineMouseHoverColor = System.Drawing.Color.BlanchedAlmond;
            this.CatIdTbl.LineThickness = 5;
            this.CatIdTbl.Location = new System.Drawing.Point(135, 108);
            this.CatIdTbl.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CatIdTbl.Name = "CatIdTbl";
            this.CatIdTbl.Size = new System.Drawing.Size(210, 31);
            this.CatIdTbl.TabIndex = 8;
            this.CatIdTbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(352, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Categories";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(40, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 42);
            this.button4.TabIndex = 30;
            this.button4.Text = "Selling";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(40, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 42);
            this.button3.TabIndex = 29;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(40, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCategoryDelete;
        private System.Windows.Forms.Button BtnCategoryEdit;
        private System.Windows.Forms.Button BtnCategoryAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatDescTbl;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatNameTbl;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatIdTbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}