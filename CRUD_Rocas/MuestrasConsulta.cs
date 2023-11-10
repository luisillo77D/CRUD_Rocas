using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Rocas
{
    internal class MuestrasConsulta
    {
        private Conexion conex;
        private List<Muestras> muestras;

        //Constructor de la clase para inicializar la conexion y la lista de muestras
        public MuestrasConsulta()
        {
            conex = new Conexion();
            muestras = new List<Muestras>();
        }

        //Metodo para obtener todas las muestras de la base de datos
        public List<Muestras> getMuestras()
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para obtener todas las muestras
            SqlCommand comando = new SqlCommand("SELECT * FROM Muestras", conex.conn);
            //Ejecutamos el comando
            SqlDataReader reader = comando.ExecuteReader();
            //Recorremos el resultado del comando
            while (reader.Read())
            {
                //Creamos un objeto de tipo Muestras
                Muestras muestra = new Muestras();
                //Asignamos los valores de la base de datos al objeto
                muestra.id = Convert.ToInt32(reader["id"]);
                muestra.nombre = reader["nombre"].ToString();
                muestra.tipo = reader["tipo"].ToString();
                muestra.textura = reader["textura"].ToString();
                muestra.fecha = Convert.ToDateTime(reader["fecha"]);
                muestra.Quartz = Convert.ToInt32(reader["Quartz"]);
                muestra.AlkaliFeldspar = Convert.ToInt32(reader["AlkaliFeldspar"]);
                muestra.Plagioclase = Convert.ToInt32(reader["Plagioclase"]);
                muestra.feldspar = Convert.ToInt32(reader["feldspar"]);
                muestra.caracteristicas = reader["caracteristicas"].ToString();
                //Agregamos el objeto a la lista de muestras
                muestras.Add(muestra);
            }
            //Cerramos la conexion
            conex.conn.Close();
            //Retornamos la lista de muestras
            return muestras;
        }

        //Metodo para obtener una muestra por su id
        public Muestras getMuestra(int id)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para obtener la muestra
            SqlCommand comando = new SqlCommand("SELECT * FROM Muestras WHERE id = @id", conex.conn);
            //Agregamos el parametro id al comando
            comando.Parameters.AddWithValue("@id", id);
            //Ejecutamos el comando
            SqlDataReader reader = comando.ExecuteReader();
            //Creamos un objeto de tipo Muestras
            Muestras muestra = new Muestras();
            //Recorremos el resultado del comando
            while (reader.Read())
            {
                //Asignamos los valores de la base de datos al objeto
                muestra.id = Convert.ToInt32(reader["id"]);
                muestra.nombre = reader["nombre"].ToString();
                muestra.tipo = reader["tipo"].ToString();
                muestra.textura = reader["textura"].ToString();
                muestra.fecha = Convert.ToDateTime(reader["fecha"]);
                muestra.Quartz = Convert.ToInt32(reader["Quartz"]);
                muestra.AlkaliFeldspar = Convert.ToInt32(reader["AlkaliFeldspar"]);
                muestra.Plagioclase = Convert.ToInt32(reader["Plagioclase"]);
                muestra.feldspar = Convert.ToInt32(reader["feldspar"]);
                muestra.caracteristicas = reader["caracteristicas"].ToString();
            }
            //Cerramos la conexion
            conex.conn.Close();
            //Retornamos la muestra
            return muestra;
        }

        //Metodo para insertar una muestra en la base de datos
        public void insertarMuestra(Muestras muestra)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para insertar la muestra
            SqlCommand comando = new SqlCommand("INSERT INTO Muestras (nombre, tipo, textura, fecha, Quartz, AlkaliFeldspar, Plagioclase, feldspar, caracteristicas) VALUES (@nombre, @tipo, @textura, @fecha, @Quartz, @AlkaliFeldspar, @Plagioclase, @feldspar, @caracteristicas)", conex.conn);
            //Agregamos los parametros al comando
            comando.Parameters.AddWithValue("@nombre", muestra.nombre);
            comando.Parameters.AddWithValue("@tipo", muestra.tipo);
            comando.Parameters.AddWithValue("@textura", muestra.textura);
            comando.Parameters.AddWithValue("@fecha", muestra.fecha);
            comando.Parameters.AddWithValue("@Quartz", muestra.Quartz);
            comando.Parameters.AddWithValue("@AlkaliFeldspar", muestra.AlkaliFeldspar);
            comando.Parameters.AddWithValue("@Plagioclase", muestra.Plagioclase);
            comando.Parameters.AddWithValue("@feldspar", muestra.feldspar);
            comando.Parameters.AddWithValue("@caracteristicas", muestra.caracteristicas);
            //Ejecutamos el comando
            comando.ExecuteNonQuery();
            //Cerramos la conexion
            conex.conn.Close();
        }

        //Metodo para actualizar una muestra en la base de datos
        public void actualizarMuestra(Muestras muestra)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para actualizar la muestra
            SqlCommand comando = new SqlCommand("UPDATE Muestras SET nombre = @nombre, tipo = @tipo, textura = @textura, fecha = @fecha, Quartz = @Quartz, AlkaliFeldspar = @AlkaliFeldspar, Plagioclase = @Plagioclase, feldspar = @feldspar, caracteristicas = @caracteristicas WHERE id = @id", conex.conn);
            //Agregamos los parametros al comando
            comando.Parameters.AddWithValue("@id", muestra.id);
            comando.Parameters.AddWithValue("@nombre", muestra.nombre);
            comando.Parameters.AddWithValue("@tipo", muestra.tipo);
            comando.Parameters.AddWithValue("@textura", muestra.textura);
            comando.Parameters.AddWithValue("@fecha", muestra.fecha);
            comando.Parameters.AddWithValue("@Quartz", muestra.Quartz);
            comando.Parameters.AddWithValue("@AlkaliFeldspar", muestra.AlkaliFeldspar);
            comando.Parameters.AddWithValue("@Plagioclase", muestra.Plagioclase);
            comando.Parameters.AddWithValue("@feldspar", muestra.feldspar);
            comando.Parameters.AddWithValue("@caracteristicas", muestra.caracteristicas);
            //Ejecutamos el comando
            comando.ExecuteNonQuery();
            //Cerramos la conexion
            conex.conn.Close();
        }

        //Metodo para eliminar una muestra de la base de datos
        public void eliminarMuestra(int id)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para eliminar la muestra
            SqlCommand comando = new SqlCommand("DELETE FROM Muestras WHERE id = @id", conex.conn);
            //Agregamos el parametro id al comando
            comando.Parameters.AddWithValue("@id", id);
            //Ejecutamos el comando
            comando.ExecuteNonQuery();
            //Cerramos la conexion
            conex.conn.Close();
        }

        //Metodo para obtener el QAP de una muestra
        public List<int> getQAP(int id)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para obtener el QAP de la muestra
            SqlCommand comando = new SqlCommand("SELECT Quartz, AlkaliFeldspar, Plagioclase FROM Muestras WHERE id = @id", conex.conn);
            //Agregamos el parametro id al comando
            comando.Parameters.AddWithValue("@id", id);
            //Ejecutamos el comando
            SqlDataReader reader = comando.ExecuteReader();
            //Creamos una lista de enteros para guardar el QAP
            List<int> QAP = new List<int>();
            //Recorremos el resultado del comando
            while (reader.Read())
            {
                //Agregamos los valores a la lista
                QAP.Add(Convert.ToInt32(reader["Quartz"]));
                QAP.Add(Convert.ToInt32(reader["AlkaliFeldspar"]));
                QAP.Add(Convert.ToInt32(reader["Plagioclase"]));
            }
            //Cerramos la conexion
            conex.conn.Close();
            //Retornamos la lista de QAP
            return QAP;
        }


       
    }
}
