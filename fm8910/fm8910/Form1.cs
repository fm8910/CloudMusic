using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fm8910
{
    public partial class Form1 : Form
    {
        public static string search = "http://music.163.com/api/search/get";
        public List<string> enlaceDescarga = new List<string>();
        public static string descargas= "Descargas" + "\\";
        public string s;
        public bool estado = false;
        private bool isProcessRunning = false;
        public int fila;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string carpeta = appPath + "\\" + descargas;
            bool exists = Directory.Exists(carpeta);

            if (!exists)
                Directory.CreateDirectory(carpeta);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
                if (isProcessRunning) {  }
                else
                {
                    Thread backgroundThread = new Thread(
                new ThreadStart(() =>
                {
                    isProcessRunning = true;
                     try
            {
                    var r = Http.Post(search, txt_buscar.Text);
                    s = JObject.Parse(r).SelectToken("result").ToString();
                    var objeto = JsonConvert.DeserializeObject<RootObject>(s);

                    foreach (Canciones value in objeto.songs)
                    {
                        foreach (Artista art in value.artists)
                        {
                            grid_busqueda.BeginInvoke(new Action(() =>
                                {

                                    grid_busqueda.Rows.Add(false, value.name, art.name, value.album.name, value.id.ToString());
                                }
                                ));
                        }
                    }
                    isProcessRunning = false;
            }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Opss No hay nada :( ");
                         isProcessRunning = false;
                     }
                }
                      

            ));
                    if (grid_busqueda.Rows.Count != 0) { grid_busqueda.Rows.Clear(); grid_busqueda.Refresh(); }
                    backgroundThread.Start();

                }
                //var encriptado = Http.encriptar("1326011023131459");
                //MessageBox.Show(encriptado);
         
        }

        private void grid_busqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_busqueda.CurrentCell.ColumnIndex == 0)
            {
                bool chk= (bool)grid_busqueda.Rows[grid_busqueda.CurrentRow.Index].Cells[0].Value;
                if ( chk== false) { 
                    grid_busqueda.Rows[grid_busqueda.CurrentRow.Index].Cells[0].Value = true;
                    
                } 
                else {
                    grid_busqueda.Rows[grid_busqueda.CurrentRow.Index].Cells[0].Value = false;                    
                }
                
            }
        }

        private void btn_cola_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grid_busqueda.Rows)
            {
                if ((bool)row.Cells[0].Value == true)
                {
                    var sonId = row.Cells[4].Value.ToString();
                    var json = JsonConvert.DeserializeObject<DetalleCancion>(getDetalle(sonId));
                    grid_descarga.Rows.Add(json.songs[0].name, json.songs[0].artists[0].name, json.songs[0].album.name, String.Format("{0:0.00}", (double)json.songs[0].hMusic.size / (double)(1024 * 1024)) + " MB", (json.songs[0].hMusic.bitrate / 1000).ToString() + " Kbps", linkMp3(json.songs[0].hMusic.dfsId.ToString()));
                    row.Cells[0].Value = false;
                }
            }
               
            
        }
        public string getDetalle(string id)
        {
            string detalle= String.Format("http://music.163.com/api/song/detail/?id={0}&ids=[{1}]",id,id);
          var result= Http.DetalleCancion(detalle);

          return result;
        }
        public string linkMp3(string dfsId)
        {
            var mp3 = String.Format("http://m1.music.126.net/{0}/{1}.mp3", Http.encriptar(dfsId), dfsId);
            return mp3;
        }

        private void btn_descargar_Click(object sender, EventArgs e)
        {
            if (grid_descarga.Rows.Count != 0)
            {
          getEnlaces();
            }
        }
        public void getEnlaces()
        {
            int c = 0;               
                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + descargas;
                foreach (DataGridViewRow row in grid_descarga.Rows)
                {
                    if (c == 0)
                    {
                        var urlMp3 = row.Cells[5].Value.ToString();
                        var nombre = row.Cells[0].Value.ToString() + ".mp3";
                        WebClient wc = new WebClient();
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Progreso);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completo);
                        wc.DownloadFileAsync(new Uri(urlMp3), appPath + nombre);
                        //wc.DownloadFile(new Uri(urlMp3), appPath + nombre);
                        //grid_descarga.Rows.Remove(row);
                        fila = row.Index;
                        c++;
                    }
                }
                
            
            
        }
        public void Progreso(Object sender, DownloadProgressChangedEventArgs e)
        {
            barra.Value = e.ProgressPercentage;
            
        }
        public void Completo(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("La descarga se Cancelo");
            }
            else
            {
                barra.Value = 0;
                grid_descarga.Rows.RemoveAt(fila);
                getEnlaces();                
            }
        }
    }
}
