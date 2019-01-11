using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Commno
{
    public class Weather
    {

        [DisplayName("城市")]
        public string City { get; set; }
        [DisplayName("今日日期")]
        public string Date_y { get; set; }
        [DisplayName("星期")]
        public string Week { get; set; }
        [DisplayName("温度")]
        public string Temperature { get; set; }
        [DisplayName("风向")]
        public string Wind { get; set; }
        [DisplayName("穿衣指数")]
        public string Dressing_index { get; set; }
        [DisplayName("穿衣推荐")]
        public string Dressing_advice { get; set; }
        [DisplayName("紫外线强度")]
        public string Uv_index { get; set; }
        [DisplayName("洗车指数")]
        public string Wash_index { get; set; }
        [DisplayName("旅游指数")]
        public string Travel_index { get; set; }
        [DisplayName("晨练指数")]
        public string Exercise_index { get; set; }
        [DisplayName("当前湿度")]
        public string Humidity { get; set; }


    }
}