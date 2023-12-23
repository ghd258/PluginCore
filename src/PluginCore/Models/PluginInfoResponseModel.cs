//===================================================
//  License: GNU LGPLv3
//  Contributors: yiyungent@gmail.com
//  Project: https://moeci.com/PluginCore
//  GitHub: https://github.com/yiyungent/PluginCore
//===================================================



﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PluginCore.Models
{
    public class PluginInfoResponseModel : PluginInfoModel
    {
        /// <summary>
        /// 插件状态
        /// </summary>
        public PluginStatus Status { get; set; }
    }

    public enum PluginStatus
    {
        Enabled = 0,
        Disabled = 1
    }
}

