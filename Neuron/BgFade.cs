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
    public class BgFade : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("MySampleEffect");
            var bg = layer.CreateSprite("neuron.jpg", OsbOrigin.Centre);
            bg.Scale(0, 480.0 / 1080);
            bg.Fade(699, 1044, 0, 1);
            bg.Fade(106562, 106734, 1, 0);
            
            flashBackground(58631, 59320, 8, bg);
            flashBackground(64148, 64837, 8, bg);
        }

        public void flashBackground(int startTime, int endTime, int count, OsbSprite bg) {
            float flashInterval = (endTime - startTime) / count;
            float growFactor = 0.5f / 8;

            for (int i = 0; i < count; i++)
            {
                bg.Fade(startTime + i*flashInterval,
                        startTime + i*flashInterval + flashInterval/2,
                        0,
                        (i + 1) * growFactor);
            }
            bg.Fade(endTime, endTime + 1, 0, 1);
        }

        // public void flashBackground(int startTime, int endTime, int count, OsbSprite bg) {
        //     float flashDuration = (endTime - startTime) / count;

        //     bg.Fade(startTime - 1, startTime, 1, 0.1);
        //     for (int i = 0; i < count; i++)
        //     {
        //         bg.Fade(startTime + i*flashDuration, startTime + i*flashDuration + flashDuration/2, 0.1, 0.3);
        //         bg.Fade(startTime + i*flashDuration + flashDuration/2, startTime + (i+1)*flashDuration, 0.3, 0.1);
        //     }
        //     bg.Fade(endTime, endTime + 1, 0.1, 1);
        // }
    }
}
