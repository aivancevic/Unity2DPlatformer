using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private GameObject[] diamonds;
    // Start is called before the first frame update
    void Start()
    {
        spawnDiamonds();
    }

    private void spawnDiamonds()
    {
        if (Random.Range(1, 4) == 1)
        {
            Instantiate(diamonds[Random.Range(0, 10)], this.gameObject.transform.GetChild(0).position, Quaternion.identity);
        }
    }
}
