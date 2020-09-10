﻿using AuthDemoXForms.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AuthDemoXForms
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("UserProfil", typeof(UserProfilPage));
        }
    }
}
