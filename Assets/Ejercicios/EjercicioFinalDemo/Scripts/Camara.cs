using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float velocidadMovimiento = 7.0f; // Velocidad de movimiento de la cámara
    public float velocidadRotacion = 1.5f;   // Velocidad de rotación de la cámara

    private float rotacionX = 0.0f;
    private float rotacionY = 0.0f;

    void Update()
    {
        // Obtén la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula el desplazamiento de la cámara
        Vector3 desplazamiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical) * velocidadMovimiento * Time.deltaTime;

        // Aplica el desplazamiento a la posición de la cámara
        transform.Translate(desplazamiento);

        // Obtén la entrada del mouse
        float rotacionHorizontal = Input.GetAxis("Mouse X");
        float rotacionVertical = Input.GetAxis("Mouse Y");

        // Calcula la rotación de la cámara
        rotacionX -= rotacionVertical * velocidadRotacion;
        rotacionY += rotacionHorizontal * velocidadRotacion;

        // Limita la rotación vertical de la cámara
        rotacionX = Mathf.Clamp(rotacionX, -90.0f, 90.0f);

        // Aplica la rotación a la cámara
        transform.rotation = Quaternion.Euler(rotacionX, rotacionY, 0.0f);
    }
}
