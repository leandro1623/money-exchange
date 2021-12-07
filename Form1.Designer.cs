
namespace Cambio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.btn_Cambiar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._Cinco = new System.Windows.Forms.Label();
            this._Diez = new System.Windows.Forms.Label();
            this._VenteYcinco = new System.Windows.Forms.Label();
            this._Cincuenta = new System.Windows.Forms.Label();
            this._Cien = new System.Windows.Forms.Label();
            this._Doscientos = new System.Windows.Forms.Label();
            this._Quinientos = new System.Windows.Forms.Label();
            this._Mil = new System.Windows.Forms.Label();
            this._Dos_Mil = new System.Windows.Forms.Label();
            this._Pesos = new System.Windows.Forms.Label();
            this.Firma = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite la cantidad:\r\nEnter the amount:  ";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(137, 42);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(241, 20);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // btn_Cambiar
            // 
            this.btn_Cambiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cambiar.Location = new System.Drawing.Point(384, 40);
            this.btn_Cambiar.Name = "btn_Cambiar";
            this.btn_Cambiar.Size = new System.Drawing.Size(107, 23);
            this.btn_Cambiar.TabIndex = 2;
            this.btn_Cambiar.Text = "Cambiar (change)";
            this.btn_Cambiar.UseVisualStyleBackColor = true;
            this.btn_Cambiar.Click += new System.EventHandler(this.btn_Cambiar_Click);
            // 
            // Fecha
            // 
            this.Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(385, 9);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 3;
            this.Fecha.Text = "Fecha";
            this.Fecha.Click += new System.EventHandler(this.Fecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dos Mil (two thousand)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mil (one thousand)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quinientos (five hundred";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pesos (one)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cinco (five)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Vente y cinco (twenty five)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cincuenta (fifty)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cien (one hundred)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Diez (Ten)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Doscientos (two hundred)";
            // 
            // _Cinco
            // 
            this._Cinco.AutoSize = true;
            this._Cinco.Location = new System.Drawing.Point(284, 310);
            this._Cinco.Name = "_Cinco";
            this._Cinco.Size = new System.Drawing.Size(41, 13);
            this._Cinco.TabIndex = 14;
            this._Cinco.Text = "label12";
            // 
            // _Diez
            // 
            this._Diez.AutoSize = true;
            this._Diez.Location = new System.Drawing.Point(284, 288);
            this._Diez.Name = "_Diez";
            this._Diez.Size = new System.Drawing.Size(41, 13);
            this._Diez.TabIndex = 15;
            this._Diez.Text = "label13";
            // 
            // _VenteYcinco
            // 
            this._VenteYcinco.AutoSize = true;
            this._VenteYcinco.Location = new System.Drawing.Point(284, 265);
            this._VenteYcinco.Name = "_VenteYcinco";
            this._VenteYcinco.Size = new System.Drawing.Size(41, 13);
            this._VenteYcinco.TabIndex = 16;
            this._VenteYcinco.Text = "label14";
            // 
            // _Cincuenta
            // 
            this._Cincuenta.AutoSize = true;
            this._Cincuenta.Location = new System.Drawing.Point(284, 239);
            this._Cincuenta.Name = "_Cincuenta";
            this._Cincuenta.Size = new System.Drawing.Size(41, 13);
            this._Cincuenta.TabIndex = 17;
            this._Cincuenta.Text = "label15";
            // 
            // _Cien
            // 
            this._Cien.AutoSize = true;
            this._Cien.Location = new System.Drawing.Point(284, 214);
            this._Cien.Name = "_Cien";
            this._Cien.Size = new System.Drawing.Size(41, 13);
            this._Cien.TabIndex = 18;
            this._Cien.Text = "label16";
            // 
            // _Doscientos
            // 
            this._Doscientos.AutoSize = true;
            this._Doscientos.Location = new System.Drawing.Point(284, 191);
            this._Doscientos.Name = "_Doscientos";
            this._Doscientos.Size = new System.Drawing.Size(41, 13);
            this._Doscientos.TabIndex = 19;
            this._Doscientos.Text = "label17";
            // 
            // _Quinientos
            // 
            this._Quinientos.AutoSize = true;
            this._Quinientos.Location = new System.Drawing.Point(284, 167);
            this._Quinientos.Name = "_Quinientos";
            this._Quinientos.Size = new System.Drawing.Size(41, 13);
            this._Quinientos.TabIndex = 20;
            this._Quinientos.Text = "label18";
            // 
            // _Mil
            // 
            this._Mil.AutoSize = true;
            this._Mil.Location = new System.Drawing.Point(284, 141);
            this._Mil.Name = "_Mil";
            this._Mil.Size = new System.Drawing.Size(41, 13);
            this._Mil.TabIndex = 21;
            this._Mil.Text = "label19";
            // 
            // _Dos_Mil
            // 
            this._Dos_Mil.AutoSize = true;
            this._Dos_Mil.Location = new System.Drawing.Point(284, 113);
            this._Dos_Mil.Name = "_Dos_Mil";
            this._Dos_Mil.Size = new System.Drawing.Size(41, 13);
            this._Dos_Mil.TabIndex = 22;
            this._Dos_Mil.Text = "label20";
            // 
            // _Pesos
            // 
            this._Pesos.AutoSize = true;
            this._Pesos.Location = new System.Drawing.Point(284, 333);
            this._Pesos.Name = "_Pesos";
            this._Pesos.Size = new System.Drawing.Size(41, 13);
            this._Pesos.TabIndex = 23;
            this._Pesos.Text = "label21";
            // 
            // Firma
            // 
            this.Firma.AutoSize = true;
            this.Firma.Enabled = false;
            this.Firma.Location = new System.Drawing.Point(385, 358);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(132, 13);
            this.Firma.TabIndex = 24;
            this.Firma.Text = "by Leandro Brito Contreras";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.archivoToolStripMenuItem.Text = "Archivo (file)";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir (leave)";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 380);
            this.Controls.Add(this.Firma);
            this.Controls.Add(this._Pesos);
            this.Controls.Add(this._Dos_Mil);
            this.Controls.Add(this._Mil);
            this.Controls.Add(this._Quinientos);
            this.Controls.Add(this._Doscientos);
            this.Controls.Add(this._Cien);
            this.Controls.Add(this._Cincuenta);
            this.Controls.Add(this._VenteYcinco);
            this.Controls.Add(this._Diez);
            this.Controls.Add(this._Cinco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.btn_Cambiar);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Contador de dinero ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button btn_Cambiar;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label _Cinco;
        private System.Windows.Forms.Label _Diez;
        private System.Windows.Forms.Label _VenteYcinco;
        private System.Windows.Forms.Label _Cincuenta;
        private System.Windows.Forms.Label _Cien;
        private System.Windows.Forms.Label _Doscientos;
        private System.Windows.Forms.Label _Quinientos;
        private System.Windows.Forms.Label _Mil;
        private System.Windows.Forms.Label _Dos_Mil;
        private System.Windows.Forms.Label _Pesos;
        private System.Windows.Forms.Label Firma;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

