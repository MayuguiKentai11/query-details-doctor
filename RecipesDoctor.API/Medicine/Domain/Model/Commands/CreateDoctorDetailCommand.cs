namespace RecipesDoctor.API.Medicine.Domain.Model.Commands;

public record CreateDoctorDetailCommand(string DescriptionLaboratory, string Molecule, string Especiality, string Cmp, string Name, 
    string Surname, string Region, string Department, string RepresentativeMan, string Address, string Status, int MatMay);