using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private int vida = 0;
     

    // Variavel de controle de detecção do Inimigo
     public float velocidade = 0.5f;
=======
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Animator animator;

    // Variável de ataque
    public bool podeAtacar = false;

    // Variáveis controle de detecção do inimigo
    public float velocidade;
    bool chegouAoDestino = true;
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a

    bool rondarArea = true;
    bool seguirJogador = false;

<<<<<<< HEAD
    bool chegouAoDestino = true;
   
    Vector3 destino;
    Vector3 areaOriginal;

    // variavel atack
     public bool podeAtacar = false;

    Rigidbody rb;
    Animator animator;
    private float rotacaoX;
=======
    Vector3 destino;
    Vector3 areaOriginal;

    Rigidbody rb;
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a

    void Start()
    {
        animator = GetComponent<Animator>();
        destino = Vector3.zero;
        areaOriginal = transform.Find("AreaDeteccao").transform.localScale;
        rb = GetComponent<Rigidbody>();
<<<<<<< HEAD

=======
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
    }

    void FixedUpdate()
    {

<<<<<<< HEAD
         if (podeAtacar == true)
=======
        if( podeAtacar == true )
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
        {
            animator.SetBool("estaAtacando", true);
            return;
        }
<<<<<<< HEAD
      
        if (seguirJogador == true)



=======

        // Criar uma função que desabilita o podeAtacar
        // e desabilita também a animação estaAtacando
        // Na animação do inimigo, criar um evento
        // que chama essa função. Fim :)

        if( seguirJogador == true)
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
        {
            animator.SetBool("estaAndando", true);
            Vector3 posicaoJogador = GameObject.FindWithTag("Player").transform.position;
            transform.position = Vector3.MoveTowards(transform.position, posicaoJogador, Time.deltaTime * velocidade);
            
<<<<<<< HEAD
            // olhar para jogador 
            float roracaoX = transform.position.x;
            transform.LookAt(posicaoJogador);
            // corigir posicao x
            transform.rotation = Quaternion.Euler(
                rotacaoX,
                transform.rotation.eulerAngles.y,
                transform.rotation.eulerAngles.z);
        }
        

        if (rondarArea == true)
        {



              if (chegouAoDestino == true)
            {
                float posicaoX = Random.Range(-areaOriginal.x / 2, areaOriginal.x / 2);
                float posicaoZ = Random.Range(-areaOriginal.z / 2, areaOriginal.z / 2);
                destino = new Vector3(posicaoX, 0, posicaoZ);
                chegouAoDestino = false;

                Invoke("desabilitaChegouAoDestino", 2);


            }


              if (chegouAoDestino == false)
            {
                animator.SetBool("estaAndando", true);
                transform.position = Vector3.MoveTowards(transform.position, destino, Time.deltaTime * velocidade);


            }

              if (Vector3.Distance(transform.position, destino) < 0.1f)
            {
                chegouAoDestino = true;


            }

            void habilitaChegouAoDestino()
            {
                chegouAoDestino = false;
            }
        }

         void desabilitaAtaque()
        {
            animator.SetBool("estaAtacando", false);
            podeAtacar = false;
        }
       
        void desabilitaChegouAoDestino()
        {

            chegouAoDestino = false;
            transform.LookAt(destino);
        }
    }
    void verificarMorte()
    {
        if (vida <= 0) 
        {
           Destroy(gameObject);
        }
    }



    public void receberDano( int valor)
    {
        vida -= valor;
        verificarMorte();
=======
            // Olhar para o jogador
            float rotacaoX = transform.rotation.x;
            transform.LookAt( posicaoJogador );
            // Corrigir posição X
            transform.rotation = Quaternion.Euler(
                    rotacaoX,
                    transform.rotation.eulerAngles.y,
                    transform.rotation.eulerAngles.z
                );
        }

        if( rondarArea == true)
        {
            if (chegouAoDestino == true)
            {
                float posicaoX = Random.Range(-areaOriginal.x / 2, areaOriginal.x / 2);
                float posicaoZ = Random.Range(-areaOriginal.z / 2, areaOriginal.z / 2);
                destino = new Vector3(posicaoX, transform.position.y, posicaoZ);

                Invoke("desabilitaChegouAoDestino", 2);
            }

            if (chegouAoDestino == false)
            {
                animator.SetBool("estaAndando", true);
                transform.position = Vector3.MoveTowards(transform.position, destino, Time.deltaTime * velocidade);
            }

            if (Vector3.Distance(transform.position, destino) < 0.1f)
            {
                chegouAoDestino = true;
                animator.SetBool("estaAndando", false);
            }
        }
        
    }

    void desabilitaAtaque()
    {
        animator.SetBool("estaAtacando", false);
        podeAtacar = false;
    }

    void desabilitaChegouAoDestino()
    {
        chegouAoDestino = false;
        transform.LookAt( destino );
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
    }

    private void OnCollisionEnter(Collision collision)
    {
<<<<<<< HEAD
         if (rb.velocity.magnitude < 0.1f)
=======
        if ( rb.velocity.magnitude < 0.1f )
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
        {
            chegouAoDestino = true;
        }
    }
<<<<<<< HEAD
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            seguirJogador = true;
            rondarArea    =  false;
        }
    }
    private void OnTriggerExite(Collider collider)
=======

    private void OnTriggerStay(Collider collider)
    {
        if( collider.gameObject.tag == "Player")
        {
            seguirJogador = true;
            rondarArea = false;
        }
    }

    private void OnTriggerExit(Collider collider)
>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
    {
        if (collider.gameObject.tag == "Player")
        {
            seguirJogador = false;
            rondarArea = true;
        }
    }
<<<<<<< HEAD
=======

>>>>>>> 99489a5af34ed01c6a2af0f6cf4ee1a30fa6609a
}
