using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public MeshRenderer sphere;
    public Slider green;

    // Update is called once per frame
    void Update()
    {
        Color color = sphere.material.color;
        color.g = green.value;
        sphere.material.color = color;
        sphere.material.SetColor("_EmissionColor",color);
    }
}
