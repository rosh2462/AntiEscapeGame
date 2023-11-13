using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollowscript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float hoverLimit = 2f; 
    public float edgePanSpeed = 5f; 
    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }
    void Update()
    {
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cursorPos.y = initialPosition.y;
        cursorPos.z = initialPosition.z; 
        float distanceToCursor = Mathf.Abs(cursorPos.x - initialPosition.x);
        if (distanceToCursor > hoverLimit)
        {
            cursorPos.x = initialPosition.x + Mathf.Sign(cursorPos.x - initialPosition.x) * hoverLimit;
        }
        if (IsCursorAtScreenEdge())
        {
            transform.position = Vector3.Lerp(transform.position, cursorPos, moveSpeed * Time.deltaTime);
        }
    }
    bool IsCursorAtScreenEdge()
    {
        float edgeThreshold = 20f; 
        Vector3 mousePos = Input.mousePosition;
        bool atEdge = false;
        if (mousePos.x <= edgeThreshold || mousePos.x >= Screen.width - edgeThreshold)
        {
            atEdge = true;
        }
        return atEdge;
    }
}
