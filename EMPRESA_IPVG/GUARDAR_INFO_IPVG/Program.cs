using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMPRESA_IPVG;

namespace GUARDAR_INFO_IPVG
{
    class Program
    {

        static void Main (string[] args)
        {
            //Cargo

            Cargo c = new Cargo();
            c.id_cargo = 001;
            c.nombre_cargo = "Bibliotecario";

            // Region

            Region r = new Region();
            r.id_region = 1001;
            r.nombre_region = "Metropolitana";


            // Sucursales

            Sucursales s = new Sucursales();

            s.id_sucursal = 001;
            s.ciudad = "Santiago";
            s.direccion = "Cienfuegos 41";
            s.telefono = 226999877;
            Region region = new Region();
            region.nombre_region = r.nombre_region;

            s.AgregarRegion(region);



            // Jefe

            Jefe j = new Jefe();
            j.rut_jefe=  101023012;
            j.nombre_jefe = "Pierre";
            j.apellido_jefe = "Dogoyuna";

            //Departamento

            Departamento d = new Departamento();
            d.id_departamento = 2001;
            d.nombre_departamento = "Biblioteca";
            Sucursales sucursales = new Sucursales();
            sucursales.ciudad = s.ciudad;



            Empleados e = new Empleados();

            e.rut_empleado = 160006669;
            e.nombre_empleado = "Hector";
            e.apellido_empleado = "Van Damme";
            e.direccion= "Los Carreras 133";
            e.telefono = 987788998;
            Cargo cargo = new Cargo();
        cargo.nombre_cargo = c.nombre_cargo;
            Jefe jefe = new Jefe();
            jefe.nombre_jefe = j.nombre_jefe;
            jefe.apellido_jefe = j.apellido_jefe;
            Departamento departamento = new Departamento();
            departamento.nombre_departamento = d.nombre_departamento;

        





            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
