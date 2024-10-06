namespace RecipesDoctor.API.Medicine.Domain.Model.Aggregates;

public class DoctorDetail
{
    public int Id { get;  private set; }

    public string DescriptionLaboratory { get; private set; }

    public string Molecule { get; private set; }

    public string Especiality { get; private set; } 

    public string Cmp { get; private set; } 

    public string Name { get; private set; } 

    public string Surname { get; private set; } 

    public string Department { get; private set; } 

    public string YtdSun23 { get; private set; }
    
    public string YtdSun24 { get; private set; }

    public string QtrSetNov { get; private set; } 

    public string QtrDicFeb { get; private set; } 

    public string QtrMarMay { get; private set; } 

    public string QtrJunAgo { get; private set; }

    public DoctorDetail()
    {
        
    }

    public DoctorDetail(string descriptionLaboratory, string molecule, string especiality, string cmp, string name,
        string surname, string department,
        string ytdSun23, string ytdSun24, string qtrSetNov, string qtrDicFeb, string qtrMarMay, string qtrJunAgo)
    {
        DescriptionLaboratory = descriptionLaboratory;
        Molecule = molecule;
        Especiality = especiality;
        Cmp = cmp;
        Name = name;
        Surname = surname;
        Department = department;
        YtdSun23 = ytdSun23;
        YtdSun24 = ytdSun24;
        QtrSetNov = qtrSetNov;
        QtrDicFeb = qtrDicFeb;
        QtrMarMay = qtrMarMay;
        QtrJunAgo = qtrJunAgo;
    }
    
}