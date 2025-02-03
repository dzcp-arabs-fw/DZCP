﻿using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Loader;
namespace SCPSL_Framework.GameRoles.Humans
{
    public class ClassD : HumanRole
    {
        public ClassD()
        {
            RoleName = "Class-D";
            Health = 100;
            Armor = 0;
            Weapons = new string[] { "None" };
        }
    }
}