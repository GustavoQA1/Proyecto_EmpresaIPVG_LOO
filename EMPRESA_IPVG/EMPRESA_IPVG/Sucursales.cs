using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_IPVG
{
    public class Sucursales
    {

        public int id_sucursal { get; set; }

        public string ciudad { get; set; }

        public string direccion { get; set; }

        public int telefono { get; set; }

        public Region region { get; set; }

        public List<Empleados> empleados { get; set; }



        public Sucursales()
            {
            this.region = new Region();
            }

        public Sucursales (Region region)
        {
            this.region = region;
        }

        public void AgregarEmpleados (Empleados empleados)
        {
            this.empleados.Add(empleados);
        }

   

    }
}
