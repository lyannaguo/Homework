using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour
{

    public GameObject Projectile;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Projectile.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Projectile.transform.position + offset;
    }
}