using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, (float)5);
    }

    void OncollisionEnter(Collision other)
    {
        if (other.gameObject.tag == ("enemigo"))
        {
            Debug.Log("daño");
        }
    }
}
