using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public Transform car;
    public Transform flag;
    public TextMeshProUGUI distance;
    // Start is called before the first frame update
    void Start()
    {
        // this.car = GameObject.Find("car");
        // this.flag = GameObject.Find("flag");
        // this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.position.x - this.car.position.x;
        this.distance.text = $"Distance:{length.ToString("F2")}m";
    }
}
