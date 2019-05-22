using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows;

namespace CapaNegocios
{
    public class co
    {
        Conexion objConexion = new Conexion();

        private int Doctor;
        private int Hospital;
        private string apellidos;
        private string especialidad;

        public void setDoctor(int Doctor_No)
        {
            Doctor = Doctor_No;
        }
        public void setHospital(int Hospital_Cod)
        {
            Hospital = Hospital_Cod;
        }
        public void setapellidos(string Apellido)
        {
            apellidos = Apellido;
        }
        public void setespecialidad(string Especialidad)
        {
            especialidad = Especialidad;
        }

        public int getDoctor_No()
        {
            return Doctor;
        }

        public int getHospital_Cod()
        {
            return Hospital;
        }
        public String getApellido()
        {
            return apellidos;
        }
        public String getEspecialidad()
        {
            return especialidad;
        }

        public void Insertar_Datos()
        {
            Conexion objConexion = new Conexion();
            try
            {
                objConexion.Conectar();
                string sentenciaInsert="Insert INTO Doctor(Doctor_No, Hospital_Cod, Apellido, Especialidad)values('"+ Doctor +"','" + Hospital + "','" +apellidos+"', '"+especialidad +"')";
                objConexion.setConsultaSql(sentenciaInsert);
                objConexion.InsertarDatos();
                objConexion.desconectar();
            }

        }
       
       

       

       


        







        
    }
}
