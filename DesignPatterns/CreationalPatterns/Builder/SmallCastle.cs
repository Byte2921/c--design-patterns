using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder {
    class SmallCastle : ICastleBuilder {
        Castle castle = new Castle();
        public Castle GetCastle() {
            return castle;
        }

        public void HasEscapeRoute() {
            castle.EscapeRoute = false;
        }

        public void HasMoat() {
            castle.Moat = false;
        }

        public void SetCastleType() {
            castle.CastleType = CastleType.MOTTE_BAILEY;
        }

        public void SetTowerCount() {
            castle.TowerCount = 0;
        }

        public void SetWizardTower() {
            castle.Wizard = null;
        }
    }
}
