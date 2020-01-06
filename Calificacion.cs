using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tarea1TPD
{
    class Calificacion
    {
        public Calificacion(byte argCodigo,
            string argDescripcion,
            DateTime argFechaHoraRegistro,
            
            string argNombreBreve,
            string argNombreCompleto)
        {
            Codigo = argCodigo;
            Descripcion=argDescripcion;
            FechaHoraRegistro = argFechaHoraRegistro;
            
            NombreBreve = argNombreBreve;
            NombreCompleto = argNombreCompleto;
        }
        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private DateTime _FechaHoraRegistro;

        public DateTime FechaHoraRegistro
        {
            get { return _FechaHoraRegistro; }
            set { _FechaHoraRegistro = value; }
        }


        private string _NombreBreve;

        public string NombreBreve
        {
            get { return _NombreBreve; }
            set { _NombreBreve = value; }
        }

        private string _NombreCompleto;

        public string NombreCompleto
        {
            get { return _NombreCompleto; }
            set { _NombreCompleto = value; }
        }
        

        public void Insertar()
        {
            SqlConnection miConexion;
            miConexion = new SqlConnection("SERVER=WA37-2;DATABASE=Objetivo_Tarea;USER=sa;PWD=continental");
            SqlCommand elComando;
            elComando = new SqlCommand("usp_Insertar_Calificacion", miConexion);
            elComando.CommandType = System.Data.CommandType.StoredProcedure;

            elComando.Parameters.AddWithValue("@calDescripcion", Descripcion);
            elComando.Parameters.AddWithValue("@calNombreBreve", NombreBreve);
            elComando.Parameters.AddWithValue("@calNombreCompleto", NombreCompleto);

            //Paso 03: Ejecutar el comando
            miConexion.Open(); //Abrir la conexión
            elComando.ExecuteNonQuery(); //Ejecutar el comando
            miConexion.Close(); //Cerrar la conexión

        }
        public static List<Calificacion> Listar()
        {
            List<Calificacion> Milistado = new List<Calificacion>();

            SqlConnection miConexion;
            miConexion = new SqlConnection("SERVER=WA37-2;DATABASE=Objetivo_Tarea;USER=sa;PWD=continental");
            SqlCommand elComando;
            elComando = new SqlCommand("usp_listar_calificacion ", miConexion);
            elComando.CommandType = System.Data.CommandType.StoredProcedure;

            miConexion.Open();
            SqlDataReader LOSDATOS;
            LOSDATOS = elComando.ExecuteReader();

            while (LOSDATOS.Read() == true)
            {
                Calificacion filaDeBaseDeDatos;
                filaDeBaseDeDatos = new Calificacion(
                    Convert.ToByte(LOSDATOS["Codigo"]),
                    Convert.ToString(LOSDATOS["Descripcion"]),
                    Convert.ToDateTime(LOSDATOS["FechaHoraRegistro"]),
                    Convert.ToString(LOSDATOS["NombreBreve"]),
                    Convert.ToString(LOSDATOS["NombreCompleto"])
                    
                    );

                Milistado.Add(filaDeBaseDeDatos);
            }
            miConexion.Close();

            return Milistado;
        }


    }
}
