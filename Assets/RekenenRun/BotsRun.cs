using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotsRun : MonoBehaviour
{

    public float speed;

    void Update()
    {
        if (RunPlayer.gameStart)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "finish")
        {
            RunPlayer.lost = true;
            Destroy(this.gameObject);
        }
    }
}