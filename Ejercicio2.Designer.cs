
namespace TrabajoPractico1
{
    partial class Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbIngresoDatos.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbIngresoDatos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbElementos, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbIngresoDatos
            // 
            this.gbIngresoDatos.Controls.Add(this.tableLayoutPanel3);
            this.gbIngresoDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIngresoDatos.Location = new System.Drawing.Point(12, 12);
            this.gbIngresoDatos.Margin = new System.Windows.Forms.Padding(12);
            this.gbIngresoDatos.Name = "gbIngresoDatos";
            this.gbIngresoDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbIngresoDatos.Size = new System.Drawing.Size(264, 377);
            this.gbIngresoDatos.TabIndex = 0;
            this.gbIngresoDatos.TabStop = false;
            this.gbIngresoDatos.Text = "Ingreso de datos";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbNombre, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbApellido, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbNombre, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbApellido, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregar, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(256, 348);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(4, 44);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(4, 137);
            this.lbApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(65, 20);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido";
            // 
            // tbNombre
            // 
            this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombre.Location = new System.Drawing.Point(4, 78);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(248, 26);
            this.tbNombre.TabIndex = 2;
            // 
            // tbApellido
            // 
            this.tbApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApellido.Location = new System.Drawing.Point(4, 171);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(248, 26);
            this.tbApellido.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(72, 231);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.tableLayoutPanel2);
            this.gbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbElementos.Location = new System.Drawing.Point(300, 12);
            this.gbElementos.Margin = new System.Windows.Forms.Padding(12);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbElementos.Size = new System.Drawing.Size(264, 377);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnBorrar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbNombres, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 348);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.Location = new System.Drawing.Point(72, 303);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 35);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbNombres
            // 
            this.lbNombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 20;
            this.lbNombres.Location = new System.Drawing.Point(4, 5);
            this.lbNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(248, 283);
            this.lbNombres.Sorted = true;
            this.lbNombres.TabIndex = 1;
            this.lbNombres.SelectedIndexChanged += new System.EventHandler(this.lbNombres_SelectedIndexChanged);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 401);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(589, 431);
            this.Name = "Ejercicio2";
            this.Text = "Segundo Ejercicio · TP Nº 1 PROG III";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbIngresoDatos.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbIngresoDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lbNombres;
    }
}