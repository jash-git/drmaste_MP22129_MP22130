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
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace FaceApi04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string apiUrl, apiKey;

        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            apiUrl = "";
            apiKey = "";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        //上傳照片並取得 Face Id
        private async Task<string> GetFaceId(string _imgPath, string _apiUrl, string _apiKey)
        {
            //使用FileStream物件fs開啟圖檔
            FileStream fs = File.OpenRead(_imgPath);

            //建立FaceClient物件，同時指定的服務Key
            FaceClient faceClient = new FaceClient(
                new ApiKeyServiceClientCredentials(apiKey),
                new System.Net.Http.DelegatingHandler[] { });

            //FaceClient物件指定服務Api位址
            faceClient.Endpoint = apiUrl;

            // 宣告DetectedFace泛型介面物件
            IList<DetectedFace> detectedFaces = await faceClient.Face.DetectWithStreamAsync(fs,
                        detectionModel: DetectionModel.Detection03,
                        recognitionModel: RecognitionModel.Recognition04);
            if (detectedFaces.Count > 0)
            {
                return detectedFaces[0].FaceId.ToString();
            }
            else
            {
                return "無法辨識，請重新選擇一張照片";
            }
        }

        // [開檔1] 鈕事件處理函式
        private async void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                label1.Text = await GetFaceId(openFileDialog1.FileName, apiUrl, apiKey);
            }
        }

        // [開檔2] 鈕事件處理函式
        private async void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
                label2.Text = await GetFaceId(openFileDialog1.FileName, apiUrl, apiKey);
            }
        }


        private async void BtnVerifyFace_Click(object sender, EventArgs e)
        {
            // 兩個FaceId傳送到Azure服務進行比較
            FaceClient faceClient = new FaceClient(
                new ApiKeyServiceClientCredentials(apiKey),
                new System.Net.Http.DelegatingHandler[] { });
            faceClient.Endpoint = apiUrl;
            VerifyResult result = await faceClient.Face.VerifyFaceToFaceAsync(System.Guid.Parse(label1.Text), System.Guid.Parse(label2.Text));
            string msg = $"是否為同一人：{ result.IsIdentical}, 相似度：{result.Confidence}";
            MessageBox.Show(msg);
        }
    }
}
