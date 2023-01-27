using System.Collections;
using UnityEngine;

namespace ValheimPlus.Configurations.Sections
{
    public class ShipConfiguration : ServerSyncConfig<ShipConfiguration>
    {
        public float sailForceFactorMultiplierRaft { get; internal set; } = 1;
        public float sailForceFactorMultiplierKarve { get; internal set; } = 1;
        public float sailForceFactorMultiplierLongShip { get; internal set; } = 1;
        public float rudderSpeedMultiplierRaft { get; internal set; } = 1;
        public float rudderSpeedMultiplierKarve { get; internal set; } = 1;
        public float rudderSpeedMultiplierLongShip { get; internal set; } = 1;
    }
}