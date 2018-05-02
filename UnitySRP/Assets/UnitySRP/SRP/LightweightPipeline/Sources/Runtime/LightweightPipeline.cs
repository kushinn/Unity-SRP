using UnityEngine.Experimental.Rendering;

namespace Lycoris.Rendering.LightweightPipeline
{
    public class LighweightPipeline : RenderPipeline
    {
        private readonly LighweightPipelineAsset mPipelineAsset;

        public static IRenderPipeline CreatePipeline(LighweightPipelineAsset asset)
        {
            return new LighweightPipeline(asset);
        }

        public LighweightPipeline(LighweightPipelineAsset asset)
        {
            mPipelineAsset = asset;
        }


    }
}
