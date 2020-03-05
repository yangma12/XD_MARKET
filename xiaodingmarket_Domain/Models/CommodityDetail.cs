using System;
using System.Collections.Generic;
using System.Text;
using xiaodingmarket_Domain_core.Models;

namespace xiaodingmarket_Domain.Models
{
    public class CommodityDetail:Entity
    {
        public CommodityDetail(string detile, string title, List<string> img, double price, string[] kinds, DateTime logTime, bool isDelete)
        {
            Detile = detile;
            Title = title;
            Img = img;
            Price = price;
            Kinds = kinds;
            LogTime = logTime;
            IsDelete = isDelete;
        }

        //public Guid CommodityId { get; private set; }
        /// <summary>
        /// 商品详情
        /// </summary>
        public string Detile { get; set; }
        /// <summary>
        /// 商品标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 商品缩略图地址
        /// </summary>
        public List<string> Img { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 商品分类
        /// </summary>
        public string[] Kinds { get; set; }
        /// <summary>
        /// 商品发布时间
        /// </summary>
        public DateTime LogTime { get; set; }
        /// <summary>
        /// 逻辑删除
        /// </summary>
        public bool IsDelete { get; set; }

    }
}
