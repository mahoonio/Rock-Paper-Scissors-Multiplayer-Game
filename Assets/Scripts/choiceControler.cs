using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceControler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float floatSpeed = 100f;
    public GameObject rockPrefab;
    public GameObject scissorPrefab;
    public GameObject paperPrefab;

    private GameObject rockGO;
    private GameObject scissorGO;
    private GameObject paperGO; 

    private Rigidbody paperRb, scissorRb, rockRb;

    private float getRandomValueX(GameObject gameObject)
    {

        return Random.Range(-10, 10);

    }
    private float getRandomValueY(GameObject gameObject)
    {

        return Random.Range(-10, 10);
    }

    private float getRandomXPos()
    {
        return Random.Range(-6, 6);
    }
    private float getRandomYPos()
    {
        return Random.Range(-2.5f, 4);
    }
    IEnumerator AnimateObjectsSlowly()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            paperRb.AddForce(new Vector3(getRandomValueX(paperPrefab), getRandomValueY(paperPrefab), getRandomValueX(paperPrefab)) * Time.deltaTime * floatSpeed);
            scissorRb.AddForce(new Vector3(getRandomValueX(scissorPrefab), getRandomValueY(scissorPrefab), 0) * Time.deltaTime * floatSpeed);
            rockRb.AddForce(new Vector3(getRandomValueX(rockPrefab), getRandomValueY(rockPrefab), 0) * Time.deltaTime * floatSpeed);
            
        }
    }
    void Start()
    {
        scissorGO = Instantiate(scissorPrefab,
            new Vector3(getRandomXPos(), getRandomYPos(), -4.42999983f)
            , new Quaternion(0.504523754f, 0.504523873f, 0.49543494f, 0.49543491f));
        scissorRb = scissorGO.GetComponent<Rigidbody>();

        paperGO = Instantiate(paperPrefab, new Vector3(getRandomXPos(), getRandomYPos(), -4.53999996f),
               new Quaternion(-0.660664618f, 0, 0, 0.750681221f));
        paperRb = paperGO.GetComponent<Rigidbody>();

        rockGO = Instantiate(rockPrefab, new Vector3(getRandomXPos(), getRandomYPos(), -4.45f),
            new Quaternion(0, -0.00248319586f, 0, 0.99999696f));
        rockRb = rockGO.GetComponent<Rigidbody>();

        StartCoroutine(AnimateObjectsSlowly());
    }

    // Update is called once per frame
    void Update()
    {

      

    }
}
