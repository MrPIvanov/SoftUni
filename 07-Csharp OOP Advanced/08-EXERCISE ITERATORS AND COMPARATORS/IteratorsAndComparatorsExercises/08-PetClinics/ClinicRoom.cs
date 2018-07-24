public class ClinicRoom
{
    public int IndexInClinic { get; set; }

    public Pet Pet { get; set; }


    public ClinicRoom(int index)
    {
        this.IndexInClinic = index;
        this.Pet = null;
    }
}