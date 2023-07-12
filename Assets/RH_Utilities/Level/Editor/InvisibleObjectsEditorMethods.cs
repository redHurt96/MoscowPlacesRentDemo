using UnityEditor;
using UnityEngine;

namespace _Project.Logic.Level
{
    public static class InvisibleObjectsEditorMethods
    {
        [MenuItem("⚙ Utilities/Hidden objects/Hide all")]
        public static void HideAll() => 
            SetObjectsActive(false, "Hide all hidden objects");

        [MenuItem("⚙ Utilities/Hidden objects/Show all")]
        public static void ShowAll() => 
            SetObjectsActive(true, "Show all hidden objects");

        private static void SetObjectsActive(bool state, string message)
        {
            InvisibleObjectsRenderer[] renderers = Object.FindObjectsOfType<InvisibleObjectsRenderer>(true);

            foreach (InvisibleObjectsRenderer renderer in renderers)
            {
                renderer.GetComponent<Renderer>().enabled = state;
                EditorUtility.SetDirty(renderer);
            }

            Undo.RecordObjects(renderers, message);
        }
    }
}