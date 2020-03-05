using System;
using System.Collections.Generic;
using System.Text;
using xiaodingmarket_Domain_core.Models;

namespace xiaodingmarket_Domain.Models
{
    public class Reward:AggregateRoot
    {
        /// <summary>
        /// 悬赏详情(实体)
        /// </summary>
        public CommodityDetail CommodityDetail { get; private set; }
        /// <summary>
        /// 卖家基础信息（值）
        /// </summary>
        public CommoditySeller CommoditySeller { get; private set; }
        /// <summary>
        /// 想要人数（点击按钮后再从销售子域中获得具体想要者名单）
        /// </summary>
        public int wanter { get; private set; }
    }
}
