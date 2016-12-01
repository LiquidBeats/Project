using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloRiesgosSG_SST.Datos.Proveedores;
using ModuloRiesgosSG_SST.Entidades.Proveedores;

namespace ModuloRiesgosSG_SST.Logica.Proveedores
{
    class LClEvaluacion
    {
        DClEvaluacion objDEvaluacion = new DClEvaluacion();

        public int mtdRegistroEvaluacion(EClEvaluacion objEValuacion)
        {

            int Reg = 0;
            int Registro = objDEvaluacion.mtdRegistroEvaluacion(objEValuacion);

            if (Registro > 0)
            {

                Reg = 1;


            }


            return Reg;

        }

        public IList<EClEvaluacion> mtdListarEvaluacion()
        {
            IList<EClEvaluacion> Listev = new List<EClEvaluacion>();
            Listev = objDEvaluacion.mtdListarEvaluaciones();
            return Listev;
        }
        public List<EClEvaluacion> mtdListarNombre(string nombre)
        {

            return objDEvaluacion.mtdListarEvaluaciones(nombre: nombre);


        }
        public object mtdListarPuntaje(string puntaje)
        {


            return objDEvaluacion.mtdListarEvaluaciones(puntaje: puntaje);


        }
        public object mtdCargarCombo()
        {


            return objDEvaluacion.mtdCargarCombo();



        }

        public int mtdEliminarEvaluacion(string Proveedor)
        {

            int Elim = 0;
            int Eliminar = objDEvaluacion.mtdEliminarEvaluacion(proveedor: Proveedor);

            if (Eliminar > 0)
            {


                Elim = 1;

            }

            return Elim;


        }
        public object mtdComboProveedor()
        {


            return objDEvaluacion.mtdComboProveedor();


        }
        public int mtdActualizar(EClEvaluacion objUpdate, string Update)
        {

            int Reg = 0;
            int Registrar = objDEvaluacion.mtdActualizarEvaluacion(objUpdate, Update: Update);

            if (Registrar > 0)
            {


                Reg = 1;

            }


            return Reg;

        }
    }
}
