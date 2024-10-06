namespace RecipesDoctor.API.Medicine.Interfaces.REST.Resources;

public record CreateDoctorDetailResource(string DescriptionLaboratory, string Molecule, string Especiality, string Cmp, string Name, string Surname, string Region, string Department, string RepresentativeMan, string Address, 
    string Status, int MatMay);