using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public List<City> Datos()
        {
            string Query = "SELECT * FROM CITY";
            MySqlConnection cn = BdConnection.ObtenerConexion();
            MySqlCommand xd = cn.CreateCommand();
            xd.CommandText = Query;
            MySqlDataReader dr = xd.ExecuteReader();
            List<City> ciu = new List<City>();
            while (dr.Read())
            {
                City c = new City();
                c.Id = dr.GetInt32(0);
                c.Name = dr.GetString(1);
                c.CountryCode = dr.GetString(2);
                c.District = dr.GetString(3);
                c.Population = dr.GetInt32(4);
                ciu.Add(c);
            }
            dr.Close();
            return ciu;
        }
    }
}
