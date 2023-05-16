using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CharacterHub;

namespace CharacterHub
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        FileSystemManager fileSystemManager = new FileSystemManager();
        Parser parser = new Parser("test");

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
    }
}
