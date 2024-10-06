namespace RecipesDoctor.API.Medicine.Interfaces.REST.Resources;

public record DoctorDetailResource(int Id, string DescriptionLaboratory, string Molecule, string Speciality, string Cmp, string Name, string Surname,string Department, 
    string YtdSun23, string YtdSun24, string QtrSetNov, string QtrDicFeb, string QtrMarMay, string QtrJunAgo);