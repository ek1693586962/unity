using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Shot;
    public const float PLAYSPEED = 0.05f;
    public int Health = 30;

    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        //create shot

        if (counter % 10 == 0)
        {
            Instantiate(Shot, transform.position, new Quaternion(0, 0, 0, 0));
        }



        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 5)
        {
            transform.Translate(new Vector2(0, PLAYSPEED));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3.5f)
        {
            transform.Translate(new Vector2(0, -PLAYSPEED));
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -4.95f)
        {
            transform.Translate(new Vector2(-PLAYSPEED, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 4.95f)
        {
            transform.Translate(new Vector2(PLAYSPEED, 0));
        }
    }
    private void LateUpdate()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
