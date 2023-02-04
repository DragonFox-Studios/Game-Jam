using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyNavigation : MonoBehaviour
{

    public List<GameObject> waypoints = new List<GameObject>();
    int currentWaypoint = 0;
    private Transform target;
    public float speed = 1f;
    public float deathTime = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }



    void MoveTowardTarget()
    {
        target = waypoints[currentWaypoint].transform;
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if (Vector3.Distance(transform.position, target.position) < 0.001f)
        {
            ChooseNewTarget();
        }
    }

    void ChooseNewTarget()
    {
        currentWaypoint++;
        if (currentWaypoint >= waypoints.Count)
        {
            currentWaypoint = 0;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        if (collision.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(DeathAnimation());
        }
    }

    public IEnumerator DeathAnimation()
    {
        Debug.Log("playerDies");
        pauseGame.isGameRunning = !pauseGame.isGameRunning;
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

        //add cool shit here

        yield return new WaitForSeconds(deathTime);


        //then restart game
        pauseGame.isGameRunning = !pauseGame.isGameRunning;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    // Update is called once per frame
    void Update()
    {
        if (pauseGame.isGameRunning)
        {
            MoveTowardTarget();
        }
        
    }
}
