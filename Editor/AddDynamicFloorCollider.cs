using UnityEngine;
using UnityEditor;
using VRC.SDK3.Avatars.Components;

public class AddDynamicFloorCollider : EditorWindow
{
    // Define the GUID of the prefab in the Packages directory
    private static string prefabGUID = "b4d62de2cf5a8c748a002e2409e9239a";

    [MenuItem("Tools/BluWizard LABS/Add Dynamic Floor Collider to Avatar")]
    public static void AddColliderToAvatarMenu()
    {
        AddColliderToAvatar();
    }

    [MenuItem("GameObject/BluWizard LABS/Add Dynamic Floor Collider to Avatar", false, 10)]
    public static void AddColliderToAvatarContextMenu(MenuCommand menuCommand)
    {
        AddColliderToAvatar();
    }

    public static void AddColliderToAvatar()
    {
        // Load the prefab using the GUID
        string prefabPath = AssetDatabase.GUIDToAssetPath(prefabGUID);
        GameObject floorColliderPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);

        if (floorColliderPrefab == null)
        {
            EditorUtility.DisplayDialog("This wasn't supposed to happen...", "Could not find the Prefab with the specified GUID. Please inform BluWizard of this issue and show them this message. Missing GUID ID: " + prefabGUID, "OK");
            return;
        }

        // Get the selected game object in the editor
        GameObject selectedObject = Selection.activeGameObject;

        if (selectedObject == null || selectedObject.GetComponent<VRCAvatarDescriptor>() == null)
        {
            EditorUtility.DisplayDialog("Error", "Please first select a VRChat Avatar in the current Scene, then try again. Make sure it has the VRC Avatar Descriptor Component on it.", "OK");
            return;
        }

        // Check if the Floor Collider was already added to the selected Avatar
        foreach (Transform child in selectedObject.transform)
        {
            if (child.name == floorColliderPrefab.name)
            {
                EditorUtility.DisplayDialog ("Already Added!", "The Dynamic VRC Floor Collider has already been added to this Avatar. If you need to reinstall it, first delete the Dynamic VRC Floor Prefab from the Avatar, then run this script again.", "OK");
                return;
            }
        }

        // Instantiate the prefab as a child of the selected avatar
        GameObject instantiatedPrefab = (GameObject)PrefabUtility.InstantiatePrefab(floorColliderPrefab);
        instantiatedPrefab.transform.SetParent(selectedObject.transform, false);
        instantiatedPrefab.transform.localPosition = Vector3.zero;

        // Record the changes in the Unity Editor
        Undo.RegisterCreatedObjectUndo(instantiatedPrefab, "Add Floor Collider");
        EditorUtility.SetDirty(selectedObject);

        Debug.Log("[<color=#0092d9>BluWizard LABS</color>] Successfully added Dynamic VRC Floor to your Avatar! Don't forget to re-assign your PhysBones, such as your Tail, to use the newly added Floor Collider instead.");

        // Select the newly added Prefab in the Hierarchy
        Selection.activeObject = instantiatedPrefab;

        // Ping the newly added Prefab in the Hierarchy
        EditorGUIUtility.PingObject(instantiatedPrefab);
    }

    [MenuItem("GameObject/BluWizard LABS/Add Dynamic Floor Collider to Avatar", true)]
    public static bool ValidateAddColliderToAvatarContextMenu()
    {
        GameObject selectedObject = Selection.activeGameObject;
        return selectedObject != null && selectedObject.GetComponent<VRCAvatarDescriptor>() != null;
    }
}
