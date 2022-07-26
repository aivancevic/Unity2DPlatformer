using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField] private int numOfPoints;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag.Equals("Player"))
        {
            AudioManager.PlaySound("Diamond Collect");
            ScoreManager.instance.AddScore(numOfPoints);
            Destroy(this.gameObject);
        }
    }

}
