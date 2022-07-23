using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public bool move;
    private CarController car;
    void Start()
    {
        move = true;
    }

    void Update()
    {
        if (transform.localPosition.y <= -1602)
        {
            Vector2 Poziton = transform.localPosition;
            Poziton.y = 1602;
            transform.localPosition = Poziton;
            
        }
        if (move == true)
        {
            move = false;
            StartCoroutine(Move());
        }
    }
    IEnumerator Move()
    {
        yield return new WaitForSeconds(1.5f*Time.deltaTime);
        Vector2 poziton = transform.localPosition;
        poziton.y -=10;
        transform.localPosition = poziton;
        move = true;
    }

}
