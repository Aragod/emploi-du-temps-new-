namespace Emploi_du_temps
{
    partial class Gestion_des_groupes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreDeGroupes_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valider_button = new System.Windows.Forms.Button();
            this.filiere_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.niveau_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupes_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nombreDeGroupes_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupes_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreDeGroupes_numericUpDown
            // 
            this.nombreDeGroupes_numericUpDown.Location = new System.Drawing.Point(852, 163);
            this.nombreDeGroupes_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.nombreDeGroupes_numericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nombreDeGroupes_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nombreDeGroupes_numericUpDown.Name = "nombreDeGroupes_numericUpDown";
            this.nombreDeGroupes_numericUpDown.ReadOnly = true;
            this.nombreDeGroupes_numericUpDown.Size = new System.Drawing.Size(259, 22);
            this.nombreDeGroupes_numericUpDown.TabIndex = 36;
            this.nombreDeGroupes_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valider_button
            // 
            this.valider_button.Location = new System.Drawing.Point(688, 252);
            this.valider_button.Margin = new System.Windows.Forms.Padding(4);
            this.valider_button.Name = "valider_button";
            this.valider_button.Size = new System.Drawing.Size(100, 55);
            this.valider_button.TabIndex = 35;
            this.valider_button.Text = "Valider";
            this.valider_button.UseVisualStyleBackColor = true;
            this.valider_button.Click += new System.EventHandler(this.Valider_button_Click);
            // 
            // filiere_comboBox
            // 
            this.filiere_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere_comboBox.FormattingEnabled = true;
            this.filiere_comboBox.Location = new System.Drawing.Point(852, 38);
            this.filiere_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.filiere_comboBox.Name = "filiere_comboBox";
            this.filiere_comboBox.Size = new System.Drawing.Size(258, 24);
            this.filiere_comboBox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Filiere:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre de groupes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Niveau:";
            // 
            // niveau_numericUpDown
            // 
            this.niveau_numericUpDown.Location = new System.Drawing.Point(852, 97);
            this.niveau_numericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.niveau_numericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.niveau_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.niveau_numericUpDown.Name = "niveau_numericUpDown";
            this.niveau_numericUpDown.ReadOnly = true;
            this.niveau_numericUpDown.Size = new System.Drawing.Size(259, 22);
            this.niveau_numericUpDown.TabIndex = 30;
            this.niveau_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupes_dataGridView
            // 
            this.groupes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupes_dataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupes_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.groupes_dataGridView.MultiSelect = false;
            this.groupes_dataGridView.Name = "groupes_dataGridView";
            this.groupes_dataGridView.ReadOnly = true;
            this.groupes_dataGridView.RowTemplate.Height = 24;
            this.groupes_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupes_dataGridView.Size = new System.Drawing.Size(600, 353);
            this.groupes_dataGridView.TabIndex = 37;
            this.groupes_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groupes_dataGridView_CellClick);
            // 
            // Gestion_des_groupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 353);
            this.Controls.Add(this.groupes_dataGridView);
            this.Controls.Add(this.nombreDeGroupes_numericUpDown);
            this.Controls.Add(this.valider_button);
            this.Controls.Add(this.filiere_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.niveau_numericUpDown);
            this.Name = "Gestion_des_groupes";
            this.Text = "Gestion_des_groupes";
            this.Load += new System.EventHandler(this.Gestion_des_groupes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nombreDeGroupes_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupes_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nombreDeGroupes_numericUpDown;
        private System.Windows.Forms.Button valider_button;
        private System.Windows.Forms.ComboBox filiere_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown niveau_numericUpDown;
        private System.Windows.Forms.DataGridView groupes_dataGridView;
    }
}