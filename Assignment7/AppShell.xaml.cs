﻿using Assignment7.View;

namespace Assignment7
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("SignIn", typeof(SignInPage));
            Routing.RegisterRoute("HomePage", typeof(HomePage));
        }
    }
}
