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
            SqlCommand comando = new SqlCommand("SELECT * FROM Muestras1", conex.conn);
            //Ejecutamos el comando
            SqlDataReader reader = comando.ExecuteReader();
            //Recorremos el resultado del comando
            while (reader.Read())
            {
                //Creamos un objeto de tipo Muestras
                Muestras muestra = new Muestras();
                //Asignamos los valores de la base de datos al objeto
                muestra.id = (reader["id"].ToString());
                muestra.nombre = reader["nombre"].ToString();
                muestra.clasifico = reader["clasifico"].ToString();
                muestra.textura = reader["textura"].ToString();
                muestra.fecha = Convert.ToDateTime(reader["fecha"]);
                muestra.Quartz = Convert.ToInt32(reader["Quartz"]);
                muestra.Feldspar = Convert.ToInt32(reader["Feldspar"]);
                muestra.Plagioclase = Convert.ToInt32(reader["Plagioclase"]);
                muestra.Mafic = Convert.ToInt32(reader["Mafic"]);
                muestra.caracteristicas = reader["caracteristicas"].ToString();
                //Agregamos el objeto a la lista de muestras
                muestras.Add(muestra);
            }
            //Cerramos la conexion
            conex.conn.Close();
            //Retornamos la lista de muestras
            return muestras;
        }
        //metodo para obtener las muestras por nombre o id o textura con una solo variable
        public List<Muestras> getMuestras(string filtro)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para obtener las muestras
            SqlCommand comando = new SqlCommand("SELECT * FROM Muestras1 WHERE nombre LIKE @nombre OR id LIKE @nombre OR textura LIKE @nombre", conex.conn);
            //Agregamos el parametro nombre al comando
            comando.Parameters.AddWithValue("@nombre", "%" + filtro + "%");
            //Ejecutamos el comando
            SqlDataReader reader = comando.ExecuteReader();
            //Recorremos el resultado del comando
            while (reader.Read())
            {
                //Creamos un objeto de tipo Muestras
                Muestras muestra = new Muestras();
                //Asignamos los valores de la base de datos al objeto
                muestra.id = (reader["id"].ToString());
                muestra.nombre = reader["nombre"].ToString();
                muestra.clasifico = reader["clasifico"].ToString();
                muestra.textura = reader["textura"].ToString();
                muestra.fecha = Convert.ToDateTime(reader["fecha"]);
                muestra.Quartz = Convert.ToInt32(reader["Quartz"]);
                muestra.Feldspar = Convert.ToInt32(reader["Feldspar"]);
                muestra.Plagioclase = Convert.ToInt32(reader["Plagioclase"]);
                muestra.Mafic = Convert.ToInt32(reader["Mafic"]);
                muestra.caracteristicas = reader["caracteristicas"].ToString();
                //Agregamos el objeto a la lista de muestras
                muestras.Add(muestra);
            }
            //Cerramos la conexion
            conex.conn.Close();
            //Retornamos la lista de muestras
            return muestras;
        }


        

        //Metodo para insertar una muestra en la base de datos
        public void insertarMuestra(Muestras muestra)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para insertar la muestra
            SqlCommand comando = new SqlCommand("INSERT INTO Muestras1 (id,nombre, clasifico, textura, fecha, Quartz, Feldspar, Plagioclase, Mafic, caracteristicas) VALUES (@id,@nombre, @tipo, @textura, @fecha, @Quartz, @Feldspar, @Plagioclase, @Mafic, @caracteristicas)", conex.conn);
            //Agregamos los parametros al comando
            comando.Parameters.AddWithValue("@id", muestra.id);
            comando.Parameters.AddWithValue("@nombre", muestra.nombre);
            comando.Parameters.AddWithValue("@tipo", muestra.clasifico);
            comando.Parameters.AddWithValue("@textura", muestra.textura);
            comando.Parameters.AddWithValue("@fecha", muestra.fecha);
            comando.Parameters.AddWithValue("@Quartz", muestra.Quartz);
            comando.Parameters.AddWithValue("@Feldspar", muestra.Feldspar);
            comando.Parameters.AddWithValue("@Plagioclase", muestra.Plagioclase);
            comando.Parameters.AddWithValue("@Mafic", muestra.Mafic);
            comando.Parameters.AddWithValue("@caracteristicas", muestra.caracteristicas);
            //Ejecutamos el comando
            comando.ExecuteNonQuery();
            //Cerramos la conexion
            conex.conn.Close();
        }

        //Metodo para actualizar una muestra en la base de datos
        public void actualizarMuestra(Muestras muestra, string id)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para actualizar la muestra
            SqlCommand comando = new SqlCommand("UPDATE Muestras1 SET id=@id1,nombre = @nombre, clasifico = @tipo, textura = @textura, fecha = @fecha, Quartz = @Quartz, Feldspar = @Feldspar, Plagioclase = @Plagioclase, Mafic = @Mafic, caracteristicas = @caracteristicas WHERE id = @id", conex.conn);
            //Agregamos los parametros al comando
            comando.Parameters.AddWithValue("@id1", muestra.id);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", muestra.nombre);
            comando.Parameters.AddWithValue("@tipo", muestra.clasifico);
            comando.Parameters.AddWithValue("@textura", muestra.textura);
            comando.Parameters.AddWithValue("@fecha", muestra.fecha);
            comando.Parameters.AddWithValue("@Quartz", muestra.Quartz);
            comando.Parameters.AddWithValue("@Feldspar", muestra.Feldspar);
            comando.Parameters.AddWithValue("@Plagioclase", muestra.Plagioclase);
            comando.Parameters.AddWithValue("@Mafic", muestra.Mafic);
            comando.Parameters.AddWithValue("@caracteristicas", muestra.caracteristicas);
            //Ejecutamos el comando
            comando.ExecuteNonQuery();
            //Cerramos la conexion
            conex.conn.Close();
        }

        //Metodo para eliminar una muestra de la base de datos
        public void eliminarMuestra(string id)
        {
            //Abrimos la conexion
            conex.conn.Open();
            //Creamos el comando para eliminar la muestra
            SqlCommand comando = new SqlCommand("DELETE FROM Muestras1 WHERE id = @id", conex.conn);
            //Agregamos el parametro id al comando
            comando.Parameters.AddWithValue("@id", id);
            //Ejecutamos el comando
            comando.ExecuteNonQuery();
            //Cerramos la conexion
            conex.conn.Close();
        }

        


       
    }
}
