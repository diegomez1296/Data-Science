using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleNeuronNetwork : MonoBehaviour
{
    public float[] biases;
    public float[] weightX;
    public float[] weightY;
    public string color;

    private SimpleNeuron neuron_1L_1;
    private SimpleNeuron neuron_1L_2;
    private SimpleNeuron neuron_2L_1;

    public void GetResult()
    {
        Debug.Log("----------------- <color=" + color + "><b>" + GetComponentInChildren<Text>().text + "</b></color> -----------------");

        foreach (var item in Inputs.Instance.inputs)
        {
            neuron_1L_1 = new SimpleNeuron(biases[0], weightX[0], weightY[0]);
            neuron_1L_2 = new SimpleNeuron(biases[1], weightX[1], weightY[1]);

            neuron_2L_1 = new SimpleNeuron(biases[2], weightX[2], weightY[2]);

            ShowInfo(item);  
        }
            Debug.Log("<b>neuron_1L_1: </b>" + neuron_1L_1._ToString(color));
            Debug.Log("<b>neuron_1L_2: </b>" + neuron_1L_2._ToString(color));
            Debug.Log("<b>neuron_2L_1: </b>" + neuron_2L_1._ToString(color));
    }

    private void ShowInfo(Vector2 input)
    {
        Debug.Log("<b>X1:</b> " + "<color=" + color + "><b>" + input.x + "</b></color>"
                        + "  <b>X2:</b> " + "<color=" + color + "><b>" + input.y + "</b></color>"
                        //+ "  <b>Bias:</b> " + "<color=" + color + "><b>" + biases[2] + "</b></color>"
                        + "  <b>a:</b> " + "<color=" + color + "><b>" + 
                            neuron_2L_1.ActivationFunction(biases[2] + (weightX[2] * neuron_1L_1.ActivationFunction(input)) + (weightY[2] * neuron_1L_2.ActivationFunction(input))) 
                            + "</b></color>");
    }
}
