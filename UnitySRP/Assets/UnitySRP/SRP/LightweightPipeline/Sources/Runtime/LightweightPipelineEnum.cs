using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lycoris.Rendering.LightweightPipeline
{
    public enum ShadowCascades
    {
        NoCascades = 1,
        TwoCascades = 2,
        FourCascades = 4,
    }

    public enum ShadowType
    {
        NoShadow,
        HardShadow,
        SoftShadow,
    }

    public enum ShadowResolution
    {
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024,
        _2048 = 2048,
        _4096 = 4096,
    }

    public enum MSAAQuality
    {
        Disabled = 1,
        _2x = 2,
        _4x = 4,
        _8x = 8,
    }

    public enum InternalMaterialType
    {
        Standard = 0,
        Particle,
        Terrain,
        UnityBuiltinDefault,
    }

    public enum Downsampling
    {
        None = 0,
        _2xBilinear,
        _4xBilinear,
        _4xBox,
    }
}
