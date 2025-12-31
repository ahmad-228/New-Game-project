using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject[] cars;
    int currentIndex = 0;

    void Start()
    {
        showcar(currentIndex);
        
    }
    public void nextcar(){
        currentIndex++;
        if(currentIndex >= cars.Length){
            currentIndex = 0;
        }
        showcar(currentIndex);
    }
   public void Previoscar()
{
    currentIndex--;
    if (currentIndex < 0)
    {
        currentIndex = cars.Length - 1;
    }
    showcar(currentIndex);
}


    // Update is called once per frame
    void showcar(int index)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(i == index);
        }
    }
}
