using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalScript : MonoBehaviour
{
    [SerializeField] private int enemies;
    [SerializeField] private bool isBossDead;

    // Start is called before the first frame update
    void Start()
    {
            //      variável      ;         condição         ;     execução
        for(int createdEnemies = 0; createdEnemies <= enemies; createdEnemies++){
            print("Criar inimigo de núemro " + createdEnemies);
        }

        //while (true /*deadEnemies < 100 && isBossDead == false*/ /* <- Antiga condição*/)
        //{
        //    print("Spawnar inimigo");
        //    deadEnemies++;
        //    if(deadEnemies == 100)
        //    {
        //        print("Matou todos os inimigos");
        //        break;
        //        //Antigos comandos
        //        //print("Mostrar Boss");
        //        //isBossDead = true;
        //    }

        //}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
