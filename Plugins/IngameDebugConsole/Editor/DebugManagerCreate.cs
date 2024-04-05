using UnityEditor;
using UnityEngine;

namespace IngameDebugConsole
{
    public class DebugManagerCreateEditor
    {
        [MenuItem("GameObject/InGameDebugLogMessager", false, 10)]
        static void CreateDebugObject(MenuCommand menuCommand)
        {
            GameObject go = GameObject.Instantiate(Resources.Load<GameObject>("IngameDebugConsole/IngameDebugConsole"));
            // Ensure it gets reparented if this was a context click (otherwise does nothing)
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            // Register the creation in the undo system
            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
            Selection.activeObject = go;
        }
    }
}
