using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackDetection : MonoBehaviour
{
<<<<<<< HEAD
    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            transform.parent.GetComponent<EnemyController>().podeAtacar = true;


=======
    private void OnTriggerStay(Collider collider)
    {
        if( collider.gameObject.tag == "Player")
        {
            transform.parent.GetComponent<EnemyController>().podeAtacar = true;
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
        }
    }
}
