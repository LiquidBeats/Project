using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloRiesgosSG_SST.Entidades.Proveedores;
using ModuloRiesgosSG_SST.Datos.Conexion;
using System.Data.SqlClient;
using System.Data;

namespace ModuloRiesgosSG_SST.Datos.Proveedores
{
    class DClEvaluacion
    {
        DClConexion objConexion = new DClConexion();
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmdEvaluacion;
        SqlDataAdapter adapEvaluacion;

        public int mtdRegistroEvaluacion(EClEvaluacion objEValuacion)
        {
            string sql = "Insert into Evaluacion (Nombre,FechaInicio,FechaFin,FechaCiclo,Puntaje,Descripcion) Values ('" + objEValuacion.Nombre + "','" + objEValuacion.FechaInicio + "','" + objEValuacion.FechaFin + "','" + objEValuacion.FechaCiclo + "'," + objEValuacion.Puntaje + ",'" + objEValuacion.Descripcion + "')";

            conexion = objConexion.mtdConexion();
            cmdEvaluacion = new SqlCommand(sql, conexion);
            conexion.Open();
            int Registro = cmdEvaluacion.ExecuteNonQuery();
            conexion.Close();

            return Registro;

        }

        public List<EClEvaluacion> mtdListarEvaluaciones(string nombre = "", string puntaje = "")
        {
            string sql = "";

            if (nombre != "")
            {
                sql = "Select* From Evaluacion Where Nombre='" + nombre + "'";
            }
            else if (puntaje != "")
            {
                sql = "Select* From Evaluacion Where Puntaje=" + puntaje + "";
            }
            else
            {
                sql = "Select* From Evaluacion";
            }

            DataTable tblEvaluacion = new DataTable();

            conexion = objConexion.mtdConexion();
            adapEvaluacion = new SqlDataAdapter(sql, conexion);
            conexion.Open();
            adapEvaluacion.Fill(tblEvaluacion);
            conexion.Close();

            List<EClEvaluacion> ListaEvaluacion = new List<EClEvaluacion>();
            for (int x = 0; x < tblEvaluacion.Rows.Count; x++)
            {
                EClEvaluacion objEvaluacion = new EClEvaluacion();
                objEvaluacion.Nombre = tblEvaluacion.Rows[x]["Nombre"].ToString();
                objEvaluacion.FechaInicio = Convert.ToDateTime(tblEvaluacion.Rows[x]["FechaInicio"]);
                objEvaluacion.FechaFin = Convert.ToDateTime(tblEvaluacion.Rows[x]["FechaFin"]);
                objEvaluacion.FechaCiclo = Convert.ToDateTime(tblEvaluacion.Rows[x]["FechaCiclo"]);
                objEvaluacion.Puntaje = Convert.ToInt32(tblEvaluacion.Rows[x]["Puntaje"].ToString());
                objEvaluacion.Descripcion = tblEvaluacion.Rows[x]["Descripcion"].ToString();

                ListaEvaluacion.Add(objEvaluacion);
            }

            return ListaEvaluacion;
        }

        public object mtdCargarCombo()
        {

            string sql = "Select Nombre,Puntaje From Evaluacion";

            DataTable tblCargarCombo = new DataTable();

            conexion = objConexion.mtdConexion();
            adapEvaluacion = new SqlDataAdapter(sql, conexion);
            conexion.Open();
            adapEvaluacion.Fill(tblCargarCombo);
            conexion.Close();


            List<EClEvaluacion> ListaCombo = new List<EClEvaluacion>();
            for (int x = 0; x < tblCargarCombo.Rows.Count; x++)
            {
                EClEvaluacion objEvaluacion = new EClEvaluacion();
                objEvaluacion.Nombre = tblCargarCombo.Rows[x]["Nombre"].ToString();
                objEvaluacion.Puntaje = Convert.ToInt32(tblCargarCombo.Rows[x]["Puntaje"].ToString());

                ListaCombo.Add(objEvaluacion);

            }
            return ListaCombo;
        }


        public int mtdEliminarEvaluacion(string proveedor)
        {

            string sql = "Delete From Evaluacion Where Nombre='" + proveedor + "'";

            conexion = objConexion.mtdConexion();
            cmdEvaluacion = new SqlCommand(sql, conexion);
            conexion.Open();
            int Eliminar = cmdEvaluacion.ExecuteNonQuery();
            conexion.Close();


            return Eliminar;

        }
        public object mtdComboProveedor()
        {

            string sql = "Select IdProveedor,Nombre From Proveedor";

            DataTable tblProveedor = new DataTable();

            conexion = objConexion.mtdConexion();
            adapEvaluacion = new SqlDataAdapter(sql, conexion);
            conexion.Open();
            adapEvaluacion.Fill(tblProveedor);
            conexion.Close();

            List<EClEvaluacion> Listaroveedor = new List<EClEvaluacion>();
            for (int x = 0; x < tblProveedor.Rows.Count; x++)
            {
                EClEvaluacion objProveedor = new EClEvaluacion();
              
                objProveedor.Nombre = tblProveedor.Rows[x]["Nombre"].ToString();

                Listaroveedor.Add(objProveedor);

            }

            return Listaroveedor;

        }

        public int mtdActualizarEvaluacion(EClEvaluacion objUpdate, string Update)
        {

            string sql = "Update Evaluacion Set FechaInicio='" + objUpdate.FechaInicio + "',FechaFin='" + objUpdate.FechaFin + "',FechaCiclo='" + objUpdate.FechaCiclo + "',Puntaje=" + objUpdate.Puntaje + ",Descripcion='" + objUpdate.Descripcion + "' Where Nombre='" + Update + "'";

            conexion = objConexion.mtdConexion();

            cmdEvaluacion = new SqlCommand(sql, conexion);
            conexion.Open();
            int Actualizar = cmdEvaluacion.ExecuteNonQuery();
            conexion.Close();

            return Actualizar;

        }
    }
}
