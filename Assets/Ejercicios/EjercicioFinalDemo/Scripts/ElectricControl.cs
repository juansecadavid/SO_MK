using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ElectricControl : MonoBehaviour
{

    public Material color;

    private Slider colorPickerrr;

    private Slider NoiseSpeed;

    public float hue;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        colorPickerrr = this.gameObject.GetComponent<Slider>();
        NoiseSpeed = this.gameObject.GetComponent<Slider>();    
    }

    public void GetColor()
    {
        hue=colorPickerrr.value;
        color.SetFloat("_Hue", hue);
    }

    public void GetSpeed()
    {
        speed=NoiseSpeed.value;
        color.SetFloat("_NoiseSpeed", speed);
    }
}
