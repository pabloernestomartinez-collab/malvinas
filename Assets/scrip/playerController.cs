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
        _rb.linearVelocity = movepermanente;// mantener el movimiento del jugador
    }
    private void OnAttack()
    {
        Debug.Log("atacando"); // borrar esta linea una vez depurado
    }
}
