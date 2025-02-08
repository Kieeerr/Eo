using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPrestamo
    {
      
            public int PrestamoID { get; set; }
            public int ClienteID { get; set; }
            public decimal Monto { get; set; }
             public decimal MontoPagado { get; set; }
             public int TiempoMeses { get; set; }
            public decimal Interes { get; set; }
            public decimal MontoTotal { get; set; }
            public decimal MontoCuota { get; set; }
            public string Estado {  get; set; }

        public decimal CalcularInteres(int numeroCuotas)
        {
            if (numeroCuotas >= 1 && numeroCuotas <= 3)
                return 10;
            else if (numeroCuotas >= 4 && numeroCuotas <= 6)
                return 8;
            else if (numeroCuotas >= 7 && numeroCuotas <= 12)
                return 7;
            else
                return 5;
        }
        public void CalcularTotales()
        {
            this.Interes = this.Monto * (this.CalcularInteres(this.TiempoMeses) / 100);
            this.MontoTotal = this.Monto + this.Interes;
            this.MontoCuota = this.MontoTotal / this.TiempoMeses;
        }
    }

}