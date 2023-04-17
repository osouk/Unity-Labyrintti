using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VihollisSpawn : MonoBehaviour
{
    public GameObject Vihu;
    public Transform SpawnPosition;
    public GameObject Spawner;

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {

            StartCoroutine(LuoVihollinen());
        }
    }
    IEnumerator LuoVihollinen()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 1; i++)
        {
            Instantiate(Vihu, SpawnPosition.position, Quaternion.identity);
            StartCoroutine(RikoOhjeet());
        }
    }

    IEnumerator RikoOhjeet()
    {
        yield return new WaitForSeconds(4f);
        for (int i = 0; i < 1; i++)
        {
            Destroy(Spawner);
        }
    }
}
