﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoutubeRPG
{
    public class ImageEffect
    {
        protected Image image;
        public bool IsActive;

        public ImageEffect()
        {
            this.IsActive = false;
        }

        public virtual void LoadContent(ref Image Image)
        {
            this.image = Image;
        }

        public virtual void UnloadContent()
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }
    }
}
