using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cartera_Facil.Model;
using Guna.UI.WinForms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cartera_Facil.View
{
    internal class ViewFunctions
    {
        Entities2 entities = new Entities2();
        private string Email;
        private string Password;
        public FormWindowState WindowState { get; private set; }
        public string Email1 { get => Email; set => Email = "devevanbermudez@gmail.com"; }
        public string Password1 { get => Email; set => Password = "eypumntiyjtyhogw"; }

        #region //Move the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

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

        public string GenerateRandomCode(int length)//Generar codigo aleatorio
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] codeArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                codeArray[i] = characters[random.Next(0, characters.Length)];
            }

            return new string(codeArray);
        
        }

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

        public object LlenarCombobox<E>(List<E> lista, string valueMember, string displayMember, ComboBox ob)
        {
            ob.DataSource = lista;
            ob.DisplayMember = displayMember;
            ob.ValueMember = valueMember;
            ob.SelectedIndex = 0;
            ob.MaxDropDownItems = 5;
            return ob.SelectedValue;
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
            string email = identificationEmail.Text;
            var queryEmail = entities.USUARIOS.Any
                (x => x.EMAIL == email);
            if(queryEmail == true)
                   return true;
            else
                return false;
        }

        public bool checkData(GunaTextBox identificationNumber, GunaTextBox email, Label identificationNumberInvalid, Label emailInvalid) //comprobacion de datos
        {
            string identificarionNumber = identificationNumber.Text;
            bool identificarionNumberJustNumbers = identificarionNumber.All(char.IsDigit);
            bool repeatedIdentification = CheckDocumentNumber(identificationNumber);
            bool repeatedEmail = CheckEmail(email);

            if (identificarionNumberJustNumbers == true)
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
    }
}
