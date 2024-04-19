using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartera_Facil.Model
{
    public static class AuthenticatedUser
    {
        public static string ID { get; set; }
        public static string NOMBRES { get; set; }
        public static string APELLIDO { get; set; }
        public static int CARGO_ID { get; set; }
        public static byte[] FOTO { get; set; }
        public static string EMAIL { get; set; }
        public static string HABILITADO { get; set; }
        public static string ROLE { get; set; }
    }
}
