using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cartera_Facil.Model;
using FontAwesome.Sharp;

namespace Cartera_Facil.View
{
    public partial class MainWindow : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        ViewFunctions view = new ViewFunctions();
        public MainWindow()
        {
            InitializeComponent();
            CustomizeDesing();
            lblNameUser.Text = $"{AuthenticatedUser.NOMBRES} {AuthenticatedUser.APELLIDO}";
            //FillLabelName();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            sideMenuPanel.Controls.Add(leftBorderBtn);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            iconFormChild.IconChar = currentBtn.IconChar;
            lblTitleChildForm.Text = childForm.Text;
        }

        private void DislabelButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(91, 125, 207);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DislabelButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(145, 168, 223);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }

        }

        private void CustomizeDesing()
        {
            subMenuLoan.Visible = false;
            subMenuUsers.Visible = false;
        }

        private void HideSubMenu()
        {
            if (subMenuLoan.Visible == true)
                subMenuLoan.Visible = false;
            if (subMenuUsers.Visible == true)
                subMenuUsers.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(27, 29, 29));
            OpenChildForm(new View.Users());
            ShowSubMenu(subMenuUsers);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(27, 29, 29));
            ShowSubMenu(subMenuLoan);
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            /*escribe
                tu
                codigo
                aqui*/
            OpenChildForm(new View.CreateUser());
            HideSubMenu();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            /*escribe
                tu
                codigo
                aqui*/
            HideSubMenu();
        }

        private void btnConsultLoan_Click(object sender, EventArgs e)
        {
            /*escribe
                tu
                codigo
                aqui*/
            HideSubMenu();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ViewFunctions.ReleaseCapture();
            ViewFunctions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(27, 29, 29));
        }

        private void btnSimulator_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(27, 29, 29));
            OpenChildForm(new View.Simulator());
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(27, 29, 29));
        }
    }
}
