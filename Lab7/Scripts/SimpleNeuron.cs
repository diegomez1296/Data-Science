using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleNeuron : MonoBehaviour
{
    public float bias;
    public float weightX;
    public float weightY;
    public string color;

    public int ActivationFunction(float x)
    {
       return x < 0 ? 0 : 1;
    }

    public int ActivationFunction(Vector2 item)
    {
        return ActivationFunction(bias + (weightX * item.x) + (weightY * item.y));
    }


    public virtual void GetResult()
    {
        Debug.Log("----------------- <color=" + color + "><b>" + GetComponentInChildren<Text>().text + "</b></color> -----------------");
        foreach (var item in Inputs.Instance.inputs)
            Debug.Log("<b>X1:</b> " + "<color=" + color +"><b>" + item.x + "</b></color>"
                    + "  <b>X2:</b> " + "<color=" + color + "><b>" + item.y + "</b></color>"
                    + "  Weight X1: " + "<color=" + color + "><b>" + weightX + "</b></color>"
                    + "  Weight X2: " + "<color=" + color + "><b>" + weightY + "</b></color>"
                    + "  (X1 * Weight X1) + (X2 * Weight X2): " + "<color=" + color + "><b>" + ((weightX * item.x) + (weightY * item.y)) + "</b></color>"
                    + "  <b>Bias:</b> " + "<color=" + color + "><b>" + bias + "</b></color>"
                    + "  <b>a:</b> " + "<color=" + color +"><b>" + ActivationFunction(bias + (weightX*item.x) + (weightY*item.y)) + "</b></color>");

    }

    public SimpleNeuron()
    {
    }

    public SimpleNeuron(float bias, float weightX, float weightY)
    {
        this.bias = bias;
        this.weightX = weightX;
        this.weightY = weightY;
    }

    public string _ToString(string color)
    {
        return $"WeightX: <color={color}><b>{weightX}</b></color>, WeightX2: <color={color}><b>{weightY}</b></color>, bias: <color={color}><b>{bias}</b></color>";
    }
}
