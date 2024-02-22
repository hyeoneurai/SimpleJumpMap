using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    private float initPosX;
    private float initPosY;
    private float initPosZ;
    [Range(-5f, 5f)]public float distance = 1f;
    public float moveSpeed = 2f;
    public int a = 1;
    public bool re;

    private void Awake()
    {
        initPosX = transform.position.x;
        initPosY = transform.position.y;
        initPosZ = transform.position.z;
    }

    protected virtual void Update()
    {
        
    }

    public void MoveX()
    {
        float curPosx = transform.position.x;
        if (re)
        {
            if (curPosx >= initPosX + distance)
            {
                a = -1;
            }
            else if (curPosx <= initPosX - distance)
            {
                a = 1;
            }
            transform.position += new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime * a;
        }
        else
        {
            if (curPosx >= initPosX + distance)
            {
                a = 1;
            }
            else if (curPosx <= initPosX - distance)
            {
                a = -1;
            }
            transform.position -= new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime * a;
        }
    }

    public void MoveY()
    {
        float curPosy = transform.position.y;
        if (curPosy >= initPosY + distance)
        {
            a = -1;
        }
        else if (curPosy <= initPosY - distance)
        {
            a = 1;
        }
        transform.position += new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime * a;
    }

    public void MoveZ()
    {
        float curPosz = transform.position.z;
        if (re)
        {
            if (curPosz >= initPosZ + distance)
            {
                a = -1;
            }
            else if (curPosz <= initPosZ - distance)
            {
                a = 1;
            }
            transform.position += new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime * a;
        }
        else
        {
            if (curPosz >= initPosZ + distance)
            {
                a = 1;
            }
            else if (curPosz <= initPosZ - distance)
            {
                a = -1;
            }
            transform.position -= new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime * a;
        }
    }
}
