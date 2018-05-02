using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Lycoris.Rendering.LightweightPipeline
{
    public class LighweightPipelineAsset : RenderPipelineAsset
    {
        [SerializeField] private int version = 1;

        [SerializeField] private int maxPixelLights = 4;
        [SerializeField] private int maxVertexLights = 4;

        [SerializeField] private Downsampling opaqueDownsampling = Downsampling._2xBilinear;
        [SerializeField] private MSAAQuality msaaQuality = MSAAQuality._2x;

        [SerializeField] private ShadowType shadowType = ShadowType.HardShadow;
        [SerializeField] private ShadowResolution shadowResolution = ShadowResolution._512;
        [SerializeField] private ShadowCascades shadowCascades = ShadowCascades.FourCascades;
        [SerializeField] private Vector3 cascade4Split = new Vector3(0.067f, 0.20f, 0.467f);
        [SerializeField] private float cascade2Split = 0.25f;
        [SerializeField] private float shadowDistance = 50.0f;

        [SerializeField] private float renderScale = 1.0f;

        [SerializeField] private bool supportHDR = false;
        [SerializeField] private bool requireDepthTexture = false;
        [SerializeField] private bool requireSoftParticles = false;


        public int Version { get { return version; } }
        public int MaxPixelLights { get { return maxPixelLights; } }
        public int MaxVertexLights { get { return maxVertexLights; } }

        public Downsampling OpaqueDownsampling { get { return opaqueDownsampling; } }
        public MSAAQuality MsaaQuality { get { return msaaQuality; } }

        public ShadowType ShadowType { get { return shadowType; } }
        public ShadowResolution ShadowResolution { get { return shadowResolution; } }
        public ShadowCascades ShadowCascades { get { return shadowCascades; } }
        public Vector3 Cascade4Split { get { return cascade4Split; } }
        public int CascadesCount { get { return (int) shadowCascades; } }
        public float Cascade2Split { get { return cascade2Split; } }
        public float ShadowDistance { get { return shadowDistance; } }

        public float RenderScale { get { return renderScale; } }

        public bool SupportsPixelLights { get { return maxPixelLights != 0; } }
        public bool SupportsVertexLight { get { return maxVertexLights != 0; } }
        public bool SupportHDR { get { return supportHDR; } }
        public bool RequireDepthTexture { get { return requireDepthTexture; } }
        public bool RequireSoftParticles { get { return requireSoftParticles; } }

        protected override IRenderPipeline InternalCreatePipeline()
        {
            return LighweightPipeline.CreatePipeline(this);
        }


    }
}
