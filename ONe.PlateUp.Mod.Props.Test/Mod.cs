using KitchenMods;
using UnityEngine;

namespace ONe.PlateUp.Mod.Props.Test
{
    public class Mod : IModInitializer
    {
        public void PostActivate(KitchenMods.Mod mod)
        {
            Debug.Log("NugetTestMOd PostActivate");
        }

        public void PreInject()
        {
            Debug.Log("NugetTestMOd PreInject");
        }

        public void PostInject()
        {
            Debug.Log("NugetTestMOd PostInject ");
        }
    }
}