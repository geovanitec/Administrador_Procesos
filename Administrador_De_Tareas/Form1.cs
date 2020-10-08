﻿using System;
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
        //Declaracion de variable string para obtener el nombre del proceso en la tabla para su eliminacion
        string Str_Obt_Proc;
        public Diseño()
        {
            InitializeComponent();
            //Activacion del timer que actualizara la tabla
            ActualizarTabla_Procesos();
            timer1.Enabled = true;
            
        }

        private void ActualizarTabla_Procesos()
        {
            //limpieza del datagrid
            dgv_Proceso.Rows.Clear();
            //creacion columnas con sus respectivos nombres
            dgv_Proceso.Columns[0].Name = "Numero de Proceso";
            dgv_Proceso.Columns[1].Name = "Procesos";
            dgv_Proceso.Columns[2].Name = "Prioridad Proceso";
            dgv_Proceso.Columns[3].Name = "Id Del Proceso";
            dgv_Proceso.Columns[4].Name = "Memoria Fisica";
            dgv_Proceso.Columns[5].Name = "Memoria Virtual";
           

            //Propiedad para autoajustar el tamaño de las celdas segun su contenido
            dgv_Proceso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Propiedad para que el usuario seleccione solamente filas en la tabla y no celdas sueltas
            dgv_Proceso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Propiedad para que el usuario no pueda seleccionar mas de una fila
            dgv_Proceso.MultiSelect = false;

            //Declaracion de la variable que sera un contador para el total de procesos
            int Int_Cant_Proc = 1;


            foreach (Process Proc_Proceso in Process.GetProcesses())
            {
                //Ingreso de los datos en el datagrid
                dgv_Proceso.Rows.Add(Int_Cant_Proc, Proc_Proceso.ProcessName, Proc_Proceso.BasePriority, Proc_Proceso.Id, Proc_Proceso.WorkingSet64,
                    Proc_Proceso.VirtualMemorySize64);
                //aumento en 1 de la variable
                Int_Cant_Proc += 1;
            }
            //El label muestra la cantidad de procesos actuales
           lbl_Contador.Text = "Procesos Actuales: " + (Int_Cant_Proc - 1);    //  cant de procesos   


        } //fin metodo ActualizarTabla


        //Boton Actualizar
       private void BtnActualizarProcesos_Click(object sender, EventArgs e){
           
            Grafico.Visible = false;
            dgv_Proceso.Visible = true;

            //Llamado al proceso para actualizar la tabla
            ActualizarTabla_Procesos(); 
        }
        
           

        private void dgv_Proceso_MouseClick_1(object sender, MouseEventArgs e)
        {
            //La variable obtiene el Nombre del Proceso de la Tabla al hacerle clic
            Str_Obt_Proc = dgv_Proceso.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e){
            //Evento que maneja el contador de rendimiento de la RAM y del CPU
            timer.Start();
        }
        

        private void Timer_Tick(object sender, EventArgs e){
            //Asignamos un float a un PerformanceCounter que ya tiene asignado el contador de rendimiento de la RAM y del CPU
            float fCPU = pCPU.NextValue();
            float fRAM = pRAM.NextValue();
        }

        
        /*private void Grafico_Click(object sender, EventArgs e)
        {

        }*/

        private void dgv_Proceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Grafico.Visible = false;
            dgv_Proceso.Visible = true;

            //Llamado al proceso para actualizar la tabla
            ActualizarTabla_Procesos();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {            
            Grafico.Visible = false;
            dgv_Proceso.Visible = true;

            try
            {
                //Por cada proceso que haya se comparara su nombre con el nombre del proceso que se desea eliminar.
                foreach (Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == Str_Obt_Proc)
                    {
                        proceso.Kill();//Se elimina el proceso
                        ActualizarTabla_Procesos();//Se llama al proceso para actualizar la tabla automaticamente
                    }
                }

            }
            //En caso no se seleccione un proceso mostrara el siguiente mensaje.
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
