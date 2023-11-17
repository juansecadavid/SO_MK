using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blur_updater : MonoBehaviour
{
    public Material blur;

    public Slider blurPicker;

    public float blurAmount;
    // Start is called before the first frame update
    void Start()
    {
        blurPicker=this.gameObject.GetComponent<Slider>();
    }


    public void GetBlur()
    {
        blurAmount=blurPicker.value;
        blur.SetFloat("_PixelOffset", blurAmount);
    }

}
