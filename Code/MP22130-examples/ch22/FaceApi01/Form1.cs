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
using Newtonsoft.Json;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;


namespace FaceApi01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        // 按 [開檔] 鈕執行
        private async void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 指定Face API臉部辨識服務的金鑰與服務端點
                    string apiUrl, apiKey,  imgPath;
                    apiUrl = "";
                    apiKey = "";

                    //將開檔對話方塊的圖檔路徑指定給imgPath和label1.Text
                    label1.Text = imgPath = openFileDialog1.FileName;

                    //使用FileStream物件fs開啟圖檔
                    FileStream fs = File.OpenRead(imgPath);

                    //建立FaceClient物件，同時指定的服務金鑰Key
                    FaceClient faceClient = new FaceClient(
                        new ApiKeyServiceClientCredentials(apiKey),
                        new System.Net.Http.DelegatingHandler[] { });

                    //FaceClient物件指定服務Api位址
                    faceClient.Endpoint = apiUrl;

                    // 宣告DetectedFace物件泛型介面
                    IList<DetectedFace> detectedFaces = null;

                    // 臉部偵測模型採用 Detection03，只能提供臉部偵測位置與FaceId
                    detectedFaces = await faceClient.Face.DetectWithStreamAsync(fs,
                        detectionModel: DetectionModel.Detection03,
                        recognitionModel: RecognitionModel.Recognition04);

                    // 若辨識失敗傳回null，並顯示錯誤訊息，同時離開此事件
                    if (detectedFaces == null)
                    {
                        richTextBox1.Text = "辨識失敗，請重新指定圖檔";
                        return;
                    }

                    //將圖片中人臉的位置指定給str
                    string str = $"影像中共有 {detectedFaces.Count()} 人\n";
                    for(int i=0; i<detectedFaces.Count(); i++)
                    {
                        str += $"\t第 {i+1} 人臉部位置=>" +
                            $"Left={detectedFaces[i].FaceRectangle.Left}, " +
                            $"Top={detectedFaces[i].FaceRectangle.Top}," +
                            $"Width={detectedFaces[i].FaceRectangle.Width}," +
                            $"Height={detectedFaces[i].FaceRectangle.Height}\n";
                    }
                    // 將圖片分析結果顯示於richTextBox1
                    richTextBox1.Text = str;

                    //將圖片分析結果轉成JSON字串並顯示在richTextBox2
                    richTextBox2.Text = JsonConvert.SerializeObject(detectedFaces);

                    //pictureBox1顯示指定的圖片
                    pictureBox1.Image = new Bitmap(imgPath);
                    //釋放影像串流資源
                    fs.Close();
                    fs.Dispose();
                    GC.Collect();
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = ex.Message;
                }
            }
        }
    }
}
