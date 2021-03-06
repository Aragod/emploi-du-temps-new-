﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Emploi_du_temps
{
    public partial class Gestion_des_formateurs : Form
    {
        string connectionString = "Server=localhost;Database=emploi_du_temps;uid=root;pwd=1234";

        public Gestion_des_formateurs()
        {
            InitializeComponent();
        }

        private void Gestion_des_formateurs_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();
            formateurs_dataGridView.Columns["id"].Visible = false;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM metier";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    metier_comboBox.DataSource = binder;
                    metier_comboBox.ValueMember = "id";
                    metier_comboBox.DisplayMember = "nom";
                    metier_comboBox.Text = "";
                }
            }
            metier_comboBox.Text = "";
        }

        private void Nouveau_button_Click(object sender, EventArgs e)
        {
            nom_textBox.Clear();
            prenom_textBox.Clear();
            metier_comboBox.Text = "";
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO formateur(nom, prenom, id_metier) VALUES(@nom, @prenom, @id_metier)";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@prenom", prenom_textBox.Text);
                    command.Parameters.AddWithValue("@id_metier", metier_comboBox.SelectedValue);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Le formateur a été bien ajouté");
                    }
                    else
                    {
                        MessageBox.Show("erreur");
                    }
                }
            }

            RemplirDataGridView();
        }

        private void Modifier_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "update formateur set nom = @nom , prenom = @prenom ,id_metier = @id_metier WHERE id = @id";
                    command.Parameters.AddWithValue("@id", formateurs_dataGridView.CurrentRow.Cells["id"].Value);
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@prenom", prenom_textBox.Text);
                    command.Parameters.AddWithValue("@id_metier", int.Parse(metier_comboBox.SelectedValue.ToString()));

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Formateur modifié");
                    }
                    else
                    {
                        MessageBox.Show("erreur");
                    }
                }
            }

            RemplirDataGridView();
        }

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "DELETE FROM formateur WHERE id = @id";
                    command.Parameters.AddWithValue("@id", formateurs_dataGridView.CurrentRow.Cells["id"].Value);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Formateur supprimé");
                    }
                    else
                    {
                        MessageBox.Show("erreur");
                    }
                }
            }

            RemplirDataGridView();
        }

        private void Formateurs_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nom_textBox.Text = formateurs_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
            prenom_textBox.Text = formateurs_dataGridView.CurrentRow.Cells["prenom"].Value.ToString();
            metier_comboBox.Text = formateurs_dataGridView.CurrentRow.Cells["metier"].Value.ToString();
        }

        private void RemplirDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT F.id, F.nom, F.prenom, M.nom AS metier FROM formateur F JOIN metier M ON F.id_metier = M.id";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    formateurs_dataGridView.DataSource = binder;
                }
            }
        }
    }
}
