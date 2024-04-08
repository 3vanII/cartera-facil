using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cartera_Facil.Model;
using Guna.UI.WinForms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Cartera_Facil.View
{
    internal class ViewFunctions
    {
        Entities3 entities = new Entities3();
        MailMessage mEmail = new MailMessage();
        private string email;
        private string password;
        public FormWindowState WindowState { get; private set; }
        public string Email { get => "DEVEVANBERMUDEZ@GMAIL.COM"; set => email = value; }
        public string Password { get => "eypumntiyjtyhogw"; set => password = value; }

        #region //Move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region//LLenado de txtbox por defecto
        public void AssignIndicativeText(GunaTextBox textBox, string indicativeText)
        {
            // Asignar el texto de indicación al Tag del GunaTextBox
            textBox.Tag = indicativeText;
            // Asignar el evento Enter al GunaTextBox
            textBox.Enter += TextBox_Enter;
            // Asignar el evento Leave al GunaTextBox
            textBox.Leave += TextBox_Leave;
            // Mostrar el texto de indicación inicialmente
            ShowIndicativeText(textBox);
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            GunaTextBox textBox = (GunaTextBox)sender;
            // Cuando el GunaTextBox recibe el foco, limpiar el texto de indicación
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.WindowText; // Color de texto normal
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            GunaTextBox textBox = (GunaTextBox)sender;
            // Cuando el GunaTextBox pierde el foco, mostrar el texto de indicación si está vacío
            ShowIndicativeText(textBox);
        }

        private void ShowIndicativeText(GunaTextBox textBox)
        {
            string textoIndicacion = textBox.Tag.ToString();
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textoIndicacion;
                textBox.ForeColor = System.Drawing.SystemColors.GrayText; // Color de texto grisáceo
            }
        }
        #endregion

        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la contraseña en un array de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir los bytes en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }//Encriptar COntraseña

        public Image UploadImage(PictureBox ob)//Cargar Imagen
        {
            OpenFileDialog searchImage = new OpenFileDialog();
            searchImage.Title = "Seleccionar imagen";
            if (searchImage.ShowDialog() == DialogResult.OK)
            {
                Image imagen = Image.FromFile(searchImage.FileName);
                ob.Image = imagen;
            }
            return ob.Image;
        }

        public string GenerateRandomCode()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            string nuevaCode = Convert.ToString(rnd.Next(100000, 999999));
            return nuevaCode;
        }//Generar numero aleatorio

        public void ComposeEmail(string recipientEmail, string code)
        {
            try
            {
                mEmail.From = new MailAddress(Email, "Cartera Facil", System.Text.Encoding.UTF8);
                mEmail.To.Add(recipientEmail);
                mEmail.Subject = "Codigo de validacion";
                mEmail.Body = $"Tu codigo de validacion es: {code}";
                mEmail.IsBodyHtml = true;
                mEmail.Priority = MailPriority.High;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//llenar email

        public void Enviar()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential(Email, Password);
                    smtp.Timeout = 30000;

                    // Importante: En un entorno de producción, deberías validar el certificado del servidor de correo
                    ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate,
                        X509Chain chain, SslPolicyErrors errors)
                    { return true; };

                    smtp.Send(mEmail);
                }
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Error SMTP: {ex.StatusCode} - {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}");
            }
        }//Enviar Email

        public Image UploadPhotoByDefault(string route, PictureBox ob)//Cargar foto por defecto
        {
            Image image = Image.FromFile(route);
            ob.Image = image;
            return ob.Image;
        }

        public static byte[] Image2Byte(Image img)//Convertir una imagen a un array de bytes
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        public static GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        public void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        public void LlenarCombobox<E>(List<E> lista, string valueMember, string displayMember, ComboBox ob, string nameCombobox)
        {
            ob.DisplayMember = displayMember;
            ob.ValueMember = valueMember;
            ob.DataSource = lista;
            ob.MaxDropDownItems = 5;
            ob.Text = nameCombobox;
            ob.Refresh();
        }

        public bool CheckDocumentNumber(GunaTextBox identificationNumber) //comprobar numero de documento
        {
            string document = identificationNumber.Text;
            var queryCedula = entities.USUARIOS.Any
                (x => x.ID == document);
            if (queryCedula == true)
                return true;
            else
                return false;
        }

        public bool CheckEmail(GunaTextBox identificationEmail)
        {
            string email = identificationEmail.Text.ToUpper();
            var queryEmail = entities.USUARIOS.Any
                (x => x.EMAIL == email);
            if(queryEmail == true)
                   return true;
            else
                return false;
        }//Comprobar Email

        public bool checkData(GunaTextBox identificationNumber, GunaTextBox email, Label identificationNumberInvalid, Label emailInvalid) //comprobacion de datos
        {
            string identificarionNumber = identificationNumber.Text;
            bool identificarionNumberJustNumbers = identificarionNumber.All(char.IsDigit);
            bool repeatedIdentification = CheckDocumentNumber(identificationNumber);
            bool repeatedEmail = CheckEmail(email);

            if (identificarionNumberJustNumbers == true || identificarionNumber == "Número de identificación")
            {
                identificationNumberInvalid.Visible = false;
                if (repeatedIdentification == true)
                    identificationNumberInvalid.Visible = true;
                else
                    identificationNumberInvalid.Visible = false;
            }
            else
                identificationNumberInvalid.Visible = true;

            if (repeatedEmail == true)
                emailInvalid.Visible = true;
            else
                emailInvalid.Visible = false;

            if ((identificarionNumberJustNumbers == true) && (repeatedIdentification == false) && (repeatedEmail == false))
                return false;
            else
                return true;

        }

        public List<object> GetSales(string date) //Llenar datagred
        {
            return (from empleado in entities.USUARIOS
                    where empleado.NOMBRES.StartsWith(date) || empleado.ID.StartsWith(date)
                    join cargo in entities.CARGOS on empleado.CARGO_ID equals cargo.ID
                    select new
                    {
                        Identificacion = empleado.ID,
                        Nombre = empleado.NOMBRES,
                        Apellido = empleado.APELLIDO,
                        Cargo = cargo.CARGO,
                        Telefono = empleado.TELEFONO,
                        Email = empleado.EMAIL
                    }).ToList<object>();
        }

       
    }
}
