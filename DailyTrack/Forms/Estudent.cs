﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyTrack.Forms
{
    public partial class Estudent : Form
    {
        private bool showPassword = false;
        public Estudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inicio nuevoFormulario = new Inicio();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

            // Limitar la contraseña a un máximo de 8 caracteres
            if (tbPassword.Text.Length > 8)
            {
                MessageBox.Show("La contraseña no puede tener más de 8 caracteres.");
                tbPassword.Text = tbPassword.Text.Substring(0, 8);
                tbPassword.SelectionStart = tbPassword.Text.Length; // Mover el cursor al final
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbUser.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor, ingrese solo números.");
                tbUser.Text = string.Empty;
            }
        }

        private void pbShowpassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                tbPassword.PasswordChar = '\0';
                pbShowpassword.Image = DailyTrack.Properties.Resources.ojo;

            }
            else
            {
                tbPassword.PasswordChar = '*';
                pbShowpassword.Image = DailyTrack.Properties.Resources.ojos_cruzados;

            }
        }

        private void Estudent_Load(object sender, EventArgs e)
        {

        }

        private void btnforgetPass_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese su número de cuenta.");
            }
            else
            {
                MessageBox.Show("Se ha enviado un correo a su dirección de correo electrónico.");
            }
        }
    }
}
