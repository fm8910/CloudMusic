namespace fm8910
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_cola = new System.Windows.Forms.Button();
            this.grid_busqueda = new System.Windows.Forms.DataGridView();
            this.btn_descargar = new System.Windows.Forms.Button();
            this.grid_descarga = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bq_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bq_artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bq_album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bq_songID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdes_titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdes_artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdes_album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdes_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdes_bitraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdes_mp3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barra = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descarga)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.btn_cola);
            this.splitContainer1.Panel1.Controls.Add(this.grid_busqueda);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.barra);
            this.splitContainer1.Panel2.Controls.Add(this.btn_descargar);
            this.splitContainer1.Panel2.Controls.Add(this.grid_descarga);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 480);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.TabIndex = 3;
            // 
            // btn_cola
            // 
            this.btn_cola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cola.Location = new System.Drawing.Point(223, 438);
            this.btn_cola.Name = "btn_cola";
            this.btn_cola.Size = new System.Drawing.Size(283, 29);
            this.btn_cola.TabIndex = 6;
            this.btn_cola.Text = "Añadir a la cola de descargas";
            this.btn_cola.UseVisualStyleBackColor = true;
            this.btn_cola.Click += new System.EventHandler(this.btn_cola_Click);
            // 
            // grid_busqueda
            // 
            this.grid_busqueda.AllowUserToAddRows = false;
            this.grid_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_busqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion,
            this.bq_titulo,
            this.bq_artista,
            this.bq_album,
            this.bq_songID});
            this.grid_busqueda.Location = new System.Drawing.Point(3, 3);
            this.grid_busqueda.Name = "grid_busqueda";
            this.grid_busqueda.ReadOnly = true;
            this.grid_busqueda.RowHeadersVisible = false;
            this.grid_busqueda.Size = new System.Drawing.Size(519, 429);
            this.grid_busqueda.TabIndex = 0;
            this.grid_busqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_busqueda_CellContentClick);
            // 
            // btn_descargar
            // 
            this.btn_descargar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_descargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descargar.Location = new System.Drawing.Point(137, 438);
            this.btn_descargar.Name = "btn_descargar";
            this.btn_descargar.Size = new System.Drawing.Size(219, 29);
            this.btn_descargar.TabIndex = 7;
            this.btn_descargar.Text = "Descargar";
            this.btn_descargar.UseVisualStyleBackColor = true;
            this.btn_descargar.Click += new System.EventHandler(this.btn_descargar_Click);
            // 
            // grid_descarga
            // 
            this.grid_descarga.AllowUserToAddRows = false;
            this.grid_descarga.AllowUserToDeleteRows = false;
            this.grid_descarga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_descarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_descarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdes_titulo,
            this.gdes_artista,
            this.gdes_album,
            this.gdes_size,
            this.gdes_bitraje,
            this.gdes_mp3});
            this.grid_descarga.Location = new System.Drawing.Point(3, 39);
            this.grid_descarga.Name = "grid_descarga";
            this.grid_descarga.ReadOnly = true;
            this.grid_descarga.RowHeadersVisible = false;
            this.grid_descarga.Size = new System.Drawing.Size(503, 393);
            this.grid_descarga.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(12, 28);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(873, 29);
            this.txt_buscar.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(901, 28);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(109, 29);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // seleccion
            // 
            this.seleccion.HeaderText = "";
            this.seleccion.Name = "seleccion";
            this.seleccion.ReadOnly = true;
            this.seleccion.Width = 50;
            // 
            // bq_titulo
            // 
            this.bq_titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bq_titulo.HeaderText = "Titulo";
            this.bq_titulo.Name = "bq_titulo";
            this.bq_titulo.ReadOnly = true;
            // 
            // bq_artista
            // 
            this.bq_artista.HeaderText = "Artista";
            this.bq_artista.Name = "bq_artista";
            this.bq_artista.ReadOnly = true;
            this.bq_artista.Width = 150;
            // 
            // bq_album
            // 
            this.bq_album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bq_album.HeaderText = "Album";
            this.bq_album.Name = "bq_album";
            this.bq_album.ReadOnly = true;
            // 
            // bq_songID
            // 
            this.bq_songID.HeaderText = "";
            this.bq_songID.Name = "bq_songID";
            this.bq_songID.ReadOnly = true;
            this.bq_songID.Visible = false;
            // 
            // gdes_titulo
            // 
            this.gdes_titulo.HeaderText = "Titulo";
            this.gdes_titulo.Name = "gdes_titulo";
            this.gdes_titulo.ReadOnly = true;
            // 
            // gdes_artista
            // 
            this.gdes_artista.HeaderText = "Artista";
            this.gdes_artista.Name = "gdes_artista";
            this.gdes_artista.ReadOnly = true;
            // 
            // gdes_album
            // 
            this.gdes_album.HeaderText = "Album";
            this.gdes_album.Name = "gdes_album";
            this.gdes_album.ReadOnly = true;
            // 
            // gdes_size
            // 
            this.gdes_size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gdes_size.HeaderText = "Tamaño";
            this.gdes_size.Name = "gdes_size";
            this.gdes_size.ReadOnly = true;
            // 
            // gdes_bitraje
            // 
            this.gdes_bitraje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gdes_bitraje.HeaderText = "Bitrate";
            this.gdes_bitraje.Name = "gdes_bitraje";
            this.gdes_bitraje.ReadOnly = true;
            // 
            // gdes_mp3
            // 
            this.gdes_mp3.HeaderText = "Enlace";
            this.gdes_mp3.Name = "gdes_mp3";
            this.gdes_mp3.ReadOnly = true;
            this.gdes_mp3.Visible = false;
            // 
            // barra
            // 
            this.barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barra.Location = new System.Drawing.Point(3, 3);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(503, 30);
            this.barra.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 532);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music download";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView grid_busqueda;
        private System.Windows.Forms.DataGridView grid_descarga;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cola;
        private System.Windows.Forms.Button btn_descargar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn bq_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bq_artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn bq_album;
        private System.Windows.Forms.DataGridViewTextBoxColumn bq_songID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdes_titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdes_artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdes_album;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdes_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdes_bitraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn gdes_mp3;
        private System.Windows.Forms.ProgressBar barra;
    }
}

