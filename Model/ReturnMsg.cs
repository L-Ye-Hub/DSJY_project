﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReturnMsg
    {
        /// <summary>
        /// 状态码,主要用得到对应的信息,以后通过这个内容进行判断 操作是否完成 
        /// </summary>
        public StatusCode Code { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
