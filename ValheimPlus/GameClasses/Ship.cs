using HarmonyLib;
using ValheimPlus.Configurations;

namespace ValheimPlus.GameClasses
{
    [HarmonyPatch(typeof(Ship), "Awake")]
    public static class Ship_Awake_Patch
    {
        public static void Postfix(Ship __instance)
        {
            if (__instance.name.Contains("VikingShip"))
            {
                __instance.m_sailForceFactor *= Configuration.Current.Ship.sailForceFactorMultiplierLongShip;
                __instance.m_rudderSpeed *= Configuration.Current.Ship.rudderSpeedMultiplierLongShip;
            }
            else if (__instance.name.Contains("Raft"))
            {
                __instance.m_sailForceFactor *= Configuration.Current.Ship.sailForceFactorMultiplierRaft;
                __instance.m_rudderSpeed *= Configuration.Current.Ship.rudderSpeedMultiplierRaft;
            }
            else if (__instance.name.Contains("Karve"))
            {
                __instance.m_sailForceFactor *= Configuration.Current.Ship.sailForceFactorMultiplierKarve;
                __instance.m_rudderSpeed *= Configuration.Current.Ship.rudderSpeedMultiplierKarve;
            }
        }
    }
}