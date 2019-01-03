﻿using UnityEngine;

namespace Pattern.Prototype
{
    public class Client : MonoBehaviour
    {
        public Drone m_Drone;       // Prototype Drone that we want to spawn.
        public Sniper m_Sniper;
        public SpawnerEnemy m_Spawner;

        private Enemy m_Spawn;
        private int m_IncrementorDrone = 0;
        private int m_IncrementorSniper = 0;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_Spawn = m_Spawner.SpawnEnemy(m_Drone); // Even if m_Drone is Drone type because of polymorphism it inheritants it's parent class type, Enemy;

                m_Spawn.name = "Drone_Clone_" + ++m_IncrementorDrone;
                m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.5f);

            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                m_Spawn = m_Spawner.SpawnEnemy(m_Sniper); // Even if m_Drone is Drone type because of polymorphism it inheritants it's parent class type, Enemy;

                m_Spawn.name = "Sniper_Clone_" + ++m_IncrementorSniper;
                m_Spawn.transform.Translate(Vector3.forward * m_IncrementorSniper * 1.5f);
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 200, 20), "Press D to spawn a drone.");
            GUI.Label(new Rect(10, 30, 200, 20), "Press S to spawn a sniper.");
        }
    }
}