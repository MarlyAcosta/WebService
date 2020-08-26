namespace Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Primero = new System.Windows.Forms.Button();
            this.Anterior = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Ultimo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.excel = new System.Windows.Forms.Button();
            this.excelP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(32, 28);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 569);
            this.dataGridView1.TabIndex = 0;
            // 
            // Primero
            // 
            this.Primero.AutoSize = true;
            this.Primero.BackColor = System.Drawing.Color.MidnightBlue;
            this.Primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Primero.ForeColor = System.Drawing.Color.White;
            this.Primero.Location = new System.Drawing.Point(32, 623);
            this.Primero.Name = "Primero";
            this.Primero.Size = new System.Drawing.Size(75, 25);
            this.Primero.TabIndex = 1;
            this.Primero.Text = "Primero";
            this.Primero.UseVisualStyleBackColor = false;
            this.Primero.Click += new System.EventHandler(this.Primero_Click);
            // 
            // Anterior
            // 
            this.Anterior.BackColor = System.Drawing.Color.MidnightBlue;
            this.Anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anterior.ForeColor = System.Drawing.Color.White;
            this.Anterior.Location = new System.Drawing.Point(137, 623);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(75, 23);
            this.Anterior.TabIndex = 2;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = false;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.BackColor = System.Drawing.Color.MidnightBlue;
            this.Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Siguiente.ForeColor = System.Drawing.Color.White;
            this.Siguiente.Location = new System.Drawing.Point(239, 623);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 3;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Ultimo
            // 
            this.Ultimo.BackColor = System.Drawing.Color.MidnightBlue;
            this.Ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ultimo.ForeColor = System.Drawing.Color.White;
            this.Ultimo.Location = new System.Drawing.Point(350, 623);
            this.Ultimo.Name = "Ultimo";
            this.Ultimo.Size = new System.Drawing.Size(75, 23);
            this.Ultimo.TabIndex = 4;
            this.Ultimo.Text = "Ultimo";
            this.Ultimo.UseVisualStyleBackColor = false;
            this.Ultimo.Click += new System.EventHandler(this.Ultimo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.DarkRed;
            this.excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excel.ForeColor = System.Drawing.Color.White;
            this.excel.Location = new System.Drawing.Point(906, 618);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(154, 33);
            this.excel.TabIndex = 6;
            this.excel.Text = "Exportar todo a excel";
            this.excel.UseVisualStyleBackColor = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // excelP
            // 
            this.excelP.BackColor = System.Drawing.Color.DarkOrange;
            this.excelP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelP.ForeColor = System.Drawing.Color.White;
            this.excelP.Location = new System.Drawing.Point(723, 618);
            this.excelP.Name = "excelP";
            this.excelP.Size = new System.Drawing.Size(149, 33);
            this.excelP.TabIndex = 7;
            this.excelP.Text = "Exportar pagina a excel";
            this.excelP.UseVisualStyleBackColor = false;
            this.excelP.Click += new System.EventHandler(this.excelP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1088, 663);
            this.Controls.Add(this.excelP);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ultimo);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.Primero);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Primero;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Ultimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button excelP;
    }
}

