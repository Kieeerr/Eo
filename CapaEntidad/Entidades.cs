namespace CapaEntidad
{
    public class Entidades
    {
        public class Cliente
        {
          
            public string NombreC { get; set; }
            public decimal Sueldo { get; set; }
           
            public string Telefono { get; set; }
            public string ObjetoGarantia { get; set; }
        }
        
        public static class Sesion
        {
            public static int ID { get; set; }
            public static string Correo { get; set; }
        }
        public class Intereses
        {
            public int Meses { get; set; }
            public decimal Porcentaje { get; set; }
        }
        public class Prestamo
        {
            public int PrestamoID { get; set; }
            public int ClienteID { get; set; }
            public decimal Monto { get; set; }
            public int TiempoMeses { get; set; }
            public decimal Interes { get; set; }
            public decimal MontoTotal { get; set; }
            public decimal MontoAbonado { get; set; }
            public decimal { get;set; }    
        }
        public class Fondo
        {
            public int FondoID { get; set; }
            public decimal MontoCapital { get; set; }
        }
        public class Pagos
        {
            public int PagoID { get; set; }
            public int PrestamoID { get; set; }
            public decimal MontoA { get; set; }
            public decimal Interes { get; set; }
            public decimal MontoNuevo { get; set; }
            public decimal NMonto { get; set; }
        }
        public class Moras
        {
            public int MoraID { get; set; }
            public int ClienteID { get; set; }
            public int CantidadMoras { get; set; }
        }
        public class Usuario
        {
            public int UsuarioID { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string NombreUsuario { get; set; }
            public string Contraseña { get; set; }
        }


    }
}
