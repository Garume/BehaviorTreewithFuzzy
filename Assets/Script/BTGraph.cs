using GraphProcessor;
using UnityEditor.Callbacks;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Create���j���[����ScriptableObject�̃A�Z�b�g������悤��
[CreateAssetMenu(menuName = "Example Graph")]
public class ExampleGraph : BaseGraph
{
#if UNITY_EDITOR
    // �_�u���N���b�N�ŃE�B���h�E���J�����悤��
    [OnOpenAsset(0)]
    public static bool OnBaseGraphOpened(int instanceID, int line)
    {
        var asset = EditorUtility.InstanceIDToObject(instanceID) as ExampleGraph;

        if (asset == null) return false;

        var window = EditorWindow.GetWindow<BTGraphWindow>();
        window.InitializeGraph(asset);
        return true;
    }
#endif
}