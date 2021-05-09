using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class MainCoordinator
    {
        private static MainCoordinator coordinator;

        public static MainCoordinator Instance
        {
            get
            {
                if (coordinator == null)
                {
                    coordinator = new MainCoordinator();
                }
                return coordinator;
            }
        }

        private MainCoordinator()
        {

        }
    }
}
