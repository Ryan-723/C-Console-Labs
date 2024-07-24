class sport : person
{
    public string sportName;
    public string teamName;
    public int playerNumber;

    override public string ToString(){
        teamName = "WBC";
        sportName = "Walking Basketball";
        playerNumber = 12;


        firstName = "Bob";
        lastName = "Smith";
        age = 55;
        birthdate = 110267;
        country = "Canada";
        

        return $" Sport Name: {sportName}\n Team Name: {teamName}\n Player Number: {playerNumber}\n First Name: {firstName}\n Last Name: {lastName}\n Age: {age}\n DOB: {birthdate}\n Country: {country}";
    }

}

