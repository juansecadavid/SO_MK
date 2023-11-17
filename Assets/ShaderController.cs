using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderController : MonoBehaviour
{
    public Material material;
    public Slider slider;

    public string propertyName;

    public void Update()
    {
        // Aseg�rate de que el material y el slider est�n asignados
        if (material != null && slider != null)
        {
            // Actualiza el valor del material con el valor del slider
            material.SetFloat(propertyName, slider.value);
        }
    }

}
