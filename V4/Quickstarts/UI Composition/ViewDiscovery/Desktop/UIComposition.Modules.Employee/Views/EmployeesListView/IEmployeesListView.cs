//===================================================================================
// Microsoft patterns & practices
// Composite Application Guidance for Windows Presentation Foundation and Silverlight
//===================================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===================================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===================================================================================
using System;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism;

namespace UIComposition.Modules.Employee
{
    public interface IEmployeesListView
    {
        event EventHandler<DataEventArgs<BusinessEntities.Employee>> EmployeeSelected;
        ObservableCollection<BusinessEntities.Employee> Model { get; set; }

        /// <summary>
        /// This object will hold the regioncontext for the view. You can also subscribe
        /// to change notifications to detect when this property changes
        /// </summary>
        ObservableObject<object> ObservableRegionContext { get;}
    }
}