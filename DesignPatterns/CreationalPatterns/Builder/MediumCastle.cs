using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder {
    class MediumCastle: ICastleBuilder {
        Castle castle = new Castle();
        public Castle GetCastle() {
            return castle;
        }

        public void HasEscapeRoute() {
            castle.EscapeRoute = false;
        }

        public void HasMoat() {
            castle.Moat = true;
        }

        public void SetCastleType() {
            castle.CastleType = CastleType.STONE_KEEP;
        }

        public void SetTowerCount() {
            castle.TowerCount = 2;
        }

        public void SetWizardTower() {
            castle.Wizard = null;
        }
    }
}
