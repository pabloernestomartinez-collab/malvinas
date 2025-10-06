using UnityEngine;

public class missilArg : MonoBehaviour
{
    private Rigidbody2D _rb; // referencia al componente Rigidbody2D del misil
    private float _speed = 10f; // velocidad del misil

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2f); // destruir el misil después de 2 segundos para evitar que permanezca en la escena
        _rb.position += Vector2.up * _speed * Time.deltaTime; // mover el misil hacia arriba a una velocidad constante
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy")) // si el misil colisiona con un objeto que tiene la etiqueta "Enemy"
        {
            Destroy(collision.gameObject); // destruir el objeto que colisiona con el misil
            Destroy(gameObject);
        }
    }


}
