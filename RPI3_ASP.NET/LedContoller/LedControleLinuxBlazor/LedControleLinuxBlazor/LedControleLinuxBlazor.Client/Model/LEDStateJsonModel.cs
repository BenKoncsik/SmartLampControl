﻿namespace LedControleLinuxBlazor.Client.Model
{
    public class LEDStateJsonModel
    {
        public int LedNumber { get; set; }
        public string LedColor { get; set; }
        public float Brightness { get; set; }

        public LEDStateJsonModel()
        {
        }

        public LEDStateJsonModel(float brightness)
        {
            Brightness = brightness;
        }
    }
}
