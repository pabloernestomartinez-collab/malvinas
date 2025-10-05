using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{

    private Rigidbody2D _rb; // referencia al componente Rigidbody2D del jugador
    private Vector2 movepermanente; // vector para mantener el movimiento constante del jugador

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
    }
    private void OnMove(InputValue inputValue)
    {
        Vector2 move = inputValue.Get<Vector2>(); // obtener el valor del input
        if (move.x != 0 || move.y !=0)
        {
            movepermanente = move*4;
        }
        _rb.linearVelocity = movepermanente;// mantiene el movimiento del jugador
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb.position.x > 8f) // limitar el movimiento en X
        {
            _rb.position = new Vector2(8f, _rb.position.y);
        }
        if (_rb.position.x < -8f)
        {
            _rb.position = new Vector2(-8f, _rb.position.y);
        }
        if (_rb.position.y > 3f) // limitar el movimiento en Y
        {
            _rb.position = new Vector2(_rb.position.x, 3f);
        }
        if (_rb.position.y < -5.5f)
        {
            _rb.position = new Vector2(_rb.position.x, -5.5f);
        }
    }
private void OnAttack()
    {
        Debug.Log("atacando"); // borrar esta linea una vez depurado el programa
    }
}
