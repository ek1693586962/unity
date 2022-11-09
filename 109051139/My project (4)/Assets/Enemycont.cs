using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycont : MonoBehaviour
{
    public GameObject Shot;
    public int Health = 5000;
    public const float ENEMYSPEED = 0.05f;

    private int counter = 0;
    Vector3 Enmeypos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        counter++;

        //enemy move
        if ((counter > 120) && (counter % 120 == 0))
        {
            Enmeypos = new Vector3(Random.Range(-2, 2) - transform.position.x, Random.Range(2, 2) - transform.position.y, 0);
            
        }

        if ((counter > 120) && (counter % 120 <= 60))
        {
            transform.Translate(Enmeypos / 60);
        }
            Vector3 ShotAngle = new Vector3(0, 0, Random.Range(0, 360));
        Vector3 ShotPos = transform.position + new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0);
        if (counter % 10 == 0)
        {
            GameObject ShotObj = Instantiate(Shot, transform.position, new Quaternion(0, 0, 0, 0));
            ShotObj.GetComponent<Enemyshot01>().InitAngle = Quaternion.Euler(ShotAngle);


        }
    }
    private void LateUpdate()
    {
        if(Health <=0)
        {
            Destroy(this.gameObject);
        }
    }
}
