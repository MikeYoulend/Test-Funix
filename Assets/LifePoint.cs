using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifePoint : MonoBehaviour
{
    public int life = 3;
    TMP_Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        lifeText = GetComponent<TMP_Text>();
        lifeText.text = "3";
    }

    // Update is called once per frame
    public void ReduceHealth(int AmountToReduce)
    {
        life -= AmountToReduce;
        lifeText.text = life.ToString();
    }
}
