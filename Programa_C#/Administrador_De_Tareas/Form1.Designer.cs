namespace Simulacion_Procesos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizarprocesosenejecucion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_Proceso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LblNombreCPU = new MetroFramework.Controls.MetroLabel();
            this.ProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.ProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.LblNombreRam = new MetroFramework.Controls.MetroLabel();
            this.LblPorCPU = new MetroFramework.Controls.MetroLabel();
            this.LblPorRAM = new MetroFramework.Controls.MetroLabel();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.lbl_Contador);
            this.panel2.Controls.Add(this.btnActualizarprocesosenejecucion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 435);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnActualizarprocesosenejecucion
            // 
            this.btnActualizarprocesosenejecucion.BackColor = System.Drawing.Color.White;
            this.btnActualizarprocesosenejecucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarprocesosenejecucion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarprocesosenejecucion.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarprocesosenejecucion.Location = new System.Drawing.Point(3, 25);
            this.btnActualizarprocesosenejecucion.Name = "btnActualizarprocesosenejecucion";
            this.btnActualizarprocesosenejecucion.Size = new System.Drawing.Size(216, 69);
            this.btnActualizarprocesosenejecucion.TabIndex = 0;
            this.btnActualizarprocesosenejecucion.Text = "Actualizar Tabla";
            this.btnActualizarprocesosenejecucion.UseVisualStyleBackColor = false;
            this.btnActualizarprocesosenejecucion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // dgv_Proceso
            // 
            this.dgv_Proceso.AllowUserToAddRows = false;
            this.dgv_Proceso.AllowUserToDeleteRows = false;
            this.dgv_Proceso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgv_Proceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Proceso.Location = new System.Drawing.Point(271, 61);
            this.dgv_Proceso.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Proceso.Name = "dgv_Proceso";
            this.dgv_Proceso.ReadOnly = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dgv_Proceso.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Proceso.RowTemplate.Height = 24;
            this.dgv_Proceso.Size = new System.Drawing.Size(708, 342);
            this.dgv_Proceso.TabIndex = 19;
            this.dgv_Proceso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Proceso_CellContentClick);
            this.dgv_Proceso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Proceso_MouseClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero del Proceso";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Procesos";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prioridad Proceso";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id Proceso";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Memoria Fisica";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Memoria Virtual";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblNombreCPU
            // 
            this.LblNombreCPU.AutoSize = true;
            this.LblNombreCPU.Location = new System.Drawing.Point(321, 165);
            this.LblNombreCPU.Name = "LblNombreCPU";
            this.LblNombreCPU.Size = new System.Drawing.Size(35, 19);
            this.LblNombreCPU.TabIndex = 20;
            this.LblNombreCPU.Text = "CPU";
            this.LblNombreCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblNombreCPU.Visible = false;
            this.LblNombreCPU.Click += new System.EventHandler(this.LblNombreCPU_Click);
            // 
            // ProgressBarCPU
            // 
            this.ProgressBarCPU.Location = new System.Drawing.Point(395, 165);
            this.ProgressBarCPU.Name = "ProgressBarCPU";
            this.ProgressBarCPU.Size = new System.Drawing.Size(416, 23);
            this.ProgressBarCPU.TabIndex = 21;
            this.ProgressBarCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressBarCPU.Visible = false;
            this.ProgressBarCPU.Click += new System.EventHandler(this.ProgressBarCPU_Click);
            // 
            // ProgressBarRAM
            // 
            this.ProgressBarRAM.Location = new System.Drawing.Point(395, 219);
            this.ProgressBarRAM.Name = "ProgressBarRAM";
            this.ProgressBarRAM.Size = new System.Drawing.Size(416, 23);
            this.ProgressBarRAM.TabIndex = 23;
            this.ProgressBarRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgressBarRAM.Visible = false;
            this.ProgressBarRAM.Click += new System.EventHandler(this.ProgressBarRAM_Click);
            // 
            // LblNombreRam
            // 
            this.LblNombreRam.AutoSize = true;
            this.LblNombreRam.Location = new System.Drawing.Point(321, 219);
            this.LblNombreRam.Name = "LblNombreRam";
            this.LblNombreRam.Size = new System.Drawing.Size(38, 19);
            this.LblNombreRam.TabIndex = 22;
            this.LblNombreRam.Text = "RAM";
            this.LblNombreRam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblNombreRam.Visible = false;
            this.LblNombreRam.Click += new System.EventHandler(this.LblNombreRam_Click);
            // 
            // LblPorCPU
            // 
            this.LblPorCPU.AutoSize = true;
            this.LblPorCPU.Location = new System.Drawing.Point(837, 169);
            this.LblPorCPU.Name = "LblPorCPU";
            this.LblPorCPU.Size = new System.Drawing.Size(31, 19);
            this.LblPorCPU.TabIndex = 24;
            this.LblPorCPU.Text = "0 %";
            this.LblPorCPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblPorCPU.Visible = false;
            this.LblPorCPU.Click += new System.EventHandler(this.LblPorCPU_Click);
            // 
            // LblPorRAM
            // 
            this.LblPorRAM.AutoSize = true;
            this.LblPorRAM.Location = new System.Drawing.Point(837, 219);
            this.LblPorRAM.Name = "LblPorRAM";
            this.LblPorRAM.Size = new System.Drawing.Size(31, 19);
            this.LblPorRAM.TabIndex = 25;
            this.LblPorRAM.Text = "0 %";
            this.LblPorRAM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LblPorRAM.Visible = false;
            this.LblPorRAM.Click += new System.EventHandler(this.LblPorRAM_Click);
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Location = new System.Drawing.Point(23, 395);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(95, 13);
            this.lbl_Contador.TabIndex = 1;
            this.lbl_Contador.Text = "Precesos Actuales";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 515);
            this.Controls.Add(this.LblPorRAM);
            this.Controls.Add(this.LblPorCPU);
            this.Controls.Add(this.ProgressBarRAM);
            this.Controls.Add(this.LblNombreRam);
            this.Controls.Add(this.ProgressBarCPU);
            this.Controls.Add(this.LblNombreCPU);
            this.Controls.Add(this.dgv_Proceso);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "                              Administrador de Procesos";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_Proceso;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel LblNombreCPU;
        private MetroFramework.Controls.MetroProgressBar ProgressBarCPU;
        private MetroFramework.Controls.MetroProgressBar ProgressBarRAM;
        private MetroFramework.Controls.MetroLabel LblNombreRam;
        private MetroFramework.Controls.MetroLabel LblPorCPU;
        private MetroFramework.Controls.MetroLabel LblPorRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnActualizarprocesosenejecucion;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Label lbl_Contador;
    }
}

