using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManipulation : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Vector3 originalScale;

    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        originalScale = transform.localScale;
    }

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * 1f); // 向左移动1个单位
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right * 1f); // 向右移动1个单位
    }

    public void ScaleUp()
    {
        transform.localScale *= 1.2f; // 放大1.2倍
    }

    public void ScaleDown()
    {
        transform.localScale *= 0.8f; // 缩小0.8倍
    }

    public void RotateLeft()
    {
        transform.Rotate(Vector3.up, 45f, Space.Self); // 顺时针旋转45度
    }


    public void RotateRight()
    {
        transform.Rotate(Vector3.down, 45f, Space.Self); // 逆时针旋转45度
    }
    public void ResetObject()
    {
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        transform.localScale = originalScale;
    }
}
