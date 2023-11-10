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

namespace ComputerVision05
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
                    label1.Text = imgPath = openFileDialog1.FileName;

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
                    ImageAnalysis result = await visionClient.AnalyzeImageInStreamAsync(fs, visualFeatures);

                    // 若辨識失敗傳回null，並顯示錯誤訊息，同時離開此事件
                    if (result == null)
                    {
                        richTextBox1.Text = "辨識失敗，請重新指定圖檔";
                        return;
                    }

                    string str = "圖片分析結果：\n";
                    //將圖片的說明與信度、成人資訊指定給str
                    if (result.Description != null)
                    {
                        for (int i = 0; i < result.Description.Captions.Count; i++)
                        {
                            str += $"圖片說明：{result.Description.Captions[i].Text}\n";
                            str += $"圖片說明信度：{result.Description.Captions[i].Confidence}\n";
                        }
                    }

                    if(result.Categories[0].Detail == null)
                    {
                        str += "\n圖片中無名人也無地標";
                    }
                    else
                    {
                        //將名人資訊指定給str
                        if (result.Categories[0].Detail.Celebrities != null && result.Categories[0].Detail.Celebrities.Count()>0)
                        {
                            str += "\n名人名字與信度：\n";
                            for (int i = 0; i < result.Categories[0].Detail.Celebrities.Count(); i++)
                            {
                                str += $"\t{result.Categories[0].Detail.Celebrities[i].Name}\t{result.Categories[0].Detail.Celebrities[i].Confidence}\n";
                            }
                        }
                        //將地標資訊指定給str
                        if (result.Categories[0].Detail.Landmarks != null && result.Categories[0].Detail.Landmarks.Count()>0)
                        {
                            str += "\n地標名稱與信度：\n";
                            for (int i = 0; i < result.Categories[0].Detail.Landmarks.Count(); i++)
                            {
                                str += $"\t{result.Categories[0].Detail.Landmarks[i].Name}\t{result.Categories[0].Detail.Landmarks[i].Confidence}\n";
                            }
                        }
                    }

                    // 將圖片分析結果顯示於richTextBox
                    richTextBox1.Text = str;

                    //將圖片分析結果轉成JSON字串並顯示在richTextBox2
                    string jsonStr = JsonConvert.SerializeObject(result);
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
