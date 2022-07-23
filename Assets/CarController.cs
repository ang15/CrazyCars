using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private Material material;
    private float score;
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text finishText;
    [SerializeField]
    private GameObject finish;
    [SerializeField]
    private GameObject thisPole;

    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "" + (int)score;
        finishText.text=""+ (int)score;
        GetComponent<Image>().sprite = material.cars[material.carChange];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BadCar")
        {
            finish.SetActive(true);
            thisPole.SetActive(false);
        }
    }
}
