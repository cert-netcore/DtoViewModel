using System;
using System.Collections.Generic;
using System.Text;

namespace DtoViewModel.Models
{
    public class Property
    {
        /// <summary>
        /// 属性列表
        /// </summary>
        protected IEnumerable<string> Properties { get; set; }
        /// <summary>
        /// 类名
        /// </summary>
        protected string ClassName { get; set; }
        /// <summary>
        /// 属性与类型字典
        /// </summary>
        protected Dictionary<Type,string> Pt { get; set; }


    }
}
