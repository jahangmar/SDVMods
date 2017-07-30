﻿using Microsoft.Xna.Framework.Input;

namespace ClimatesOfFerngillRebuild
{
    class WeatherConfig
    {
        //required options
        public Keys Keyboard { get; set; }
        public Buttons Controller { get; set; }
        public string ClimateType { get; set; }
        public double ThundersnowOdds { get; set; }
        public double BlizzardOdds { get; set; }
        public double DryLightning { get; set; }
        public double DryLightningMinTemp { get; set; }
        public bool SnowOnFall28 { get; set; }
        public bool StormTotemChange { get; set; }
        public bool HazardousWeather { get; set; }
        public bool AllowCropDeath { get; set; }
        public bool AllowStormsSpringYear1 { get; set; }
        public bool ShowBothScales { get; set; }
        public bool Verbose { get; set; }
        
        public WeatherConfig()
        {
            //set climate type
            ClimateType = "normal";

            //set keyboard key
            Keyboard = Keys.Z;

            //normal climate odds
            ThundersnowOdds = .001; //.1%
            BlizzardOdds = .08; // 8%
            DryLightning = .10; //10%
            DryLightningMinTemp = 34; //34 C, or 93.2 F
            HazardousWeather = false; //normally, hazardous weather is turned off
            AllowCropDeath = false; //even if you turn hazardous weather on, it won't allow crop death
            SnowOnFall28 = false; //default setting - since if true, it will force
            StormTotemChange = true; //rain totems may spawn storms instead of rain totems.
            AllowStormsSpringYear1 = false; //default setting - maintains the fact that starting players may not 
            ShowBothScales = true; //default setting.
             // be able to deal with lightning strikes

            //general mod options
            Verbose = true;
        }
    }
}