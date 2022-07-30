using HarmonyLib;
using PhantomBrigade.Mods;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMod
{
    public class ModLink : PhantomBrigade.Mods.ModLink
    {
        public override void OnLoad(Harmony harmonyInstance)
        {
            Debug.Log($"----- {metadata.id} dir: {metadata.directory} path: {metadata.path}");

            Logger.Log("test log direct");
        }
    }
}
