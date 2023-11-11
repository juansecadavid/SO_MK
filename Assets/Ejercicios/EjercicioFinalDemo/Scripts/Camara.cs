using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float velocidadMovimiento = 7.0f; // Velocidad de movimiento de la c�mara
    public float velocidadRotacion = 1.5f;   // Velocidad de rotaci�n de la c�mara

    private float rotacionX = 0.0f;
    private float rotacionY = 0.0f;

    void Update()
    {
        // Obt�n la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula el desplazamiento de la c�mara
        Vector3 desplazamiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical) * velocidadMovimiento * Time.deltaTime;

        // Aplica el desplazamiento a la posici�n de la c�mara
        transform.Translate(desplazamiento);

        // Obt�n la entrada del mouse
        float rotacionHorizontal = Input.GetAxis("Mouse X");
        float rotacionVertical = Input.GetAxis("Mouse Y");

        // Calcula la rotaci�n de la c�mara
        rotacionX -= rotacionVertical * velocidadRotacion;
        rotacionY += rotacionHorizontal * velocidadRotacion;

        // Limita la rotaci�n vertical de la c�mara
        rotacionX = Mathf.Clamp(rotacionX, -90.0f, 90.0f);

        // Aplica la rotaci�n a la c�mara
        transform.rotation = Quaternion.Euler(rotacionX, rotacionY, 0.0f);
    }
}
