using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder {

    public enum CastleType {
        MOTTE_BAILEY,
        STONE_KEEP,
        CONCENTRIC
    }

    class Castle {
        public int TowerCount { get; set; }
        public bool Moat { get; set; }
        public CastleType CastleType { get; set; }
        public bool EscapeRoute { get; set; }
        public Wizard Wizard { get; set; }
    }
}
