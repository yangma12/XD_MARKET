using System;
using System.Collections.Generic;
using System.Text;
using xiaodingmarket_Domain_core.Models;

namespace xiaodingmarket_Domain.Models
{
    public class CommoditySeller : ValueObject<CommoditySeller>
    {
        public CommoditySeller(string studentId, string sellerName, string userPictureSrc)
        {
            StudentId = studentId;
            SellerName = sellerName;
            UserPictureSrc = userPictureSrc;
        }

        /// <summary>
        /// 发布人id
        /// </summary>
        public string StudentId { get; set; }
        /// <summary>
        /// 发布者姓名
        /// </summary>
        public string SellerName { get; set; }
        /// <summary>
        /// 易班头像所在地址
        /// </summary>
        public string UserPictureSrc { get; set; }



        protected override bool EqualsCore(CommoditySeller other)
        {
            return true;
        }

        protected override int GetHashCodeCore()
        {
            return 0;
        }
    }
}
