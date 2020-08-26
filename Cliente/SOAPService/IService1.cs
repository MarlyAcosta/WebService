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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<City> Datos();

        // TODO: agregue aquí sus operaciones de servicio
    }


	// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.


	/// <summary>
	/// Clase "modelo" city que guardara los registros que se traigan de las consultas
	/// </summary>
	[DataContract]
	public class City
	{
		int id;
		string name;
		string countryCode;
		string district;
		int population;

		[DataMember]
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		[DataMember]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		[DataMember]
		public string CountryCode
		{
			get { return countryCode; }
			set { countryCode = value; }
		}
		[DataMember]
		public string District
		{
			get { return district; }
			set { district = value; }
		}
		[DataMember]
		public int Population
		{
			get { return population; }
			set { population = value; }
		}
	}

	/// <summary>
	/// Clase de la conexion a la base de datos
	/// </summary>
	public class BdConnection
	{
		public static MySqlConnection ObtenerConexion()
		{
			MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=world; Uid=root; pwd=;");
			con.Open();
			return con;
		}
	}
}

