using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Vignette : StoryboardObjectGenerator
    {
        StoryboardLayer vignetteLayer;

        public override void Generate()
        {
            vignetteLayer = GetLayer("vignette");
            
            var vignette = vignetteLayer.CreateSprite("sb/vignette.png");
            vignette.Scale(0, 480.0 / 1080);
            vignette.Fade(0, 106734, 1, 1);
        }
    }
}
