using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for ClassC
/// </summary>
public class ClassC
{
    /// <summary>
    /// La cadena de conexión a la base de datos
    /// </summary>
 
             public static MySqlConnection ObtenerConexion()
       {
           MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=wtsapp; Uid=root; pwd=lorena123;");
           
               conectar.Open();
               return conectar;        
       }
    
}