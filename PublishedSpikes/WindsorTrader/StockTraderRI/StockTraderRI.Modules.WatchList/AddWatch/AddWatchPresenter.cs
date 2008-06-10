//===============================================================================
// Microsoft patterns & practices
// Composite WPF (PRISM)
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================

using Castle.Core;
using StockTraderRI.Modules.Watch.Services;

namespace StockTraderRI.Modules.Watch.AddWatch
{
    public class AddWatchPresenter : IAddWatchPresenter
    {
        public AddWatchPresenter(IAddWatchView view, IWatchListService service)
        {
            View = view;
            View.SetAddWatchCommand(service.AddWatchCommand);
        }

        // Windsor throws an error when reflecting on private setters.
        [DoNotWire]
        public IAddWatchView View { get; private set; }
    }
}