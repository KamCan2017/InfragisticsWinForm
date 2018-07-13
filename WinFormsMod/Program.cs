using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace WinFormsMod
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;

            var loadModules = LoadModules();
            RunApp(loadModules);
        }       

        private static IEnumerable<IEmbeddedModule> LoadModules()
        {
            var modules = new List<IEmbeddedModule>();

            try
            {
                var allAssemblies = new List<Assembly>();
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                foreach (string dll in Directory.GetFiles(path, "*.dll"))
                    allAssemblies.Add(Assembly.LoadFile(dll));

                var types = new List<Type>();

                foreach (Assembly assembly in allAssemblies)
                {
                    Type[] iLoadTypes = (from t in assembly.GetExportedTypes()
                                         where t.IsClass && t.GetInterface(typeof(IEmbeddedModule).Name) != null
                                         select t).ToArray();
                    if (iLoadTypes.Any())
                        types.AddRange(iLoadTypes);
                }

                foreach (Type t in types)
                    modules.Add((IEmbeddedModule)Activator.CreateInstance(t));

            }
            catch (Exception ex)
            {
                string message =  "Loading of modules failed: \n" +
                    (ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                MessageBox.Show(message, "Error");
            }

            return modules;
        }

        private static void RunApp(IEnumerable<IEmbeddedModule> modules)
        {
            var form = new MainForm();
            foreach(IEmbeddedModule module in modules)
               form.AddModule(module);

            Application.Run(form);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string message = "The application will be closed cause of following reasons:\n" + e.Exception.Message;
            MessageBox.Show(message, "Error");
            Application.Exit();
        }
    }
}
