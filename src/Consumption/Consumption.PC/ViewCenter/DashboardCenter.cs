﻿/*
*
* 文件名    ：DashboardCenter                             
* 程序说明  : 仪表板控制类 
* 更新时间  : 2020-06-07 17：37
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/

namespace Consumption.PC.ViewCenter
{
    using Consumption.PC.View;
    using Consumption.Shared.Common.Attributes;
    using Consumption.Shared.Common.Enums;
    using Consumption.ViewModel;
    using Consumption.ViewModel.Interfaces;

    /// <summary>
    /// 仪表板控制类
    /// </summary>
    [Module("仪表板", ModuleType.应用中心)]
    public class DashboardCenter : ComponentCenter<DashboardView>,IDashboardCenter
    {
        public DashboardCenter(IDashboardViewModel viewModel) : base(viewModel) { }
    }
}
