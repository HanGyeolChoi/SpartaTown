using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private Transform player;
   
    void Update()
    {
        Vector3 targetpos = new Vector3(player.position.x, player.position.y, -10);
        transform.position = targetpos;
    }
}
