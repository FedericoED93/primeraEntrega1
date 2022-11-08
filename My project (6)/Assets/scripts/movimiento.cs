using UnityEngine;

public class movimiento : MonoBehaviour
{
    private float movX;
    private float movY;
    public float speed = 5f;
    public Rigidbody rb;
    public Vector3 pos;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovimientoJugador();

         if(Input.GetKey(KeyCode.Q))
    {
      transform.Rotate(0,-2,0);
    }
    
    if(Input.GetKey(KeyCode.E))
    {
      transform.Rotate(0,2,0);
    }

    }

    void MovimientoJugador(){
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector3 inputJugador = new Vector3(movX, 0, movY);
        rb.AddForce(inputJugador * speed);

        if (inputJugador == Vector3.zero){
            anim.SetBool("estaCorriendo",false);
        }else{
            anim.SetBool("estaCorriendo",true);
        }
    }
}
