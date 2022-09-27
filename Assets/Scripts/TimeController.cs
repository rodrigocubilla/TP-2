using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] TMP_Text tiempo;
    [SerializeField] GameObject pantallaFinal;

    private float restante;
    private bool enMarcha;


    private void Awake()
    {
        restante = (min * 60) + seg;
        enMarcha = true;
        pantallaFinal.SetActive(false);
    }

    void Update()
    {
        if(enMarcha)
        {
            restante -= Time.deltaTime;
            if(restante < 1)
            {
                enMarcha = false;
                pantallaFinal.SetActive(true);
                Time.timeScale = 0;
            }
            int tempMin = Mathf.FloorToInt(restante/60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
            
        }
    }
}
