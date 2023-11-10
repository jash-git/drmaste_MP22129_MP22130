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
using Newtonsoft.Json;

namespace FaceApi03
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
                    FileStream fs = File.OpenRead(imgPath);

                    //建立FaceClient物件，同時指定的服務Key
                    FaceClient faceClient = new FaceClient(
                        new ApiKeyServiceClientCredentials(apiKey),
                        new System.Net.Http.DelegatingHandler[] { });

                    //FaceClient物件指定雲端Api位址
                    faceClient.Endpoint = apiUrl;

                    // 宣告DetectedFace泛型介面物件
                    IList<DetectedFace> detectedFaces = null;

                    // 指定faceAttributeTypes要傳回的臉部屬性
                    IList<FaceAttributeType> faceAttributeTypes  = new List<FaceAttributeType> {
                        FaceAttributeType.Accessories, //配件
                        FaceAttributeType.Age,              //年齡
                        FaceAttributeType.Emotion,      //表情
                        FaceAttributeType.FacialHair,    //臉部毛髮
                        FaceAttributeType.Gender,       //性別
                        FaceAttributeType.Glasses,     //眼鏡
                        FaceAttributeType.Hair,          //頭髮
                        FaceAttributeType.HeadPose,  //頭部姿勢
                        FaceAttributeType.Makeup,     //化妝
                        FaceAttributeType.Occlusion,  //咬合
                        FaceAttributeType.Smile    //微笑
                    };

                    // 偵測臉部模型採用 Detection01，指定所有的臉部屬性faceAttributeTypes
                    detectedFaces = await faceClient.Face.DetectWithStreamAsync(fs,
                        returnFaceAttributes: faceAttributeTypes,
                        detectionModel: DetectionModel.Detection01,
                        recognitionModel: RecognitionModel.Recognition04);

                    // 若辨識失敗傳回null，並顯示錯誤訊息，同時離開此事件
                    if (detectedFaces == null)
                    {
                        richTextBox1.Text = "辨識失敗，請重新指定圖檔";
                        return;
                    }

                    //將圖片中人臉的位置指定給str
                    string str = $"影像中共有 {detectedFaces.Count()} 人\n";
                    for (int i = 0; i < detectedFaces.Count(); i++)
                    {
                        str += $"第 {i + 1} 人臉部資訊=>\n" +
                            $"\t性別：{detectedFaces[i].FaceAttributes.Gender}\n" +
                            $"\t年齡：{detectedFaces[i].FaceAttributes.Age}\n" +
                            $"\t配載眼鏡：{detectedFaces[i].FaceAttributes.Glasses}\n" +
                            $"\t快樂程度：{detectedFaces[i].FaceAttributes.Emotion.Happiness}\n" +
                            $"\t生氣程度：{detectedFaces[i].FaceAttributes.Emotion.Anger}\n";
                    }
                    // 將圖片分析結果顯示於richTextBox
                    richTextBox1.Text = str;

                    //將圖片分析結果轉成JSON字串並顯示在richTextBox2
                    richTextBox2.Text = JsonConvert.SerializeObject(detectedFaces);

                    //pictureBox1顯示指定的圖片
                    pictureBox1.Image = new Bitmap(imgPath);

                    //重繪pictureBox1
                    pictureBox1.Refresh();


                    // 取得原圖和pictureBox1的寬高
                    float floPhysicalWidth = pictureBox1.Image.PhysicalDimension.Width;
                    float floPhysicalHeight = pictureBox1.Image.PhysicalDimension.Height;
                    int intVedioWidth = pictureBox1.Width;
                    int intVedioHeight = pictureBox1.Height;

                    //在pictureBox1的人臉上畫出矩形
                    Graphics g = pictureBox1.CreateGraphics();
                    Pen p = new Pen(Color.Red, 2);
                    int left, top, width, height;
                    for (int i = 0; i < detectedFaces.Count; i++)
                    {
                        // 依比例找出實際pictureBox1要畫矩形的範圍(left, top, width, height)
                        left = (int)(intVedioWidth * detectedFaces[i].FaceRectangle.Left / floPhysicalWidth);
                        top = (int)(intVedioHeight * detectedFaces[i].FaceRectangle.Top / floPhysicalHeight);
                        width = (int)(intVedioWidth * detectedFaces[i].FaceRectangle.Width / floPhysicalWidth);
                        height = (int)(intVedioHeight * detectedFaces[i].FaceRectangle.Height / floPhysicalHeight);
                        g.DrawRectangle(p, left, top, width, height);
                    }

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
