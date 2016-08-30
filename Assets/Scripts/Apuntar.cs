using UnityEngine;
using System.Collections;

public class Apuntar : MonoBehaviour
{
    [SerializeField]
    private float velocidad;

    void Update()
    {
        Plane jugador = new Plane(Vector3.up, transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float distancia = 0.0f;

        if (jugador.Raycast(ray, out distancia))
        {
            Vector3 objetivo = ray.GetPoint(distancia);
            Quaternion targetRotation = Quaternion.LookRotation(objetivo - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, velocidad * Time.deltaTime);
        }
    }
}
