using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {

        string lat;
        string lon;
        string URL;
        Form2 f2;
        string CIE;
        string selectedItemCIE;
        string selectedItemTimezone;
        bool[] checkBoxCheck = new bool[5] {false,false,false,false,false};


        public Form1()
        {
            InitializeComponent();
        }

        //実行ボタンクリック
        private void startButton_Click(object sender, EventArgs e)
        {
            
            parameters();
            generationURL();
            var f2 = new Form2(URL, checkBoxCheck, CIE);
            f2.ShowDialog();
            

        }

        //入力された緯度経度取得
        public void parameters()
        {
            selectedItemTimezone = timezonecomboBox.SelectedItem.ToString();
            selectedItemCIE = CIEComboBox.SelectedItem.ToString();
            lat = latBox.Text;
            lon = lonBox.Text;

        }

        

        //URLの生成
        public void generationURL()
        {

            if (lon==""&&lat=="") 
            {
                //座標取得
                switch (selectedItemCIE)
                {
                    case "東京":
                        lat = "35";
                        lon = "139";
                        CIE = "東京";
                        break;
                    case "シンガポール":
                        lat = "1";
                        lon = "103";
                        CIE = "シンガポール";
                        break;
                    case "シドニー":
                        lat = "33";
                        lon = "151";
                        CIE = "シドニー";
                        break;
                    case "ニューヨーク":
                        lat = "40";
                        lon = "74";
                        CIE = "ニューヨーク";
                        break;
                    case "シカゴ":
                        lat = "41";
                        lon = "87";
                        CIE = "シカゴ";
                        break;
                    case "ロサンゼルス":
                        lat = "34";
                        lon = "118";
                        CIE = "ロサンゼルス";
                        break;
                    case "ベルリン":
                        lat = "52";
                        lon = "13";
                        CIE = "ベルリン";
                        break;
                    case "ロンドン":
                        lat = "51";
                        lon = "0";
                        CIE = "ロンドン";
                        break;
                    case "モスクワ":
                        lat = "55";
                        lon = "37";
                        CIE = "モスクワ";
                        break;
                }

                URL = "https://api.open-meteo.com/v1/forecast?latitude=" + lat + "&longitude=" + lon;
            }
            else
            {
                URL = "https://api.open-meteo.com/v1/forecast?latitude=" + lat + "&longitude=" + lon;
            }
            
            

            //チェックボックスが1つ以上選択されているかどうか
            if (maxtemCheckBox.Checked == true|| mintemCheckBox.Checked == true|| winspCheckBox.Checked == true)
            {
                //毎日
                URL = URL + "&daily=";
                //天気コード固定
                URL = URL + "weather_code,";

                //最高気温チェックボックスチェック
                if (maxtemCheckBox.Checked == true)
                {
                    URL = URL + "temperature_2m_max,";
                    checkBoxCheck[0] = true;
                }

                //最低気温チェックボックスチェック
                if(mintemCheckBox.Checked == true)
                {
                    URL = URL + "temperature_2m_min,";
                    checkBoxCheck[1] = true;
                }

                //風速チェックボックスチェック
                if(winspCheckBox.Checked == true)
                {
                    URL = URL + "wind_speed_10m_max,";
                    checkBoxCheck[2] = true;
                }

                //降水確率チェックボックスチェック
                if (rainFallParCheckBox.Checked == true)
                {
                    URL = URL + "precipitation_probability_max,";
                    checkBoxCheck[3] = true;
                }

                //紫外線チェックボックスチェック
                if (uvCheckBox.Checked == true)
                {
                    URL = URL + "uv_index_max,";
                    checkBoxCheck[4] = true;
                }
            }

            //パラメーター最後尾のコンマの削除
            URL = URL.TrimEnd(',');
            //Console.WriteLine(URL);
            //Console.ReadLine();

            //天気予報場所
            //string selectedItem = CIEComboBox.SelectedItem.ToString();
            switch (selectedItemTimezone)
            {
                case "東京":
                    URL = URL + "&timezone=Asia%2FTokyo";
                    break;
                case "シンガポール":
                    URL = URL + "&timezone=Asia%2FSingapore";
                    break;
                case "シドニー":
                    URL = URL + "&timezone=Australia%2FSydney";
                    break;
                case "ニューヨーク":
                    URL = URL + "&timezone=America%2FNew_York";
                    break;
                case "シカゴ":
                    URL = URL + "&timezone=America%2FChicago";
                    break;
                case "ロサンゼルス":
                    URL = URL + "&timezone=America%2FLos_Angeles";
                    break;
                case "ベルリン":
                    URL = URL + "&timezone=Europe%2FBerlin";
                    break;
                case "ロンドン":
                    URL = URL + "&timezone=Europe%2FLondon";
                    break;
                case "モスクワ":
                    URL = URL + "&timezone=Europe%2FMoscow";
                    break;
            }

        }

        

        

        //入力項目全リセット
        private void resetButton_Click(object sender, EventArgs e)
        {
            latBox.Text = "";
            lonBox.Text = "";
            maxtemCheckBox.Checked = false;
            mintemCheckBox.Checked = false;
            winspCheckBox.Checked = false;
            rainFallParCheckBox.Checked = false;
            uvCheckBox.Checked = false;
        }

        //プログラム終了
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timezonecomboBox.SelectedIndex = 0;
            latBox.Text= "";
            lonBox.Text= "";
        }

        
    }

            
}
