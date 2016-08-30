using UnityEngine;
using System.Collections;

public class Torreta : MonoBehaviour {

    [SerializeField]
    private GameObject bala;

    [SerializeField]
    private float aceleracion;

void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            disparar();    
        }
    }
    void disparar()
    {
        GameObject disparo = (GameObject)Instantiate(bala, gameObject.transform.position, gameObject.transform.rotation);
        disparo.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * aceleracion);
    }
}
