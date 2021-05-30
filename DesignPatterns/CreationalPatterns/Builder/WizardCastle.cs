using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder {
    class WizardCastle: ICastleBuilder {
        Castle castle = new Castle();
        public Castle GetCastle() {
            return castle;
        }

        public void HasEscapeRoute() {
            castle.EscapeRoute = true;
        }

        public void HasMoat() {
            castle.Moat = true;
        }

        public void SetCastleType() {
            castle.CastleType = CastleType.CONCENTRIC;
        }

        public void SetTowerCount() {
            castle.TowerCount = 4;
        }

        public void SetWizardTower() {
            castle.Wizard = new Wizard();
        }
    }
}
