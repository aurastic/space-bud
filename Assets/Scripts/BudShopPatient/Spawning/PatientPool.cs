using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientPool : MonoBehaviour
{
   public static PatientPool patientPool;
   public List<GameObject> pooledPatients;
    public GameObject patientPrefab;
    private int amountToPool;
    [SerializeField] private IntegerObject queueListMaxCount;
    [SerializeField] private IntegerObject newPatientListMaxCount;
    private void Awake()
    {
        patientPool = this;
    }

    private void Start()
    {
        
        amountToPool = queueListMaxCount.value + newPatientListMaxCount.value;
        pooledPatients = new List<GameObject>();
        GameObject pt;
        for(int i = 0; i < amountToPool; i++)
        {
            pt = Instantiate(patientPrefab);
            pt.SetActive(false);
            pooledPatients.Add(pt);

        }
    }

    public GameObject GetPooledPatient()
    {
        for(int i = 0; i < amountToPool; i++)
        {
            if(!pooledPatients[i].activeInHierarchy)
            {
                return pooledPatients[i];
            }
        }
        return null;
    }
}
