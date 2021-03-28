using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace AdministradorPcOne.Servicios
{
    class SesionServicio
    {

        public string Nombre { get; set; }
        public string Contraseña { get; set; }

        public Task<Empleado> IniciarSesionAsync(string Email)
        {
            return Task.Run(() =>
            {
                using (DSPEntities db = new DSPEntities())
                {
                    try
                    {
                        Empleado answer = db.Empleado.Where( x => x.email == Email).First();
                        return answer;
                        
                    }
                    catch (Exception e)
                    {
                        return null;
                    }

                }
                
            });
        }

        public Task<List<Empleado>> ObtenerEmpleadosAsync()
        {
            return Task.Run(() =>
            {
                using(DSPEntities db= new DSPEntities()) { 
                    try
                    {
                        return (from data in db.Empleado.Include("Cargo")
                                select data).ToList(); ;

                    }
                    catch(Exception e)
                    {
                        return null;
                    }
                
                }
            });
        }
        
        public Task<Empleado> ObtenerDatosEmpleadoAsync(string Usuario)
        {
            return Task.Run(() =>
            {
                DSPEntities db = new DSPEntities();
                try
                    {
                        return db.Empleado.Where(x => x.nombres.Equals(Usuario)).First();
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
            });
        }



    }//Clase
}//NameSpace
