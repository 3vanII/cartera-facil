using Cartera_Facil.Model;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Cartera_Facil.View
{
    public partial class Simulator : Form
    {
        ViewFunctions obj = new ViewFunctions();
        Entities2 entities = new Entities2();
        private int capital;
        private int interestRate;
        private int time;
        private string paymentMethod;
        private float interests;
        private float total;
        private float numbersInstallments;
        private float quotaValue;
        private float interest;
        private float amortization;
        private float stationery;

        public int Capital { get => capital; set => capital = value; }
        public int InterestRate { get => interestRate; set => interestRate = value; }
        public int Time { get => time; set => time = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public float Interests { get => interests; set => interests = value; }
        public float Total { get => total; set => total = value; }
        public float NumbersInstallments { get => numbersInstallments; set => numbersInstallments = value; }
        public float QuotaValue { get => quotaValue; set => quotaValue = value; }
        public float Interest { get => interest; set => interest = value; }
        public float Amortization { get => amortization; set => amortization = value; }
        public float Stationery { get => stationery; set => stationery = value; }

        public Simulator()
        {
            InitializeComponent();
            obj.LlenarCombobox(entities.MODALIDAD_PAGO.ToList(), "ID", "MODALIDAD", ComboBoxPaymentMethod);
            
        }

        private bool CheckFields(GunaTextBox amount)//Comprobar campos
        {
            string loan = amount.Text;
            if (loan.All(char.IsDigit) == true)
            {
                lblValidateNumber.Visible = false;
                return true;
            }
            else
            {
                lblValidateNumber.Visible = true;
                return false;
            }
                
        }

        private bool FullField(GunaTextBox amount)
        {
            if(amount.Text != string.Empty)
            {
                lblConfirmationAmount.Visible = false;
                return true;
            }
            else
            {
                lblConfirmationAmount.Visible = true;
                return false;
            }
                
        }


        private void CalculateCredit()
        {
            try
            {
                bool checkFields = CheckFields(txtAmount);
                bool fullField = FullField(txtAmount);
                if ((checkFields == true) && (fullField == true))
                {
                    Capital = Convert.ToInt32(txtAmount.Text);//capital
                    InterestRate = (int)gunaNumericInterestRate.Value;//tasa de interes
                    Time = (int)gunaNumericTime.Value;//tiempo
                    PaymentMethod = ComboBoxPaymentMethod.Text;//modalidad de pago
                    Interests = Capital * InterestRate / 100 * Time;//intereses
                    float total = Capital + Interests;
                    NumbersInstallments = 0;//numero de cuotas
                    switch (PaymentMethod) 
                    {
                        case "DIARIO":
                            NumbersInstallments = 30 * Time; 
                            break;

                        case "SEMANAL":
                            NumbersInstallments = 30 * Time / 7; 
                            break;

                        case "QUINCENAL":
                            NumbersInstallments = 30 * Time / 15; 
                            break;

                        case "MENSUAL":
                            NumbersInstallments = Time;
                            break;
                    }
                    QuotaValue = total / NumbersInstallments;//valor de cuota
                    Interest = Interests / NumbersInstallments;//interes * cuota
                    Amortization = Capital/ NumbersInstallments;//amortizacion
                    Stationery = total / (30 * Time);//papeleria
                    Total = total + Stationery;


                    GenerateReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateReport()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss");
                saveFileDialog.Filter = "Archivos PDF (.pdf)|.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string pageHtml = Properties.Resources.carteraFacil.ToString();
                    pageHtml = pageHtml.Replace("@Capital", Capital.ToString());
                    pageHtml = pageHtml.Replace("@tasaInteres%", InterestRate.ToString());
                    pageHtml = pageHtml.Replace("@tiempo", Time.ToString());
                    pageHtml = pageHtml.Replace("@modalidadPago", PaymentMethod);
                    pageHtml = pageHtml.Replace("@Amortización", Amortization.ToString());
                    pageHtml = pageHtml.Replace("@Interés", Interest.ToString());
                    pageHtml = pageHtml.Replace("@TotalCuota", QuotaValue.ToString());
                    pageHtml = pageHtml.Replace("@Número de cuotas", NumbersInstallments.ToString());
                    pageHtml = pageHtml.Replace("@Intereses", Interests.ToString());
                    pageHtml = pageHtml.Replace("@Papelería", Stationery.ToString());
                    pageHtml = pageHtml.Replace("@Total", Total.ToString());

                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();

                        using (StringReader sr = new StringReader(pageHtml))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Reporte creado");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnsSimulate_Click(object sender, EventArgs e)
        {
            CalculateCredit();
        }
    }
}
