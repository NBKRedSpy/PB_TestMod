using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TestMod
{
    [HarmonyPatch (typeof(PhantomBrigade.GameController), nameof(PhantomBrigade.GameController.Initialize))]
    public static class HarmonyPatchTest
    {
        public static void Prefix()
        {
            Debug.Log("Harmony patch executed");
            

        }
    }
}
