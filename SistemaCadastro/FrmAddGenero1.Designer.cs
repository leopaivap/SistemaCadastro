namespace SistemaCadastro
{
    partial class FrmAddGenero1
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbladdgen = new System.Windows.Forms.Label();
            this.txtAddGenero = new System.Windows.Forms.TextBox();
            this.lblnomegen = new System.Windows.Forms.Label();
            this.btnAddGenero = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::SistemaCadastro.Properties.Resources.close;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(741, 33);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(59, 65);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 35);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(59, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 201);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 327);
            this.panel1.TabIndex = 11;
            // 
            // lbladdgen
            // 
            this.lbladdgen.AutoSize = true;
            this.lbladdgen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbladdgen.Location = new System.Drawing.Point(384, 48);
            this.lbladdgen.Name = "lbladdgen";
            this.lbladdgen.Size = new System.Drawing.Size(192, 31);
            this.lbladdgen.TabIndex = 12;
            this.lbladdgen.Text = "Adicionar Genero";
            // 
            // txtAddGenero
            // 
            this.txtAddGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddGenero.Location = new System.Drawing.Point(355, 181);
            this.txtAddGenero.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddGenero.Name = "txtAddGenero";
            this.txtAddGenero.Size = new System.Drawing.Size(384, 34);
            this.txtAddGenero.TabIndex = 14;
            // 
            // lblnomegen
            // 
            this.lblnomegen.AutoSize = true;
            this.lblnomegen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnomegen.ForeColor = System.Drawing.Color.DimGray;
            this.lblnomegen.Location = new System.Drawing.Point(256, 188);
            this.lblnomegen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblnomegen.Name = "lblnomegen";
            this.lblnomegen.Size = new System.Drawing.Size(89, 23);
            this.lblnomegen.TabIndex = 13;
            this.lblnomegen.Text = "Genero:";
            this.lblnomegen.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAddGenero
            // 
            this.btnAddGenero.FlatAppearance.BorderSize = 0;
            this.btnAddGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddGenero.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddGenero.Image = global::SistemaCadastro.Properties.Resources.add;
            this.btnAddGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGenero.Location = new System.Drawing.Point(401, 273);
            this.btnAddGenero.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddGenero.Name = "btnAddGenero";
            this.btnAddGenero.Size = new System.Drawing.Size(175, 75);
            this.btnAddGenero.TabIndex = 15;
            this.btnAddGenero.Text = "Confirmar";
            this.btnAddGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGenero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddGenero.UseVisualStyleBackColor = true;
            this.btnAddGenero.Click += new System.EventHandler(this.btnAddGenero_Click);
            // 
            // FrmAddGenero1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.btnAddGenero);
            this.Controls.Add(this.txtAddGenero);
            this.Controls.Add(this.lblnomegen);
            this.Controls.Add(this.lbladdgen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddGenero1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddGenero1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbladdgen;
        private System.Windows.Forms.TextBox txtAddGenero;
        private System.Windows.Forms.Label lblnomegen;
        private System.Windows.Forms.Button btnAddGenero;
    }
}