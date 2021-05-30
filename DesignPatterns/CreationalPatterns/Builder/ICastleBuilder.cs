using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder {
    interface ICastleBuilder {
        void SetTowerCount();
        void HasMoat();
        void SetCastleType();
        void HasEscapeRoute();
        void SetWizardTower();
        Castle GetCastle();
    }
}
