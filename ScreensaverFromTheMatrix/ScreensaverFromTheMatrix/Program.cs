using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreensaverFromTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerElementsMatrix managerElementsMatrix = new ManagerElementsMatrix();
            managerElementsMatrix.AddElementMatrix(100);
            managerElementsMatrix.FallElementMatrix();
        }
    }
}
