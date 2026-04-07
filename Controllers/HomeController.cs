using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevPortfolio.Models;

namespace DevPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new PortfolioViewModel
        {
            Name = "Geraldo Neto",
            Title = "Desenvolvedor .NET | ASP.NET Core | C#",
            AboutMe = "Sou um desenvolvedor apaixonado por criar soluções eficientes e interfaces premium, focando na melhor experiência de usuário e qualidade do código.",
            AboutMeExtended = "Com 5 anos de experiência na área de desenvolvimento, tenho me focado em arquiteturas escaláveis, clean code e princípios SOLID. Acredito que o design aliado a uma engenharia robusta cria produtos inesquecíveis. Busco sempre aprender novas tecnologias e colaborar com equipes engajadas em resolver problemas reais.",
            CvFileUrl = "/assets/cv.pdf",
            Email = "geraldospn26@gmail.com",
            LinkedInUrl = "https://www.linkedin.com/in/geraldo-neto-5b919a22b/",
            SkillCategories = new List<SkillCategory>
            {
                new SkillCategory
                {
                    Title = "Backend Development",
                    Skills = new List<TechSkill>
                    {
                        new TechSkill { Name = "C# / .NET", DeviconClass = "devicon-csharp-plain colored" },
                        new TechSkill { Name = "Java", DeviconClass = "devicon-java-plain colored" },
                        new TechSkill { Name = "Python", DeviconClass = "devicon-python-plain colored" },
                        new TechSkill { Name = "Node.js", DeviconClass = "devicon-nodejs-plain colored" },
                        new TechSkill { Name = "MySQL", DeviconClass = "devicon-mysql-plain colored" },
                        new TechSkill { Name = "PostgreSQL", DeviconClass = "devicon-postgresql-plain colored" }
                    }
                },
                new SkillCategory
                {
                    Title = "Frontend Development",
                    Skills = new List<TechSkill>
                    {
                        new TechSkill { Name = "HTML5", DeviconClass = "devicon-html5-plain colored" },
                        new TechSkill { Name = "CSS3", DeviconClass = "devicon-css3-plain colored" },
                        new TechSkill { Name = "Tailwind CSS", DeviconClass = "devicon-tailwindcss-original colored" },
                        new TechSkill { Name = "JavaScript", DeviconClass = "devicon-javascript-plain colored" },
                        new TechSkill { Name = "TypeScript", DeviconClass = "devicon-typescript-plain colored" },
                        new TechSkill { Name = "React", DeviconClass = "devicon-react-original colored" },
                        new TechSkill { Name = "Next.js", DeviconClass = "devicon-nextjs-plain colored" }, // Or just white/black
                        new TechSkill { Name = "Vue.js", DeviconClass = "devicon-vuejs-plain colored" }
                    }
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Sistema de Gestão",
                    Description = "Um sistema completo de gestão construído com ASP.NET Core, focando em performance e arquitetura limpa.",
                    ImageUrl = "/images/project1.png",
                    Technologies = new List<string> { "ASP.NET Core", "Entity Framework", "SQL Server" },
                    GithubUrl = "https://github.com/seugithub",
                    LiveUrl = "#"
                },
                new Project
                {
                    Id = 2,
                    Title = "API de E-commerce",
                    Description = "API RESTful performática integrando gateways de pagamento e autenticação JWT.",
                    ImageUrl = "/images/project2.png",
                    Technologies = new List<string> { ".NET Web API", "Redis", "JWT" },
                    GithubUrl = "https://github.com/seugithub",
                    LiveUrl = "#"
                }
            },
            Experiences = new List<Experience>
            {
                new Experience
                {
                    Id = 1,
                    Role = "Desenvolvedor Sênior",
                    Company = "Tech Solutions",
                    Period = "Jan 2023 - Presente",
                    Description = "Liderança de equipe técnica, arquitetura de microsserviços em .NET 8 e otimização de consultas no SQL Server."
                },
                new Experience
                {
                    Id = 2,
                    Role = "Desenvolvedor Pleno",
                    Company = "Digital Web Agency",
                    Period = "Mar 2020 - Dez 2022",
                    Description = "Desenvolvimento de aplicações web completas usando ASP.NET Core MVC, integração com APIs externas e metodologias ágeis."
                }
            }
        };

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
