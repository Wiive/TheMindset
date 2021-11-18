using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color targetColor;
    public Color ChangeToNewColor(Color newColor)
    {
        this.targetColor = newColor;
        return newColor;
    }
}
