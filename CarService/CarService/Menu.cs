using QRCoder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarService
{
    public partial class Menu : Form
    {
        Dictionary<string, int> infoForm = new Dictionary<string, int>();
        DataBase dataBase = new DataBase();
        public Menu(Dictionary<string, int> infoForm)
        {
            InitializeComponent();
            this.infoForm = infoForm;

            switch(infoForm["rol"]){
                case 1:
                    buttonHistory.Visible = true;
                    break;
                case 2:
                    buttonHistory.Visible = false;
                    buttonUsers.Visible = false;
                    break;
                case 3:
                    buttonHistory.Visible = false;
                    labelQR.Visible = true;
                    pictureBoxQR.Visible = true;
                    GenereteQR(@"https://uquiz.com/quiz/bxuzI3/%D0%9A%D1%82%D0%BE-%D1%82%D1%8B-%D0%B8%D0%B7-%D0%BC%D1%83%D0%BB%D1%8C%D1%82%D1%81%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D0%B0-%C2%AB%D0%9A%D0%BB%D1%83%D0%B1-%D0%92%D0%B8%D0%BD%D0%BA%D1%81%C2%BB?ysclid=m35q00t6k1147295576");
                    buttonUsers.Visible = false;
                    break;
                case 4:
                    buttonHistory.Visible = true;
                    buttonUsers.Visible = true;
                    break;
            }
        }

        private void GenereteQR(string url)
        {
            QRCodeGenerator codeGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = codeGenerator.CreateQrCode (url, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qrCodeData);
            Bitmap qrIm = qRCode.GetGraphic(10);
            pictureBoxQR.Image = qrIm;
        }

        private void buttonAuthoriz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[0].Activate();
            this.Dispose();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Request"))
                Application.OpenForms["Request"].Dispose();
            Form frm = new Request(infoForm);
            frm.Show();
            this.Dispose();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[0].Activate();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "History"))
                Application.OpenForms["History"].Dispose();
            Form frm = new History(infoForm);
            frm.Show();
            this.Dispose();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Users"))
                Application.OpenForms["Users"].Dispose();
            Form frm = new Users(infoForm);
            frm.Show();
            this.Dispose();
        }
    }
}
