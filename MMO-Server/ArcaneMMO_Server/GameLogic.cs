using System;
using System.Collections.Generic;
using System.Text;

namespace ArcaneMMO_Server
{
    class GameLogic //Handles the server Game loop
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
