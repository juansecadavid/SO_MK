using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseSpeed : MonoBehaviour
{
    public Material speedMath;

    private Slider speedSlider;

    private Slider colorPickerr;

    public float health;

    public float hue;
   
    // Start is called before the first frame update
    void Start()
    {
        speedSlider = this.gameObject.GetComponent<Slider>();
        colorPickerr = this.gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    public void GetPower()
    {
       health=speedSlider.value;
       speedMath.SetFloat("_NoisePowert",health);

    }

    public void GetColor()
    {
        hue=colorPickerr.value;
        speedMath.SetFloat("_Hue", hue);
    }
}
