﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using MicroService.ApiGateway.Localization.MicroService.ApiGateway;
using Volo.Abp.UI.Navigation;

namespace MicroService.ApiGateway.Menus
{
    public class WebServiceMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
            if (context.Menu.Name == StandardMenus.User)
            {
                await ConfigureUserMenuAsync(context);
            }
            if (context.Menu.Name == SideNavBarMenus.LeftSideMenu)
            {
                await ConfigureSideMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<ApiGatewayResource>>();
            await Task.CompletedTask;
        }

        private async Task ConfigureUserMenuAsync(MenuConfigurationContext context)
        {
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<ApiGatewayResource>>();
            context.Menu.Items.Insert(0, new ApplicationMenuItem("WebService.Logout", l["Menu:Logout"], "/Account/Logout"));
            await Task.CompletedTask;
        }

        private async Task ConfigureSideMenuAsync(MenuConfigurationContext context)
        {
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<ApiGatewayResource>>();
            var makeMenu = new ApplicationMenuItem("WebService.Menu.Make", l["Side:Make"], "#");
            makeMenu.AddItem(new ApplicationMenuItem("WebService.Menu.Make.Custom", l["Side:Make:Custom"], "/CustomMade"));


            var baiduChartsMenu = new ApplicationMenuItem("WebService.Menu.Baidu", l["Side:Baidu"], "#");
            baiduChartsMenu.AddItem(new ApplicationMenuItem("WebService.Menu.Baidu.ECharts", l["Side:Baidu:ECharts"], "/BaiduECharts/Index"));


            context.Menu.Items.AddRange(new List<ApplicationMenuItem> { makeMenu , baiduChartsMenu });

            await Task.CompletedTask;
        }
    }
}
