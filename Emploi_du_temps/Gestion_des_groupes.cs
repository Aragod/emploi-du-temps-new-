﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Emploi_du_temps
{
    public partial class Gestion_des_groupes : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=1234;database=emploi_du_temps";
        string[] lettres = new string[] { "A", "B", "C", "D", "E", "F" };

        public Gestion_des_groupes()
        {
            InitializeComponent();
        }

        private void Gestion_des_groupes_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();

            // Remplir Filiere_comboBox
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM filiere";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    filiere_comboBox.DataSource = binder;
                    filiere_comboBox.ValueMember = "id";
                    filiere_comboBox.DisplayMember = "nom";
                }
            }
        }

        private void Groupes_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filiere_comboBox.Text = groupes_dataGridView.CurrentRow.Cells["filiere"].Value.ToString();
            niveau_numericUpDown.Value = int.Parse(groupes_dataGridView.CurrentRow.Cells["niveau"].Value.ToString());
            nombreDeGroupes_numericUpDown.Value = int.Parse(groupes_dataGridView.CurrentRow.Cells["nombre"].Value.ToString());
        }

        private void Valider_button_Click(object sender, EventArgs e)
        {
            // Delete if groupes already exist
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "DELETE FROM groupe WHERE id_filiere=@id_filiere AND niveau=@niveau";
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    command.Parameters.AddWithValue("@id_filiere", int.Parse(filiere_comboBox.SelectedValue.ToString()));
                    command.ExecuteNonQuery();
                }
            }

            // Insert the groupes
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    for (int i = 0; i < nombreDeGroupes_numericUpDown.Value; i++)
                    {
                        command.CommandText = "INSERT INTO groupe (nom, niveau, id_filiere, chaine) VALUES (@nom, @niveau, @id_filiere, @chaine)";
                        command.Parameters.AddWithValue("@nom", lettres[i]);
                        command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                        command.Parameters.AddWithValue("@id_filiere", int.Parse(filiere_comboBox.SelectedValue.ToString()));
                        command.Parameters.AddWithValue("@chaine", filiere_comboBox.Text + niveau_numericUpDown.Value.ToString() + lettres[i]);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("ok");
                        }
                        command.Parameters.Clear();
                    }

                }
            }

            RemplirDataGridView();
        }

        private void RemplirDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT F.nom as filiere, niveau, count(G.id) as nombre FROM groupe G JOIN filiere F ON G.id_filiere = F.id GROUP BY id_filiere, niveau ORDER BY F.nom, niveau";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    groupes_dataGridView.DataSource = binder;
                }
            }
        }
    }
}
