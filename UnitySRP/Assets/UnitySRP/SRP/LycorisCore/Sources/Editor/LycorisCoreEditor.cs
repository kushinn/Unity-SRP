using UnityEditor;
using UnityEngine;

namespace Lycoris
{
    public class LycorisCoreEditor
    {
        [MenuItem("Assets/Copy AssetPath From Selection")]
        public static void CopyAssetPathFromSelection()
        {
            if (Selection.activeObject == null)
                return;

            ClipboardHelper.ClipBoardString = AssetDatabase.GetAssetPath(Selection.activeObject);
        }
    }
}
