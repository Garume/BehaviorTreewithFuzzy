using GraphProcessor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
[NodeMenuItem("Custom/Add")]
public class AddNode: BaseNode
{
    [Input(name = "A")] public float input1;
    [Input(name = "B")] public float input2;
    [Output(name = "Out",allowMultiple = false)] public float output;

    public override string name => "Add";

    protected override void Process()
    {
        output = input1 + input2;
    }

}