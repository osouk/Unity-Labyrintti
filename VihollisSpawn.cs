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
        if(player.gameObject.tag == "Player")
        {
            StartCoroutine(LuoVihollinen());
        }
    }
    IEnumerator LuoVihollinen()
    {
        yield return new WaitForSeconds(3f);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(Vihu, SpawnPosition.position, Quaternion.identity);
            Destroy(Spawner);
        }

    }
}
