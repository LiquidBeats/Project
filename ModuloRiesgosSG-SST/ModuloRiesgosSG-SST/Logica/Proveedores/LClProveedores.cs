using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloRiesgosSG_SST.Datos.Proveedores;
using ModuloRiesgosSG_SST.Entidades.Proveedores;

namespace ModuloRiesgosSG_SST.Logica.Proveedores
{
    class LClProveedores
    {
        DClProveedores objDprov = new DClProveedores();
        //Metodo de transporte vista-datos proveedor

        public int mtdTransDataProv(EClProveedores objEprov)
        {
            int Mss = objDprov.mtdRegistrarProveedores(objEprov);
            int Mj = 0;

            if (Mss > 0)
            {
                Mj = 1;
            }
            else
            {
                Mj = 0;
            }

            return Mj;
        }

        //Metodo para el listado de proveedores
        public IList<EClProveedores> mtdListProveedores()
        {
            IList<EClProveedores> ListProve = new List<EClProveedores>();
            ListProve = objDprov.mtdListarProveedor();
            return ListProve;
        }

        //Metodo para eliminar proveedores
        public int mtdEliminarProveedores(string Nm)
        {
            int Dt = objDprov.mtdEliminarProv(nom:Nm);
            return Dt;
        }

        //Metodo para la actualizacion de datos

        public int mtdActualizarProveedores(EClProveedores objEproved,string Nm)
        {
            int Mj = objDprov.mtdActulizarDatosProv(objEproved, Nombr:Nm);
            int Mss=0;
            if (Mj > 0)
            {
                Mss = 1;
            }
            else
            {
                Mss = 0;
            }

            return Mss;
        }

        //Metodo para la extraccion de datos y carga en los textbox

        public IList<EClProveedores> mtdExtraerData(string Nm)
        {
            IList<EClProveedores> ListProve = new List<EClProveedores>();
            ListProve = objDprov.mtdExtraerDataUpdate(nom:Nm);
            return ListProve;
        }

        //Metodo para la carga del como por nit

        public object mtdCargarComboNit()
        {
            return objDprov.mtdCargarComboNit();
        }

        //Metodo para la carga del como por nombre

        public object mtdCargarComboNombre()
        {
            return objDprov.mtdCargarComboNombre();
        }

        //Metodo para el listado de la busqueda por nit

        public IList<EClProveedores> mtdListNitBusqueda(string Nt)
        {
            IList<EClProveedores> ListPrvNt = new List<EClProveedores>();
            ListPrvNt = objDprov.mtdBusquedaNit(Nit: Nt);
            return objDprov.mtdBusquedaNit(Nit:Nt);
        }

        //Metodo para el listado de la busqueda por nombre

        public IList<EClProveedores> mtdListNombreBusqueda(string nom)
        {
            IList<EClProveedores> ListPrvNm = new List<EClProveedores>();
            ListPrvNm = objDprov.mtdBusquedaNombre(Nom:nom);
            return ListPrvNm;
        }

        //Filtro Mega
        public IList<EClProveedores> mtdListProvMega(string nombr)
        {
            IList<EClProveedores> ListPrvM = new List<EClProveedores>();
            ListPrvM = objDprov.mtdMegaFiltro(Nombr: nombr);
            return ListPrvM;
        }

        //metodo para extaer ciudad update

        public object mtdExtraerCiudad(string nm)
        {
            IList<EClProveedores> ListCmbCity = new List<EClProveedores>();
            ListCmbCity = objDprov.mtdExtraerComboCity(nmbc:nm);
            return ListCmbCity;
        }


    }
}
