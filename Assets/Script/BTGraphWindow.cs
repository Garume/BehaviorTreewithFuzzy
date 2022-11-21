using GraphProcessor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;

public class BTGraphWindow : BaseGraphWindow
{
    protected override void InitializeWindow(BaseGraph graph)
    {
        Assert.IsNotNull(graph);

        var fileName = Path.GetFileNameWithoutExtension(AssetDatabase.GetAssetPath(graph));
        titleContent = new GUIContent(ObjectNames.NicifyVariableName(fileName));

        // グラフを編集するためのビューであるGraphViewを設定
        if (graphView == null)
        {
            graphView = new BaseGraphView(this);
        }
        rootView.Add(graphView);

    }
}
