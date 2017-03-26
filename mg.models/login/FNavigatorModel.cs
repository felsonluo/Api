using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace mg.models
{
    [DataContract]
    public class FNavigatorModel
    {

        /// <summary>
        /// 多语言对应的值
        /// </summary>
        [DataMember(Name = "nameKey")]
        public string FNameKey { get; set; }

        /// <summary>
        /// 样式
        /// </summary>
        [DataMember(Name = "className")]
        public string FClassName { get; set; }


        /// <summary>
        /// 点击的时候的链接
        /// </summary>
        [DataMember(Name = "url")]
        public string FUrl { get; set; }


        [DataMember(Name = "children")]
        public IEnumerable<FNavigatorModel> MChildren { get; set; }
    }
}
