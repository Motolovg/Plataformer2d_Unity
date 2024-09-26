using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);

        var heatlh = collision.gameObject.GetComponent<HealthBase>();

        if(heatlh != null)
        {
            heatlh.Damage(damage);
        }
    }
}
