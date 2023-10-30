using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCam : MonoBehaviour
{
    public Transform player;
    public Vector3 dirtoplayer;
    private float smoothcam = 0.125f;


    void Start()
    {
        Vector3 camdir = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camdir = player.transform.position + dirtoplayer;
        Vector3 smoth = Vector3.Lerp(transform.position, camdir, smoothcam);
        transform.position = camdir;
        transform.LookAt(player.position);
    }
}
