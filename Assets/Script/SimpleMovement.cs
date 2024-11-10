using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SimpleMovement : MonoBehaviourPunCallbacks
{
    public float velocidad = 0;

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");

            velocidad = 0;
            Vector3 desplazamiento = new Vector3(movimientoHorizontal, 0, movimientoVertical) * velocidad * Time.deltaTime;

            transform.Translate(desplazamiento);
            
        }
    }
}
