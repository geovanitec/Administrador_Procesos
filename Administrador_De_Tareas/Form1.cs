using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace Simulacion_Procesos
{
    public partial class Diseño : MetroFramework.Forms.MetroForm
    {
       
        string Str_Obt_Proc;
        public Diseño()
        {
            InitializeComponent();
          
            ActualizarTabla_Procesos();
            timer1.Enabled = true;
            
        }

        //Funcion que permite actualizar la tabla
        private void ActualizarTabla_Procesos()
        {
            
            dgv_Proceso.Rows.Clear();
            
            dgv_Proceso.Columns[0].Name = "Numero de Proceso";
            dgv_Proceso.Columns[1].Name = "Procesos";
            dgv_Proceso.Columns[2].Name = "Prioridad Proceso";
            dgv_Proceso.Columns[3].Name = "Id Del Proceso";
            dgv_Proceso.Columns[4].Name = "Memoria Fisica";
            dgv_Proceso.Columns[5].Name = "Memoria Virtual";
           

           
            dgv_Proceso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dgv_Proceso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgv_Proceso.MultiSelect = false;

            
            int Int_Cant_Proc = 1;


            foreach (Process Proc_Proceso in Process.GetProcesses())
            {
               
                dgv_Proceso.Rows.Add(Int_Cant_Proc, Proc_Proceso.ProcessName, Proc_Proceso.BasePriority, Proc_Proceso.Id, Proc_Proceso.WorkingSet64,
                    Proc_Proceso.VirtualMemorySize64);
               
                Int_Cant_Proc += 1;
            }
           
           lbl_Contador.Text = "Procesos Actuales: " + (Int_Cant_Proc - 1);   


        }


        // Funcion que permite colocar el color a cada una de las columnas y el color de la letra
        private void dgv_Proceso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Proceso.Columns[e.ColumnIndex].Name == "Procesos")
            {

                e.CellStyle.BackColor = Color.Beige;
                e.CellStyle.ForeColor = Color.Black;
            }
            if (dgv_Proceso.Columns[e.ColumnIndex].Name == "Memoria Virtual")
            {

                e.CellStyle.BackColor = Color.Beige;
                e.CellStyle.ForeColor = Color.Black;
            }
            if (dgv_Proceso.Columns[e.ColumnIndex].Name == "Id Del Proceso")
            {

                e.CellStyle.BackColor = Color.Beige;
                e.CellStyle.ForeColor = Color.Black;
            }
            if (dgv_Proceso.Columns[e.ColumnIndex].Name == "Numero de Proceso")
            {

                e.CellStyle.BackColor = Color.Beige;
                e.CellStyle.ForeColor = Color.Black;
            }
            if (dgv_Proceso.Columns[e.ColumnIndex].Name == "Prioridad Proceso")
            {

                e.CellStyle.BackColor = Color.Beige;
                e.CellStyle.ForeColor = Color.Black;
            }
            if (dgv_Proceso.Columns[e.ColumnIndex].Name == "Memoria Fisica")
            {

                e.CellStyle.BackColor = Color.Beige;
                e.CellStyle.ForeColor = Color.Black;


            }
        }


        private void BtnActualizarProcesos_Click(object sender, EventArgs e){
           
            Grafico.Visible = false;
            dgv_Proceso.Visible = true;

           
            ActualizarTabla_Procesos(); 
        }
        
           

        private void dgv_Proceso_MouseClick_1(object sender, MouseEventArgs e)
        {
         
            Str_Obt_Proc = dgv_Proceso.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e){
            
            timer.Start();
        }
        

        private void Timer_Tick(object sender, EventArgs e){
          
            float fCPU = pCPU.NextValue();
            float fRAM = pRAM.NextValue();
        }

       

        private void dgv_Proceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Grafico.Visible = false;
            dgv_Proceso.Visible = true;

            
            ActualizarTabla_Procesos();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {            
            Grafico.Visible = false;
            dgv_Proceso.Visible = true;

            try
            {
                
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == Str_Obt_Proc)
                    {
                        proceso.Kill();
                        ActualizarTabla_Procesos();
                    }
                }

            }
            
            catch (Exception x)
            {
                MessageBox.Show("No se ha seleccionado ningun proceso para detener." + x, "Error al Detener Proceso", MessageBoxButtons.OK);
            }


        }

        private void lbl_Contador_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
