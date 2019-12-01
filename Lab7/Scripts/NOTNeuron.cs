using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NOTNeuron : SimpleNeuron
{
    public override void GetResult()
    {
        Vector2 item = new Vector2(Inputs.Instance.inputs[1].x, Inputs.Instance.inputs[1].y);

        Debug.Log("----------------- <color=" + color + "><b>" + GetComponentInChildren<Text>().text + "</b></color> -----------------");
        ShowInfo(item.x); //0
        ShowInfo(item.y); //1
    }

    private void ShowInfo(float input)
    {
        Debug.Log("<b>X1:</b> " + "<color=" + color + "><b>" + input + "</b></color>"
                + "  Weight X1: " + "<color=" + color + "><b>" + weightX + "</b></color>"
                + "  <b>Bias:</b> " + "<color=" + color + "><b>" + bias + "</b></color>"
                + "  <b>a:</b> " + "<color=" + color + "><b>" + ActivationFunction(bias + (weightX * input)) + "</b></color>");
    }
}
