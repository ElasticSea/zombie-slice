using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{
    [CustomEditor(typeof(SliceTester))]
    public class SliceTesterEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Slice"))
            {
                var slicer = target as SliceTester;
                slicer.TrySlice();
            }
        }
    }
}