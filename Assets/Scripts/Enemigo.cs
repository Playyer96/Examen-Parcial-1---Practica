using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

    [SerializeField]
    private float danoBala;
    [SerializeField]
    private float vida;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag==("bala"))
        {
            dano();
        }
    }
    private void dano()
    {
        vida -= danoBala;
        if (vida <= 0)
        {
            Destroy(gameObject);
            Score.score++;
        }
    }
}
