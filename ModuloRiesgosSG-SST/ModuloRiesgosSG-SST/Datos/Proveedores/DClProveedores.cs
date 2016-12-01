
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ModuloRiesgosSG_SST.Datos.Conexion;
using ModuloRiesgosSG_SST.Entidades.Proveedores;

namespace ModuloRiesgosSG_SST.Datos.Proveedores
{
    class DClProveedores
    {
        DClConexion objCon = new DClConexion();
        SqlConnection Con;
        public int mtdRegistrarProveedores(EClProveedores objEprov)
        {
            Con = objCon.mtdConexion();
            SqlCommand cmdInsertProv = new SqlCommand("insert into Proveedor (Nit,Nombre,Direccion,Email,Telefono,Departamento,Ciudad,PaginaWeb) values('" + objEprov.Nit + "','" + objEprov.Nombre + "','" + objEprov.Direccion + "','" + objEprov.Email + "','" + objEprov.Telefono + "','"+objEprov.Departamento+"','"+objEprov.Ciudad+"','"+objEprov.PaginaWeb+"')", Con);
            Con.Open();
            int Rt = cmdInsertProv.ExecuteNonQuery();
            Con.Close();
            return Rt;
        }

        public IList<EClProveedores> mtdListarProveedor()
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListProv = new List<EClProveedores>();
            SqlCommand cmdSelectListProv = new SqlCommand("select Nit,Nombre,Direccion,Email,Telefono,Departamento,Ciudad,PaginaWeb from Proveedor", Con);
            Con.Open();
            SqlDataReader Datare = cmdSelectListProv.ExecuteReader();
            while (Datare.Read())
            {
                EClProveedores objEprov = new EClProveedores();
                objEprov.Nit = Datare[0].ToString();
                objEprov.Nombre = Datare[1].ToString();
                objEprov.Direccion = Datare[2].ToString();
                objEprov.Email = Datare[3].ToString();
                objEprov.Telefono = Datare[4].ToString();
                objEprov.Departamento = Datare[5].ToString();
                objEprov.Ciudad = Datare[6].ToString();
                objEprov.PaginaWeb = Datare[7].ToString();
                ListProv.Add(objEprov);
            }
            Con.Close();
            return ListProv;
        }

        public int mtdEliminarProv(string nom)
        {
            Con = objCon.mtdConexion();
            SqlCommand cmdDeleteProv = new SqlCommand("delete from Proveedor where Nombre='"+nom+"'", Con);
            Con.Open();
            int Dlt=cmdDeleteProv.ExecuteNonQuery();
            Con.Close();
            return Dlt;
        }

        public int mtdActulizarDatosProv(EClProveedores objEprov,string Nombr)
        {
            Con = objCon.mtdConexion();
            SqlCommand cmdUpdateProv = new SqlCommand("update Proveedor set Nit='"+objEprov.Nit+"',Nombre='"+objEprov.Nombre+"', Direccion='"+objEprov.Direccion+"',Email='"+objEprov.Email+"',Telefono='"+objEprov.Telefono+"',Departamento='"+objEprov.Departamento+"',Ciudad='"+objEprov.Ciudad+"',PaginaWeb='"+objEprov.PaginaWeb+"' where Nombre='"+Nombr+"'", Con);
            Con.Open();
            int up=cmdUpdateProv.ExecuteNonQuery();
            Con.Close();
            return up;
        }

