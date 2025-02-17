﻿using BiliLite.Pages;
using System.Threading.Tasks;

namespace BiliLite.Models.Functions
{
    public class ToggleFullscreenShortcutFunction : BaseShortcutFunction
    {
        public override string Name { get; } = "切换全屏";

        public override async Task Action(object param)
        {
            if (!(param is PlayPage page)) return;
            page.ToggleFullscreen();
        }
    }
}
