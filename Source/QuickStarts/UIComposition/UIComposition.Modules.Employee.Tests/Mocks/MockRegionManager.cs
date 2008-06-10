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

using System;
using System.Collections.Generic;
using Microsoft.Practices.Composite.Regions;

namespace UIComposition.Modules.Employee.Tests.Mocks
{
    public class MockRegionManager : IRegionManager
    {
        private Dictionary<string, IRegion> _regions = new Dictionary<string, IRegion>();

        #region IRegionManager Members

        public IRegionManager CreateRegionManager()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, IRegion> Regions
        {
            get { return _regions; }
        }

        public void AttachNewRegion(object objectToAdapt, string regionName)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}