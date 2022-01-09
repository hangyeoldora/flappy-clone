using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour // MonoBehaviour 상속 받아서 사용
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // print 문
        // Debug.Log("Start 입니다.");
    }

    // Update is called once per frame, 매 프레임마다 실행
    void Update()
    {
        // 마우스 왼쪽버튼 0
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower; // 2차원 좌표 (0,1) y좌표 3만큼 점프
        }
        // Debug.Log("Update 입니다.");
    }
}
