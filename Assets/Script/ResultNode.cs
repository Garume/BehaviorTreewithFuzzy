using GraphProcessor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
[NodeMenuItem("Custom/Result")]
public class ResultNode : BaseNode
{
    [Input(name = "Result")] public float input;

    private float _result;
    public float Result => _result;

    public override string name => "Result";

    protected override void Process()
    {
        _result = input;
    }

}