using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
namespace wtsnApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                if (fUpload.HasFile)
                {
                    bool fl = false;

                    string extension = Path.GetExtension(fUpload.FileName).ToLower();
                    string[] listaExtensiones = { ".pdf", ".odt", ".docx", ".jpg", ".txt" };

                    for (int i = 0; i < listaExtensiones.Length; i++)
                    {
                        if (extension.Equals(listaExtensiones[i]))
                        {
                            fl = true;
                            break;
                        }
                    }

                    if (fl)
                    {
                        fUpload.PostedFile.SaveAs(@"C:\Users\Usuario\Documents\watsonApp\archivos\" + fUpload.FileName);
                        int valor = insertar("/archivos/" + fUpload.FileName, extension);

                        if (valor > 0)
                        {
                            Response.Write("Insertado en la Base de Datos");
                        }
                        else
                        {
                            Response.Write("Archivo no almacenado");
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        public int insertar(string rutaArchivo, string tipo)
        {
            int respuesta = 0;


            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("insert into files(fileName, fileExt) values ('" + rutaArchivo + "','" + tipo + "')"), ClassC.ObtenerConexion());
                respuesta = comando.ExecuteNonQuery();

            }
            catch
            {
                respuesta = 0;
            }

            return respuesta;
        }
    }
}