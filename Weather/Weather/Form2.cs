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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form2 : Form
    {
        string URL2;
        string timezone2;
        bool[] checkBoxCheck2 = new bool[5] { false, false, false, false, false };
        Stream responseStream;

        public Form2(string URL, bool[] checkBoxCheck,string timezone)
        {
            InitializeComponent();
            URL2 = URL;
            checkBoxCheck2 = checkBoxCheck;
            timezone2 = timezone;
            accessURL();
            getInformationView();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        //URLの取得
        public void accessURL()
        {
            WebRequest request = WebRequest.Create(URL2);
            responseStream = request.GetResponse().GetResponseStream();
        }

        //天気情報取得、表示
        public void getInformationView()
        {
            StreamReader reader = new StreamReader(responseStream);
            var obj_from_json = JObject.Parse(reader.ReadToEnd());




            //表示

            for (int i=0; i < 7; i++) {

                //天気コード取得
                var weatherCode = obj_from_json["daily"]["weather_code"][i];

                //日付取得
                var date = obj_from_json["daily"]["time"][i];

                //タイトル表示
                titelLabel.Text = timezone2 + "の天気";



                //日付、天気コード表示
                dateLabel.Text = dateLabel.Text + "\n" + date;
                //天気コード表示
                weatherCodelabel.Text = weatherCodelabel.Text + "\n" + weatherCode;

                //チェックボックスパラメーター取得
                for (int j = 0; j < 5; j++) {
                    if (checkBoxCheck2[j] == true)
                    {
                        switch (j)
                        {
                            case 0:
                                var maxtem = obj_from_json["daily"]["temperature_2m_max"][i];
                                temMaxlabel.Text = temMaxlabel.Text + "\n" + maxtem;
                                break;
                            case 1:
                                var mintem = obj_from_json["daily"]["temperature_2m_min"][i];
                                temMinLabel.Text = temMinLabel.Text + "\n" + mintem;
                                break;
                            case 2:
                                var winsp = obj_from_json["daily"]["wind_speed_10m_max"][i];
                                windSpeedLabel.Text = windSpeedLabel.Text + "\n" + winsp;
                                break;
                            case 3:
                                var rainFallPar = obj_from_json["daily"]["precipitation_probability_max"][i];
                                rainFallParLabel.Text = rainFallParLabel.Text + "\n" + rainFallPar;
                                break;
                            case 4:
                                var uv = obj_from_json["daily"]["uv_index_max"][i];
                                uvLabel.Text = uvLabel.Text + "\n" + uv;
                                break;
                        }
                    }

                }

                //天気コード変換




                //+"┃" + "\r\n"




                dateLabel.Text = dateLabel.Text + "\n";
                weatherCodelabel.Text = weatherCodelabel.Text + "\n";
                temMaxlabel.Text= temMaxlabel.Text + "\n";
                temMinLabel.Text= temMinLabel.Text + "\n";
                windSpeedLabel.Text= windSpeedLabel.Text+ "\n";
                rainFallParLabel.Text=rainFallParLabel.Text + "\n";
                uvLabel.Text= uvLabel.Text+ "\n";
            }
            
            

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
