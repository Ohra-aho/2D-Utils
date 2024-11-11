using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{
    public string name;
    public float value;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = name;
        Debug.Log(transform.GetChild(1).GetComponent<Slider>());

    }

    // Update is called once per frame
    void Update()
    {
        //DisplayValues();
    }

    private void DisplayValues()
    {
        if(value != transform.GetChild(1).GetComponent<Slider>().value)
        {
            value = transform.GetChild(1).GetComponent<Slider>().value;
        }
        transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = value.ToString("F2");
    }
}
