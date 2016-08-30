using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int score;

    [SerializeField]
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        text.text = "Puntaje: " + score;
    }
}
