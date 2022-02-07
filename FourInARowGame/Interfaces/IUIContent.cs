using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Interfaces
{
    public interface IUIContent
    {
        void InitializeGameMainScreen();
        void InitializeGameTitle();
        void InitializeGameDescription();
        void InitializeGameMenu();
    }
}
