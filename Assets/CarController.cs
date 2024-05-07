using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
            Debug.Log(this.startPos);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            // スワイプの長さを初速度に変換する
            this.speed = swipeLength / 5000.0f;

            // 効果音再生
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);  // 移動
        this.speed *= 0.98f; // 減速
    }
}
