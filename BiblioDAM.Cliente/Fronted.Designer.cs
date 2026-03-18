namespace BiblioDAM.Cliente
{
    partial class Fronted
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAutorLibro = new TextBox();
            txtFechaPublicacion = new TextBox();
            txtTituloLibro = new TextBox();
            textAutorAdd = new TextBox();
            txtIsb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            btnGuardarAutor = new Button();
            panel2 = new Panel();
            btnGuardarLibro = new Button();
            btnProbarConexion = new Button();
            btnImportarCatalago = new Button();
            btnBuscarLibro = new Button();
            lblEstadoConexion = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Location = new Point(254, 251);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(407, 39);
            txtAutorLibro.TabIndex = 0;
            // 
            // txtFechaPublicacion
            // 
            txtFechaPublicacion.Location = new Point(254, 335);
            txtFechaPublicacion.Name = "txtFechaPublicacion";
            txtFechaPublicacion.Size = new Size(272, 39);
            txtFechaPublicacion.TabIndex = 1;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(254, 183);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(407, 39);
            txtTituloLibro.TabIndex = 2;
            // 
            // textAutorAdd
            // 
            textAutorAdd.Location = new Point(254, 109);
            textAutorAdd.Name = "textAutorAdd";
            textAutorAdd.Size = new Size(407, 39);
            textAutorAdd.TabIndex = 3;
            // 
            // txtIsb
            // 
            txtIsb.Location = new Point(254, 106);
            txtIsb.Name = "txtIsb";
            txtIsb.Size = new Size(407, 39);
            txtIsb.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 112);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-651, 638);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 190);
            label3.Name = "label3";
            label3.Size = new Size(75, 32);
            label3.TabIndex = 7;
            label3.Text = "Titulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 328);
            label4.Name = "label4";
            label4.Size = new Size(185, 32);
            label4.TabIndex = 8;
            label4.Text = "Año Publicación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 113);
            label5.Name = "label5";
            label5.Size = new Size(58, 32);
            label5.TabIndex = 9;
            label5.Text = "Isbn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 258);
            label6.Name = "label6";
            label6.Size = new Size(73, 32);
            label6.TabIndex = 10;
            label6.Text = "Autor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 17);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 11;
            label7.Text = "Alta Libro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 21);
            label8.Name = "label8";
            label8.Size = new Size(121, 32);
            label8.TabIndex = 12;
            label8.Text = "Alta Autor";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardarAutor);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textAutorAdd);
            panel1.Location = new Point(65, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 204);
            panel1.TabIndex = 13;
            // 
            // btnGuardarAutor
            // 
            btnGuardarAutor.Location = new Point(866, 102);
            btnGuardarAutor.Name = "btnGuardarAutor";
            btnGuardarAutor.Size = new Size(196, 46);
            btnGuardarAutor.TabIndex = 13;
            btnGuardarAutor.Text = "Guardar Autor";
            btnGuardarAutor.UseVisualStyleBackColor = true;
            btnGuardarAutor.Click += btnGuardarAutor_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGuardarLibro);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtFechaPublicacion);
            panel2.Controls.Add(txtTituloLibro);
            panel2.Controls.Add(txtAutorLibro);
            panel2.Controls.Add(txtIsb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(65, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(1127, 427);
            panel2.TabIndex = 14;
            // 
            // btnGuardarLibro
            // 
            btnGuardarLibro.Location = new Point(866, 314);
            btnGuardarLibro.Name = "btnGuardarLibro";
            btnGuardarLibro.Size = new Size(194, 46);
            btnGuardarLibro.TabIndex = 12;
            btnGuardarLibro.Text = "Guardar Libro";
            btnGuardarLibro.UseVisualStyleBackColor = true;
            btnGuardarLibro.Click += btnGuardarLibro_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(65, 50);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(213, 46);
            btnProbarConexion.TabIndex = 15;
            btnProbarConexion.Text = "Probar Conexión";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // btnImportarCatalago
            // 
            btnImportarCatalago.Location = new Point(118, 879);
            btnImportarCatalago.Name = "btnImportarCatalago";
            btnImportarCatalago.Size = new Size(223, 46);
            btnImportarCatalago.TabIndex = 16;
            btnImportarCatalago.Text = "Importar Catálogo";
            btnImportarCatalago.UseVisualStyleBackColor = true;
            btnImportarCatalago.Click += btnImportarCatalago_Click;
            // 
            // btnBuscarLibro
            // 
            btnBuscarLibro.Location = new Point(703, 881);
            btnBuscarLibro.Name = "btnBuscarLibro";
            btnBuscarLibro.Size = new Size(247, 46);
            btnBuscarLibro.TabIndex = 17;
            btnBuscarLibro.Text = "Ver/ Buscar libro";
            btnBuscarLibro.UseVisualStyleBackColor = true;
            btnBuscarLibro.Click += btnBuscarLibro_Click;
            // 
            // lblEstadoConexion
            // 
            lblEstadoConexion.AutoSize = true;
            lblEstadoConexion.Location = new Point(370, 55);
            lblEstadoConexion.Name = "lblEstadoConexion";
            lblEstadoConexion.Size = new Size(192, 32);
            lblEstadoConexion.TabIndex = 18;
            lblEstadoConexion.Text = "Estado Conexion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 970);
            Controls.Add(lblEstadoConexion);
            Controls.Add(btnBuscarLibro);
            Controls.Add(btnImportarCatalago);
            Controls.Add(btnProbarConexion);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblo DAM";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAutorLibro;
        private TextBox txtFechaPublicacion;
        private TextBox txtTituloLibro;
        private TextBox textAutorAdd;
        private TextBox txtIsb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Button btnGuardarAutor;
        private Panel panel2;
        private Button btnGuardarLibro;
        private Button btnProbarConexion;
        private Button btnImportarCatalago;
        private Button btnBuscarLibro;
        private Label lblEstadoConexion;
    }



}
