namespace BiblioDAM.Cliente
{
    partial class Fronted2
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
            txtBuscarByTitulo = new TextBox();
            txtBuscarByAutor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            btnVerTodos = new Button();
            dataGridTabla = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTabla).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarByTitulo
            // 
            txtBuscarByTitulo.Location = new Point(247, 41);
            txtBuscarByTitulo.Name = "txtBuscarByTitulo";
            txtBuscarByTitulo.Size = new Size(265, 39);
            txtBuscarByTitulo.TabIndex = 0;
            // 
            // txtBuscarByAutor
            // 
            txtBuscarByAutor.Location = new Point(777, 41);
            txtBuscarByAutor.Name = "txtBuscarByAutor";
            txtBuscarByAutor.Size = new Size(313, 39);
            txtBuscarByAutor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 48);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 2;
            label1.Text = "Buscar por titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 44);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 3;
            label2.Text = "Buscar por Autor";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1125, 41);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(161, 46);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnVerTodos
            // 
            btnVerTodos.Location = new Point(1325, 41);
            btnVerTodos.Name = "btnVerTodos";
            btnVerTodos.Size = new Size(150, 46);
            btnVerTodos.TabIndex = 5;
            btnVerTodos.Text = "Ver Todos";
            btnVerTodos.UseVisualStyleBackColor = true;
            btnVerTodos.Click += button2_Click;
            // 
            // dataGridTabla
            // 
            dataGridTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTabla.Location = new Point(42, 127);
            dataGridTabla.Name = "dataGridTabla";
            dataGridTabla.RowHeadersWidth = 82;
            dataGridTabla.Size = new Size(1446, 525);
            dataGridTabla.TabIndex = 6;
            dataGridTabla.SelectionChanged += dataGridTabla_SelectionChanged;
            // 
            // button1
            // 
            button1.Location = new Point(52, 674);
            button1.Name = "button1";
            button1.Size = new Size(358, 46);
            button1.TabIndex = 7;
            button1.Text = "Eliminar Libro Seleccionado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Fronted2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 750);
            Controls.Add(button1);
            Controls.Add(dataGridTabla);
            Controls.Add(btnVerTodos);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscarByAutor);
            Controls.Add(txtBuscarByTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Fronted2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblo DAM";
            FormClosed += Fronted2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarByTitulo;
        private TextBox txtBuscarByAutor;
        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private Button btnVerTodos;
        private DataGridView dataGridTabla;
        private Button button1;
    }

       
    
}