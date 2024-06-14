using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactionAREA : MonoBehaviour
{
    public int puntaje;
    public Text txtScore;
    public int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Alimento")
        {
            Debug.Log("Contacto");
            AlimentoScript alimento;
            alimento = collision.gameObject.GetComponent<AlimentoScript>();
            score += alimento.valorAlimentario;
            if(score < maxScore)
            {
                txtScore.text = score.ToString();
                Destroy(collision.gameObject);
            }
            else
            {
                txtScore.text == "Ganaste!"
            }
            txtScore.text = score.ToString();
            Destroy(collision.gameObject);

        }
    }
}
