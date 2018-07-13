using System.Drawing;
using System.Windows.Forms;

namespace Common.Interfaces
{
    public interface IEmbeddedModule
    {
        string Name { get; }

        UserControl View { get; }

        Image Logo { get; }
    }
}
