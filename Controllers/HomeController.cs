using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevPortfolio.Models;

namespace DevPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index([FromQuery] string lang = null)
    {
        if (!string.IsNullOrEmpty(lang))
        {
            Response.Cookies.Append("lang", lang);
        }
        else if (Request.Cookies.ContainsKey("lang"))
        {
            lang = Request.Cookies["lang"];
        }

        bool isEn = lang == "en";
        ViewBag.Lang = isEn ? "en" : "pt";

        var ui = new Dictionary<string, string>();
        if (isEn)
        {
            ui["NavAbout"] = "About Me";
            ui["NavExperience"] = "Experience";
            ui["NavProjects"] = "Projects";
            ui["NavSkills"] = "Skills";
            ui["NavContact"] = "Contact";
            ui["HeroGreeting"] = "Nice to meet you, I'm";
            ui["BtnProjects"] = "View Projects";
            ui["BtnDownloadCV"] = "Download CV";
            ui["TitleAbout"] = "About Me";
            ui["TitleExperience"] = "Professional Experience";
            ui["TitleProjects"] = "My Projects";
            ui["TitleSkills"] = "Tech Skills";
            ui["TitleContact"] = "Get In Touch";
            ui["ContactText"] = "I'm always open to new opportunities and ready to collaborate on innovative projects. Send a message and let's talk!";
            ui["BtnEmail"] = "Send Email";
            ui["FooterText"] = "Developed with ASP.NET Core & ❤️";
        }
        else
        {
            ui["NavAbout"] = "Sobre Mim";
            ui["NavExperience"] = "Experiência";
            ui["NavProjects"] = "Projetos";
            ui["NavSkills"] = "Habilidades";
            ui["NavContact"] = "Contato";
            ui["HeroGreeting"] = "Prazer, me chamo";
            ui["BtnProjects"] = "Ver Projetos";
            ui["BtnDownloadCV"] = "Baixar CV";
            ui["TitleAbout"] = "Sobre Mim";
            ui["TitleExperience"] = "Experiência Profissional";
            ui["TitleProjects"] = "Meus Projetos";
            ui["TitleSkills"] = "Habilidades Técnicas";
            ui["TitleContact"] = "Entre em Contato";
            ui["ContactText"] = "Estou sempre aberto a novas oportunidades e pronto para colaborar em projetos inovadores. Mande uma mensagem e vamos conversar!";
            ui["BtnEmail"] = "Enviar Email";
            ui["FooterText"] = "Desenvolvido com ASP.NET Core & ❤️";
        }
        ViewBag.UI = ui;

        var model = new PortfolioViewModel
        {
            Name = "Geraldo Neto",
            Title = isEn ? "Fullstack .Net Developer" : "Desenvolvedor .Net Fullstack",
            AboutMe = isEn 
                ? "I am a developer passionate about creating efficient solutions and premium interfaces, focusing on the best user experience and code quality."
                : "Sou um desenvolvedor apaixonado por criar soluções eficientes e interfaces premium, focando na melhor experiência de usuário e qualidade do código.",
            AboutMeExtended = isEn
                ? "I am a Back-End developer with focus on C# (Entity) and Java (Spring Boot), acting in the creation of APIs and more, my focus is always on code quality following best development practices. I have ease in solving problems, understanding business rules, gathering technical requirements and collaborating in agile teams (Scrum/Kanban). I am proactive, adaptable and value continuous learning, always seeking to improve my technical skills."
                : "Sou desenvolvedor Back-End com foco em C# (Entity) e Java (Spring Boot), atuando na criação de APIs e muito mais, meu foco é sempre na qualidade do código seguindo as boas práticas de desenvolvimento. Tenho facilidade em resolver problemas, compreender regras de negócio, levantar requisitos técnicos e colaborar em equipes ágeis (Scrum/Kanban). Sou proativo, adaptável e valorizo a aprendizagem contínua, sempre buscando melhorar minhas habilidades técnicas e interpessoais.",
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
                        new TechSkill { Name = "PostgreSQL", DeviconClass = "devicon-postgresql-plain colored" },
                        new TechSkill { Name = "MongoDB", DeviconClass = "devicon-mongodb-plain colored" },
                        new TechSkill { Name = "Apex Salesforce", DeviconClass = "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/salesforce/salesforce-original.svg" }
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
                        new TechSkill { Name = "Next.js", DeviconClass = "devicon-nextjs-plain colored" },
                        new TechSkill { Name = "Vue.js", DeviconClass = "devicon-vuejs-plain colored" },
                        new TechSkill { Name = "Angular", DeviconClass = "devicon-angularjs-plain colored" }
                    }
                }
            },
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = isEn ? "Management System" : "Sistema de Gestão",
                    Description = isEn ? "A complete management system built with ASP.NET Core, focusing on performance and clean architecture." : "Um sistema completo de gestão construído com ASP.NET Core, focando em performance e arquitetura limpa.",
                    ImageUrl = "/images/project1.png",
                    Technologies = new List<string> { "ASP.NET Core", "Entity Framework", "SQL Server" },
                    GithubUrl = "https://github.com/seugithub",
                    LiveUrl = "#"
                },
                new Project
                {
                    Id = 2,
                    Title = isEn ? "E-commerce API" : "API de E-commerce",
                    Description = isEn ? "Performant RESTful API integrating payment gateways and JWT authentication." : "API RESTful performática integrando gateways de pagamento e autenticação JWT.",
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
                    Role = isEn ? "Senior Developer" : "Desenvolvedor Sênior",
                    Company = "Tech Solutions",
                    Period = isEn ? "Jan 2023 - Present" : "Jan 2023 - Presente",
                    Description = isEn ? "Technical team leadership, microservices architecture in .NET 8 and query optimization in SQL Server." : "Liderança de equipe técnica, arquitetura de microsserviços em .NET 8 e otimização de consultas no SQL Server."
                },
                new Experience
                {
                    Id = 2,
                    Role = isEn ? "Mid-level Developer" : "Desenvolvedor Pleno",
                    Company = "Digital Web Agency",
                    Period = isEn ? "Mar 2020 - Dec 2022" : "Mar 2020 - Dez 2022",
                    Description = isEn ? "Development of complete web applications using ASP.NET Core MVC, external API integration and agile methodologies." : "Desenvolvimento de aplicações web completas usando ASP.NET Core MVC, integração com APIs externas e metodologias ágeis."
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
