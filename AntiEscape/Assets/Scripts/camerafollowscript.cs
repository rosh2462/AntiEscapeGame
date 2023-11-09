using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollowscript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float hoverLimit = 2f; 
    private Vector3 initialPosition;
    private Vector3 lastCursorPosition;
    void Start()
    {
        initialPosition = transform.position;
        lastCursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPos.y = initialPosition.y; 
        cursorPos.z = initialPosition.z;
        float cursorDistance = Vector3.Distance(cursorPos, lastCursorPosition);
        if (cursorDistance > 0.01f)
        {
            float distanceToCursor = Mathf.Abs(cursorPos.x - initialPosition.x);
            if (distanceToCursor > hoverLimit)
            {
                cursorPos.x = initialPosition.x + Mathf.Sign(cursorPos.x - initialPosition.x) * hoverLimit;
            }

            transform.position = Vector3.Lerp(transform.position, cursorPos, moveSpeed * Time.deltaTime);
        }
        lastCursorPosition = cursorPos;
    }
}