namespace Portfolio.Models;

public record Project(
    string Title,
    string Description,
    string VideoPath,
    string[] TechStack,
    string GithubUrl
);

public record Skill(
    string Name,
    string Description,
    string IconPath
);

public record Experience(
    string CompanyName,
    string Role,
    string Period,
    string LogoPath,
    string[] Highlights
);