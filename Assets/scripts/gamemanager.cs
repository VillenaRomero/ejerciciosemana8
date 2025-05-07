using System;
using Unity.VisualScripting;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public int EnemyHP = 100;
    public int EnemyEnergy = 5 ;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ExcecuteInteraction();
    }
    public void ExcecuteInteraction() {
        int randomHit = UnityEngine.Random.Range(5, 30);
        int randomDamage = UnityEngine.Random.Range(0, 10);

        EnemyHP -= randomHit;
        EnemyEnergy--;

        try
        {
            if (EnemyHP == 0 ||EnemyEnergy == 0)
                throw new Exception("esta muerto");
                
            EnemyHP = (EnemyHP - randomHit < 0) ? 0 : EnemyHP - randomHit;
            EnemyEnergy--;
            DebugEnemy(randomDamage, randomHit);

        }
        catch (Exception e) {
            Debug.LogError("error inesperado " + e.Message);
        }
        finally {
            Debug.LogError("TERMINAMOS DE INTENTAR LAS EXPECPICONES");
        }
    }
    public void DebugEnemy(int _randomdamage, int _randomhit) { 
        Debug.Log("turno Durothar");
        Debug.Log("Durothar hace : " + _randomdamage + " de daño");
        Debug.Log("Durothar recibe : " + _randomhit + "de daño ke queda : " + EnemyHP);
        Debug.Log("A durothar le quedan " + EnemyEnergy + "de energia");
    }
}
