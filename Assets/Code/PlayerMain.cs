using Assets.Models;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Assets.Code
{
    public class PlayerMain : MonoBehaviour
    {
        public Slider healthSlider;                                 // Reference to the UI's health bar.
        public string DealthScene;
        private PlayerModel Player;

        void Start()
        {
            Player = new PlayerModel();
            Player.Health = 100;
            Player.IsDead = false;
        }

        // Update is called once per frame
        void Update()
        {
        }
        public void Move(float value)
        {
            var location = this.gameObject.transform.position;
            location.x = value;
            transform.position = location;
        }
        public void TakeDamage(int amount)
        {

            // Reduce the current health by the damage amount.
            Player.Health -= amount;

            // Set the health bar's value to the current health.
            healthSlider.value = this.Player.Health;


            // If the player has lost all it's health and the death flag hasn't been set yet...
            if (Player.Health <= 0 && !Player.IsDead)
            {
                LoadScene(DealthScene);
            }
        }
        public void LoadScene(string scene)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }
}
