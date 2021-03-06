﻿using Tests.Infra.JavascriptFrameworkTesterHelper;
using Tests.Infra.WebBrowserEngineTesterHelper.Context;

namespace Tests.Infra.IntegratedContextTesterHelper.Windowless
{
    public interface IWindowLessHTMLEngineProvider
    {
        FrameworkTestContext FrameworkTestContext { get; }

        IBasicWindowLessHTMLEngineProvider WindowBuilder { get; }
    }
}