        public IList<EClProveedores> mtdExtraerDataUpdate(string nom)
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListProv = new List<EClProveedores>();
            SqlCommand cmdSelectData = new SqlCommand("select Nit,Nombre,Direccion,Email,Telefono,Departamento,Ciudad,PaginaWeb from Proveedor where Nombre='"+nom+"'", Con);
            Con.Open();
            SqlDataReader Datare = cmdSelectData.ExecuteReader();
            while (Datare.Read())
            {
                EClProveedores objEprov = new EClProveedores();
                objEprov.Nit = Datare[0].ToString();
                objEprov.Nombre = Datare[1].ToString();
                objEprov.Direccion = Datare[2].ToString();
                objEprov.Email = Datare[3].ToString();
                objEprov.Telefono = Datare[4].ToString();
                objEprov.Departamento = Datare[5].ToString();
                objEprov.Ciudad = Datare[6].ToString();
                objEprov.PaginaWeb = Datare[7].ToString();
                ListProv.Add(objEprov);
            }
            Con.Close();
            return ListProv;
        }

        public IList<EClProveedores> mtdCargarComboNit()
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListProvSearch = new List<EClProveedores>();
            SqlCommand cmdSelectBusqueda = new SqlCommand("select Nit from Proveedor", Con);
            Con.Open();
            SqlDataReader Datar = cmdSelectBusqueda.ExecuteReader();
            while (Datar.Read())
            {
                EClProveedores objEprovee = new EClProveedores();
                objEprovee.Nit = Datar[0].ToString();
                ListProvSearch.Add(objEprovee);
            }
            Con.Close();
            return ListProvSearch;
        }
        public IList<EClProveedores> mtdCargarComboNombre()
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListProvSearch = new List<EClProveedores>();
            SqlCommand cmdSelectBusqueda = new SqlCommand("select Nombre from Proveedor", Con);
            Con.Open();
            SqlDataReader Datar = cmdSelectBusqueda.ExecuteReader();
            while (Datar.Read())
            {
                EClProveedores objEprovee = new EClProveedores();
                objEprovee.Nombre = Datar[0].ToString();
                ListProvSearch.Add(objEprovee);
            }
            Con.Close();
            return ListProvSearch;
        }

        public IList<EClProveedores> mtdBusquedaNit(string Nit)
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListNitProv = new List<EClProveedores>();
            SqlCommand cmdListNit = new SqlCommand("select Nit,Nombre,Direccion,Email,Telefono,Departamento,Ciudad,PaginaWeb from Proveedor where Nit = '"+Nit+"'", Con);
            Con.Open();
            SqlDataReader Datar = cmdListNit.ExecuteReader();
            while (Datar.Read())
            {
                EClProveedores objEprovee = new EClProveedores();
                objEprovee.Nit = Datar[0].ToString();
                objEprovee.Nombre = Datar[1].ToString();
                objEprovee.Direccion = Datar[2].ToString();
                objEprovee.Email = Datar[3].ToString();
                objEprovee.Telefono = Datar[4].ToString();
                objEprovee.Departamento = Datar[5].ToString();
                objEprovee.Ciudad = Datar[6].ToString();
                objEprovee.PaginaWeb = Datar[7].ToString();
                ListNitProv.Add(objEprovee);
            }
            Con.Close();
            return ListNitProv;
        }

        public IList<EClProveedores> mtdBusquedaNombre(string Nom)
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListNom = new List<EClProveedores>();
            SqlCommand cmdListNom = new SqlCommand("select Nit,Nombre,Direccion,Email,Telefono,Departamento,Ciudad,PaginaWeb from Proveedor where Nombre = '"+Nom+"'", Con);
            Con.Open();
            SqlDataReader Datare = cmdListNom.ExecuteReader();
            while (Datare.Read())
            {
                EClProveedores objEprov = new EClProveedores();
                objEprov.Nit = Datare[0].ToString();
                objEprov.Nombre = Datare[1].ToString();
                objEprov.Direccion = Datare[2].ToString();
                objEprov.Email = Datare[3].ToString();
                objEprov.Telefono = Datare[4].ToString();
                objEprov.Departamento = Datare[5].ToString();
                objEprov.Ciudad = Datare[6].ToString();
                objEprov.PaginaWeb = Datare[7].ToString();
                ListNom.Add(objEprov);
            }
            Con.Close();
            return ListNom;
        }

        public IList<EClProveedores> mtdMegaFiltro(string Nombr)
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListMega = new List<EClProveedores>();
            SqlCommand cmdListMe = new SqlCommand("select Nit,Nombre,Direccion,Email,Telefono,Departamento,Ciudad,PaginaWeb from Proveedor where Nombre like '%" + Nombr + "%'", Con);
            Con.Open();
            SqlDataReader Datare = cmdListMe.ExecuteReader();
            while (Datare.Read())
            {
                EClProveedores objEprov = new EClProveedores();
                objEprov.Nit = Datare[0].ToString();
                objEprov.Nombre = Datare[1].ToString();
                objEprov.Direccion = Datare[2].ToString();
                objEprov.Email = Datare[3].ToString();
                objEprov.Telefono = Datare[4].ToString();
                objEprov.Departamento = Datare[5].ToString();
                objEprov.Ciudad = Datare[6].ToString();
                objEprov.PaginaWeb = Datare[7].ToString();
                ListMega.Add(objEprov);
            }
            Con.Close();
            return ListMega;
        }

        public IList<EClProveedores> mtdExtraerComboCity(string nmbc)
        {
            Con = objCon.mtdConexion();
            List<EClProveedores> ListComboC = new List<EClProveedores>();
            SqlCommand cmdCitycmb = new SqlCommand("select Ciudad from Proveedor where Nombre='"+nmbc+"'", Con);
            Con.Open();
            SqlDataReader Datar = cmdCitycmb.ExecuteReader();
            while (Datar.Read())
            {
                EClProveedores objEprovee = new EClProveedores();
                objEprovee.Ciudad = Datar[0].ToString();
                ListComboC.Add(objEprovee);
            }
            Con.Close();
            return ListComboC;
        }

    }
}
