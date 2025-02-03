﻿using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Loader;
namespace SCPSL_Framework.GameRoles.Humans
{
    public class Guard : HumanRole
    {
        public Guard()
        {
            RoleName = "Guard";
            Health = 100;
            Armor = 50;
            Weapons = new string[] { "Pistol", "Flashbang" };
        }
    }
}