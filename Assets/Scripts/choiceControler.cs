using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceControler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float rotationSpeed = 100f;
    [SerializeField]
    private GameObject rockPrefab;
    [SerializeField]
    private GameObject scissorPrefab;
    [SerializeField]
    private GameObject paperPrefab;

    [SerializeField]
    private GameObject RotationPivot;

    private GameObject rockGO;
    private GameObject scissorGO;
    private GameObject paperGO;

    void Start()
    {
        scissorGO = Instantiate(scissorPrefab,
            new Vector3(2, 2, RotationPivot.transform.position.z)
            , new Quaternion(0.504523754f, 0.504523873f, 0.49543494f, 0.49543491f));

        paperGO = Instantiate(paperPrefab, new Vector3(-2, 2, RotationPivot.transform.position.z),
               new Quaternion(-0.660664618f, 0, 0, 0.750681221f));

        rockGO = Instantiate(rockPrefab, new Vector3(0, -2, RotationPivot.transform.position.z),
            new Quaternion(0, -0.00248319586f, 0, 0.99999696f));

    }

    // Update is called once per frame
    void Update()
    {
        scissorGO.transform.Rotate(Vector3.one * rotationSpeed * Time.deltaTime);
        scissorGO.transform.RotateAround(RotationPivot.transform.position,Vector3.forward, rotationSpeed * Time.deltaTime);
        paperGO.transform.Rotate(Vector3.one * rotationSpeed * Time.deltaTime);
        paperGO.transform.RotateAround(RotationPivot.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        rockGO.transform.Rotate(Vector3.one * rotationSpeed * Time.deltaTime);
        rockGO.transform.RotateAround(RotationPivot.transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);

    }
}
