using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPRESA_IPVG
{
    public class Departamento
    {
        public int id_departamento { get; set; }

        public string nombre_departamento { get; set; }

        public Jefe jefe { get; set; }


        public Departamento()
        {
            this.jefe = new Jefe();

        }

        public Departamento(Jefe jefe)
        {
            this.jefe = jefe;
        }




    }


   


    }
