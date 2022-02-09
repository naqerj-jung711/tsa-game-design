using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_value : MonoBehaviour
{
    public TextMeshProUGUI s;

    // Update is called once per frame
    void Update()
    {
        GameObject spawner = GameObject.Find("spawner");
        s.text = spawner.GetComponent<spawner>().score.ToString();
    }
}
