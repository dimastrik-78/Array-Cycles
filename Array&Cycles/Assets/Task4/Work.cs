using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Work : MonoBehaviour
{
    public List<Rooms> Rooms;
    private List<Rooms> ResetRooms;
    public Text CountPetText;
    public Text CountNameText;
    public Text CountNumText;
    private void Start()
    {
        ResetRooms = Rooms;

    }
    public void ResetSettings()
    {
        while (Rooms.Count < ResetRooms.Count)
        {
            Rooms.Add(new Rooms());
        }
        for (int i = 0; i < ResetRooms.Count; i++)
        {
            Rooms[i] = ResetRooms[i];
        }
    }
    public void StartWork()
    {
        CountPet();
        CountManName();
        Number();
        ChangeRoom();
        DeleteRoom();
        ChangePetAndRoom();
    }
    public void CountPet()
    {
        int CountPet = 0;
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].ChengePet)
            {
                CountPet++;
            }
        }
        CountPetText.text = $"Pet = {CountPet}";
    }
    public void CountManName()
    {
        int CountMan = 0;
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].ChengeName == "Смит")
            {
                CountMan++;
            }
        }
        CountPetText.text = $"Name = {CountMan}";
    }
    public void Number()
    {
        int CountRoom = 0;
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].ChengeRoom >= 0 && Rooms[i].ChengeRoom <= 9)
            {
                CountRoom++;
            }
        }
        CountPetText.text = $"Num = {CountRoom}";
    }
    public void ChangeRoom()
    {
        List<Rooms> Rooms2 = new List<Rooms>();
        for (int i = Rooms.Count; i > 0; i--)
        {
            Rooms2.Add(Rooms[i]);
        }
        for (int i = 0; i < Rooms.Count; i++)
        {
            Rooms[i] = Rooms2[i];
        }
    }
    public void DeleteRoom()
    {
        for (int i = 0; i < Rooms.Count; i++)
        {
            if (Rooms[i].ChengeRoom % 3 == 0)
            {
                Rooms[i].GetComponent<GameObject>().SetActive(false);
                Rooms.RemoveAt(i);
            }
        }
    }
    public void ChangePetAndRoom()
    {
        for (int i = Rooms.Count; i > 0; i--)
        {
            if (Rooms[i].ChengePet)
            {

            }
        }
    }
}
