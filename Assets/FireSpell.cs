using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : MonoBehaviour
{
    public GameObject hand;
        public GameObject hand2;

 public Rigidbody bullet;
public float bulletSpeed = 300;

public Transform cameraTransform;

public bool block = false;
private Vector3 originaPosition;
void Start()
{
    originaPosition = cameraTransform.position;   
}

void Update()
{

if(block == false)
    if (hand.activeSelf && hand2.activeSelf)
    {
        StartCoroutine(shootBullet());
    }
}
IEnumerator shootBullet()
{
    block = true;
    Rigidbody bulletClone = (Rigidbody) Instantiate(bullet, cameraTransform.position, cameraTransform.rotation);
    bulletClone.velocity = cameraTransform.forward * bulletSpeed;
    yield return new WaitForSeconds(2.5f);
    Destroy(bulletClone);
    block = false;
}
}
