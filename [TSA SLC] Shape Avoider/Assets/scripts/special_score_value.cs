using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class special_score_value : MonoBehaviour
{
    public TextMeshProUGUI s;

    // Update is called once per frame
    void Update()
    {
        GameObject sspawner = GameObject.Find("special_spawner");
        s.text = sspawner.GetComponent<special_spawner>().score.ToString();
    }
}
