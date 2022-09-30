using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_IPVG
{
   public class Empleados
    {

        public int rut_empleado { get; set; }

        public string nombre_empleado { get; set; }

        public string apellido_empleado { get; set; }

        public string direccion { get; set; }

        public int telefono { get; set; }

        public Cargo cargo { get; set; }
        public Jefe jefe { get; set; }

        public Departamento departamento { get; set; }

        public Empleados ()
        {

        }





        public Empleados(int rut_empleado, string nombre_empleado, string apellido_empleado, string direccion, int telefono)
        {
            this.rut_empleado = rut_empleado;
            this.nombre_empleado = nombre_empleado;
            this.apellido_empleado = apellido_empleado;
            this.direccion = direccion;
            this.telefono = telefono;


        }

        public Empleados(Cargo cargo, Jefe jefe, Departamento departamento, Sucursales sucursales)
        {
            this.cargo = cargo;
            this.jefe = jefe;
            this.departamento = departamento;
   
        }

  
    }
}
