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
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;


namespace ComputerVision01
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
                    string apiUrl, apiKey, imgPath;
                    apiUrl = "";
                    apiKey = "";
                    //將開檔對話方塊的圖檔路徑指定給imgPath
                    label1.Text = imgPath  = openFileDialog1.FileName;


                    //使用FileStream物件fs開啟圖檔
                    FileStream fs = File.Open(imgPath, FileMode.Open);

                    //建立ComputerVisionClient物件，同時指定雲端服務Key
                    ComputerVisionClient visionClient =
                        new ComputerVisionClient(
                          new ApiKeyServiceClientCredentials(apiKey),
                          new System.Net.Http.DelegatingHandler[] { });

                    //指定ComputerVisionClient物件的雲端服務Api位址
                    visionClient.Endpoint = apiUrl;

                    //傳回辨識分析結果
                    ImageDescription result = await visionClient.DescribeImageInStreamAsync(fs);

                    // 若辨識失敗傳回null，並顯示錯誤訊息，同時離開此事件
                    if (result == null)
                    {
                        richTextBox1.Text = "辨識失敗，請重新指定圖檔";
                        return;
                    }

                    // 進行圖片的辨識的內容顯示於richTextBox1
                    string tags = "";
                    for (int i = 0; i < result.Tags.Count(); i++)
                    {
                        tags += $"{ result.Tags[i]}, ";
                    }
                    richTextBox1.Text = $"標籤：{tags}\n" +
                        $"圖片描述：{result.Captions[0].Text}\n" +
                        $"圖片描述信度：{result.Captions[0].Confidence}";
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
