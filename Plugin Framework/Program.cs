using Plugin_Framework.Effects;
using System;
using System.Collections.Generic;


var resizeEffect = new ResizeEffect(150);
var blurEffect = new BlurEffect(2);
var grayEffect = new GrayscaleEffect();

PluginManager.RegisterEffectRange(new List<IImageEffect> { resizeEffect, blurEffect, grayEffect });
#region Image3
Image image3 = new Image("path/image3.jpg", 400, 300);
image3.Effects=PluginManager.GetAvailableEffects();
image3.ApplyEffects();
#endregion


PluginManager.UnRegisterEffect(grayEffect);
blurEffect.BlurSize = 5;

//image1
#region Image1
Image image1 = new Image("path/image1.jpg", 200, 150);

image1.Effects = PluginManager.GetAvailableEffects();

image1.ApplyEffects();

#endregion

PluginManager.UnRegisterEffect(blurEffect);
resizeEffect.NewWidth = 100;

//image2
#region Image2

Image image2 = new Image("path/image2.jpg", 300, 200);

PluginManager.UnRegisterEffect(blurEffect);

image2.Effects=PluginManager.GetAvailableEffects();

image2.ApplyEffects();

#endregion

