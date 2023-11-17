using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseSpeed : MonoBehaviour
{
    public Material speedMath;
    public float health;
    public float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        speedMath.SetFloat("_NoisePowert", health / maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;
            speedMath.SetFloat("_NoisePowert", health / maxHealth);
        }
    }
}
