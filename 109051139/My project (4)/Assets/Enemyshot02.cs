using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshot02 : MonoBehaviour
{
    public int ATK = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, 0.02f));

        if ((transform.position.y >= 5.5f) || (transform.position.y <= -5.5f) ||
            (transform.position.x >= 5.5f) || (transform.position.x <= -5.5f))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter");
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().Health--;
            Destroy(this.gameObject);
        }
    }
}