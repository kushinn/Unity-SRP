using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace Lycoris.Rendering.LightweightPipeline
{
    public class LighweightPipelineAssetEditor : EditorWindow
    {
        class PipelineAssetCreator : EndNameEditAction
        {
            public override void Action(int instanceId, string pathName, string resourceFile)
            {
                var instance = CreateInstance<LighweightPipelineAsset>();
                AssetDatabase.CreateAsset(instance, pathName);
            }
        }

        private const string kLighweightPipelineAssetName = "Assets/LighweightPipeline.Asset";

        [MenuItem("SRP/Rendering/Create LightweightPipeline Asset")]
        private static void CreatePipeline()
        {
            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, CreateInstance<PipelineAssetCreator>(), kLighweightPipelineAssetName, null, null);
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Graphics");
        }


        [MenuItem("SRP/Rendering/Create LightweightPipeline Asset & Apply")]
        private static void CreatePipelineAndApply()
        {
            CreatePipeline();
            GraphicsSettings.renderPipelineAsset = (RenderPipelineAsset)AssetDatabase.LoadMainAssetAtPath(kLighweightPipelineAssetName);
        }


    }
}
