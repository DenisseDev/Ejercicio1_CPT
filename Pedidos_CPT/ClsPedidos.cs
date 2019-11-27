using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pedidos_CPT
{
    public class ClsPedidos
    {
        public double RangoInicial { get; set; }

        public double RangoFinal { get; set; }

        public double Descuento { get; set; }

        public String Codigo { get; set; }
        public String Ciudad { get; set; }

        public double Impuesto { get; set; }
    }

    public class Ordenes
    {
        List<ClsPedidos> pedidos = new List<ClsPedidos>();

        public Ordenes()
        {
            pedidos.Add(new ClsPedidos { RangoInicial = 0, RangoFinal = 1000, Descuento = 0.03, Codigo = "QU", Ciudad = "Quito", Impuesto = 0.06 });
            pedidos.Add(new ClsPedidos { RangoInicial = 1001, RangoFinal = 5000, Descuento = 0.05, Codigo = "GU", Ciudad = "Guayaquil", Impuesto = 0.08 });
            pedidos.Add(new ClsPedidos { RangoInicial = 5001, RangoFinal = 7000, Descuento = 0.07, Codigo = "CU", Ciudad = "Cuenca", Impuesto = 0.09 });
            pedidos.Add(new ClsPedidos { RangoInicial = 7001, RangoFinal = 10000, Descuento = 0.1, Codigo = "AM", Ciudad = "Ambato", Impuesto = 0.1 });
            pedidos.Add(new ClsPedidos { RangoInicial = 10001, RangoFinal = -1, Descuento = 0.12, Codigo = "LO", Ciudad = "Loja", Impuesto = 0.06 });
        }

        public double Calcular(int cantidad, double precio, string provincia)
        {
            var tmp = from p in pedidos
                      where p.Codigo == provincia
                      select cantidad * precio;
            return tmp.SingleOrDefault();
        }
    }


}
