using UnityEngine;

public class enemyController : MonoBehaviour
{
    
    private Rigidbody2D _rbEng; // referencia al componente Rigidbody2D del enemigo
    private float _posX = 0f;// posicion inicial en x
    private float _posY = 4f; // posicion inicial en y
    private float _speedX = 0.005f; // velocidad en x (puede ser negativa, es usada para el eje Y tambien)




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rbEng = GetComponent<Rigidbody2D>(); // obtener el componente Rigidbody2D del objeto
    }

    // Update is called once per frame
    void Update()
    {
        // movimiento en X e Y usando una funcion seno para el eje Y
        if (_posX > 8f || _posX<-8)
        {
            _speedX = -_speedX;
        }
        _posX = _posX + _speedX;
        _posY = Mathf.Sin(_posX);
        _rbEng.position = new Vector2(_posX,4.5f+_posY); // actualizar la posicion del enemigo
    }
}
