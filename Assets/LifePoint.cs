using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifePoint : MonoBehaviour
{
    public int life = 3;
    TMP_Text lifeText;
    
    void Start()
    {
        lifeText = GetComponent<TMP_Text>();
        lifeText.text = "3";
    }


    public void ReduceHealth(int AmountToReduce)
    {
        life -= AmountToReduce;
        lifeText.text = life.ToString();
    }
}
