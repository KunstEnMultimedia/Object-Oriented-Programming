class SithLord
{
    private int energie;
    private string sithName { get; set; }
    
    public void SetName(string name)
    {
        sithName = name;
    }

    public string SithMail
    {
        get 
        {
            return $"{sithName}@gmail.com";
        }

    }

    public void ResetLord(int resetwaarde)
    {
        Energie = resetwaarde;
    }
    public int Energie
    {
        get
        {
            return energie;  //geeft de ingevoerde waarde energie als Energie
        }
        private set
        {
            if (value >= 0)
                energie = value; // veranderd energie naar wat Energie zijn waarde is
        }
    }
}


