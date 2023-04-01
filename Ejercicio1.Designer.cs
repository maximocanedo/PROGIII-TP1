
namespace TrabajoPractico1
{
    partial class Ejercicio1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio1));
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.lbNombres2 = new System.Windows.Forms.ListBox();
            this.lbNombres1 = new System.Windows.Forms.ListBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverTodos.Location = new System.Drawing.Point(210, 250);
            this.btnMoverTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(43, 42);
            this.btnMoverTodos.TabIndex = 13;
            this.btnMoverTodos.Text = ">>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnMover
            // 
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.Location = new System.Drawing.Point(210, 187);
            this.btnMover.Margin = new System.Windows.Forms.Padding(2);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(43, 43);
            this.btnMover.TabIndex = 12;
            this.btnMover.Text = ">";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lbNombres2
            // 
            this.lbNombres2.FormattingEnabled = true;
            this.lbNombres2.Location = new System.Drawing.Point(291, 150);
            this.lbNombres2.Margin = new System.Windows.Forms.Padding(2);
            this.lbNombres2.Name = "lbNombres2";
            this.lbNombres2.Size = new System.Drawing.Size(135, 212);
            this.lbNombres2.TabIndex = 11;
            // 
            // lbNombres1
            // 
            this.lbNombres1.FormattingEnabled = true;
            this.lbNombres1.Location = new System.Drawing.Point(35, 150);
            this.lbNombres1.Margin = new System.Windows.Forms.Padding(2);
            this.lbNombres1.Name = "lbNombres1";
            this.lbNombres1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNombres1.Size = new System.Drawing.Size(135, 212);
            this.lbNombres1.TabIndex = 10;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(163, 100);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(169, 20);
            this.tbNombre.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(348, 97);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 24);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese su nombre:";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.lbNombres2);
            this.Controls.Add(this.lbNombres1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio1";
            this.Text = "Primer Ejercicio · TP Nº 1 PROG III";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoverTodos;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.ListBox lbNombres2;
        private System.Windows.Forms.ListBox lbNombres1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
    }
}