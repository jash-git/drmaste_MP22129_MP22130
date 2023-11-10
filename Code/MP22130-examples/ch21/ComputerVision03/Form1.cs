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
using Newtonsoft.Json.Linq;

namespace ComputerVision03
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

                    // 指定要分析的列舉項目(視覺特徵)，並將分析的列舉存入visualFeatures陣列
                    VisualFeatureTypes?[] visualFeatures = new VisualFeatureTypes?[]
                    {
                        VisualFeatureTypes.ImageType,    //影像類型
                        VisualFeatureTypes.Color,	            //顏色資訊
                        VisualFeatureTypes.Faces,	            //臉部資訊
                        VisualFeatureTypes.Adult,	            //成人資訊
                        VisualFeatureTypes.Categories,	    //影像分類
                        VisualFeatureTypes.Tags,	            //影像中的項目
                        VisualFeatureTypes.Description     //影像描述
                    };

                    //傳回辨識分析結果
                    ImageAnalysis result = await visionClient.AnalyzeImageInStreamAsync(fs,visualFeatures);

                    // 若辨識失敗傳回null，並顯示錯誤訊息，同時離開此事件
                    if (result == null)
                    {
                        richTextBox1.Text = "辨識失敗，請重新指定圖檔";
                        return;
                    }

                    // 將圖片的標籤資訊與信度指定給str字串
                    string str = "標籤與信度：\n";
                    for (int i = 0; i < result.Tags.Count(); i++)
                    {
                        str += $"\t{ result.Tags[i].Name}\t{result.Tags[i].Confidence}\n";
                    }
                    //將圖片的說明與信度、成人資訊指定給str
                    if(result.Description != null)
                    {
                        for (int i = 0; i < result.Description.Captions.Count; i++)
                        {
                            str += $"圖片說明：{result.Description.Captions[i].Text}\n";
                            str += $"圖片說明信度：{result.Description.Captions[i].Confidence}\n";
                            str += $"成人資訊：{result.Adult.IsAdultContent}\n";
                            str += $"成人分數：{result.Adult.AdultScore}\n";
                        }
                    }

                    // 將圖片分析結果顯示於richTextBox
                    richTextBox1.Text = str;

                    //將圖片分析結果轉成JSON字串並顯示在richTextBox2
                    string jsonStr =  JsonConvert.SerializeObject(result);
                    //JSON字串格式化
                    richTextBox2.Text = JObject.Parse(jsonStr).ToString();
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
