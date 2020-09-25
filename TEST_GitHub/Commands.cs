using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;

[assembly: CommandClass(typeof(TEST_GitHub.Commands))]
namespace TEST_GitHub
{
    public class Commands
    {
        [CommandMethod("AAA")]
        public void Command()
        {
            var view = new MainView();
            Application.ShowModalWindow(view);
        }
    }
}
