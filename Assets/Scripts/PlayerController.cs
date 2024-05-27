using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class PlayerController : NetworkBehaviour
{
    void Update()
    {
        if(!isLocalPlayer) return;
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.transform.position.y;

        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        targetPosition.y = transform.position.y; // Оставляем позицию по высоте неизменной

        transform.position = targetPosition;
    }
}
