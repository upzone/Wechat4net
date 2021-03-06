﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Wechat4net.Define;
using Wechat4net.Utils;

namespace Wechat4net.QY.Define.ReceiveMessage
{
    /// <summary>
    /// Text 消息类型
    /// </summary>
    public class Text : Base
    {
        public Text() { }
        
        /// <summary>
        /// 文本消息内容
        /// </summary>
        public string Content { set; get; }
        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        [XmlProperty("MsgId")]
        public Int64 MsgID { set; get; }
    }
}
