using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCollision : MonoBehaviour
{
<<<<<<< HEAD


    private void OnTriggerEnter(Collider collider)
    {




        if (collider.GetComponent<EnemyController>() != null)
        {
            // reduz a vida do inimigo.....
            collider.transform.GetComponent<EnemyController>().receberDano(1);

        }

        if (collider.GetComponent<PlayerManager>() != null)
        {
            // reduz a vida do inimigo.....
            collider.transform.GetComponent<PlayerManager>().receberDano(1);

        }






=======
    private void OnTriggerEnter(Collider collider)
    {

        if ( collider.GetComponent<CharacterStatus>() != null )
        {
            collider.GetComponent<CharacterStatus>().receberDano(1);
        }

>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
    }
}
