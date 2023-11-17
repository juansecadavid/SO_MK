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
        // Asegúrate de que el material y el slider estén asignados
        if (material != null && slider != null)
        {
            // Actualiza el valor del material con el valor del slider
            material.SetFloat(propertyName, slider.value);
        }
    }

}
