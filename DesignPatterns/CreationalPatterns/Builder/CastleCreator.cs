using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DesignPatterns.CreationalPatterns.Builder {
    class CastleCreator {
        private ICastleBuilder _castleBuilder;
        public CastleCreator(ICastleBuilder castleBuilder) {
            _castleBuilder = castleBuilder;
        }

        public void CreateCastle() {
            _castleBuilder.SetCastleType();
            _castleBuilder.HasMoat();
            _castleBuilder.SetCastleType();
            _castleBuilder.HasEscapeRoute();
            _castleBuilder.SetWizardTower();
        }

        public Castle GetCastle() {
            return _castleBuilder.GetCastle();
        }
    }
}
