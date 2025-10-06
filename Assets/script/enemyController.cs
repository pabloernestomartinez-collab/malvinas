using UnityEngine;

public class enemyController : MonoBehaviour
{
    public GameObject misilEngPrefab; // prefab del misil del enemigo
    private Rigidbody2D _rbEng; // referencia al componente Rigidbody2D del enemigo
    private float _posX = 7f;// posicion inicial en x
    private float _posY = 4.5f; // posicion inicial en y
    private float _speedX = 0.005f; // velocidad en x (puede ser negativa, es usada para el eje Y tambien)
    private float _contador = 0f; // contador para la funcion seno
    private float _delay = 0f; // tiempo desde el ultimo disparo




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
        _posX = _posX + _speedX; // actualizar la posicion en X
        _contador = _contador + 0.005f; // incrementa el contador para la funcion seno
        _posY = 4.5f + Mathf.Sin(_contador); // actualizar la posicion en Y usando la funcion seno
        _rbEng.position = new Vector2(_posX,_posY); // actualizar la posicion del enemigo

        // disparo del misil cada 1 segundos
        _delay += Time.deltaTime; // incrementar el delay
        if (_delay>1f)// si no ha pasado el delay, no se puede disparar
        {
            _delay = 0f; // resetear el delay
       
            // instanciar un nuevo misil en la posición actual del enemigo
            Instantiate(misilEngPrefab, new Vector3(_rbEng.position.x, _rbEng.position.y - 1, 0), Quaternion.identity); 
        }
        
    }
}
