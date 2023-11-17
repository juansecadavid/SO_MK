using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_shader_controller : MonoBehaviour
{
    public Material cushion;

    private Slider colorPicker;

    public float hue;




    void Start()
    {
        colorPicker=this.gameObject.GetComponent<Slider>();
    }
    


    public void GetColor()
    {
        hue=colorPicker.value;
        cushion.SetFloat("_Hue", hue);
    }

   
}
