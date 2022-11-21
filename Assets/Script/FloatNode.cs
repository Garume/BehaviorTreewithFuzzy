using GraphProcessor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
[NodeMenuItem("Primitives/Float")]
public class FloatNode : BaseNode
{
    [Input(name = "In")] public float input;
    [Output(name = "Out")] public float output;

    public override string name => "Float";

    protected override void Process()
    {
        output = input;
    }

}