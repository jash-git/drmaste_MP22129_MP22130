using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CustomVision01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 使用者選擇圖檔
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imgPath = openFileDialog1.FileName;
                    pictureBox1.Image = new Bitmap(imgPath);

                    string apiUrl = "";
                    string apiKey = "";

                    //建立HttpClient物件client同時指定服務金鑰
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("Prediction-Key", apiKey);

                    // 指定本機要分析的影像圖檔
                    FileStream fileStream = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] byteData = binaryReader.ReadBytes((int)fileStream.Length);
                    ByteArrayContent content = new ByteArrayContent(byteData);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    // 執行 REST API 呼叫並傳送影像資料content
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    // 取得影像偵測結果，其結果以JSON字串傳回
                    string jsonStr = await response.Content.ReadAsStringAsync();
                    // 格式化JSON資料顯示於richTextBox1
                    richTextBox1.Text = JObject.Parse(jsonStr).ToString();
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = ex.Message;
                }
            }
        }
    }
}
