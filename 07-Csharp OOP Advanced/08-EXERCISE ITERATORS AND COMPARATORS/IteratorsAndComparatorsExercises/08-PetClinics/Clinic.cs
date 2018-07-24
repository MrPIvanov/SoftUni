using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Clinic : IEnumerable<ClinicRoom>
{
    public string  Name { get; set; }

    public List<ClinicRoom> Rooms { get; set; }


    public Clinic(string name, int roomNumber)
    {
        this.Name = name;
        this.Rooms = new List<ClinicRoom>();

        if (roomNumber%2==0)
        {
            throw new System.ArgumentException("Invalid Operation!");
        }
        for (int i = 0; i < roomNumber; i++)
        {
            this.Rooms.Add(new ClinicRoom(i));
        }
    }

    public IEnumerator<ClinicRoom> GetEnumerator()
    {
        int startingIndex = this.Rooms.Count / 2 + 1;
        int indexToReturn = startingIndex;
        for (int i = 0; i < this.Rooms.Count; i++)
        {
            var itemToAddRemove = i;

            if (i%2!=0)
            {
                itemToAddRemove *= -1;
            }

            indexToReturn += itemToAddRemove;


            yield return this.Rooms[indexToReturn -1];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }


    public  bool TryAddPet(List<Pet> allPets, string petName)
    {
        var pet = allPets.Where(x => x.Name == petName).FirstOrDefault();
        if (pet == null)
        {
            throw new ArgumentException("Invalid Operation!"); // or only write false
        }
        else
        {
            foreach (var room in this)
            {
                if (room.Pet == null)
                {
                    room.Pet = pet;
                    return true;
                }
            }
            return false;
        }
    }

    public bool ReleasePet()
    {
        var midleIndex = this.Rooms.Count / 2;
        for (int i = midleIndex; i < this.Rooms.Count; i++)
        {
            var currentRoom = this.Rooms[i];

            if (currentRoom.Pet!=null)
            {
                currentRoom.Pet = null;
                return true;
            }
        }

        for (int i = 0; i < midleIndex; i++)
        {
            var currentRoom = this.Rooms[i];

            if (currentRoom.Pet != null)
            {
                currentRoom.Pet = null;
                return true;
            }
        }
        return false;
    }

    internal bool CheckForRoom()
    {
        for (int i = 0; i < this.Rooms.Count; i++)
        {
            if (this.Rooms[i].Pet==null)
            {
                return true;
            }
        }
        return false;
    }
}