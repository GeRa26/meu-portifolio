// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {
    const themeToggle = document.getElementById("theme-toggle");
    if (!themeToggle) return;

    const body = document.body;
    
    // Ler o tema salvo no localStorage
    const currentTheme = localStorage.getItem("theme");
    if (currentTheme === "light") {
        body.classList.add("light-mode");
        themeToggle.innerHTML = "🌙";
    }

    themeToggle.addEventListener("click", function () {
        body.classList.toggle("light-mode");
        let theme = "dark";
        
        // Adicionar animação de pulinho
        themeToggle.style.transform = "scale(1.2)";
        setTimeout(() => themeToggle.style.transform = "scale(1)", 200);

        if (body.classList.contains("light-mode")) {
            theme = "light";
            themeToggle.innerHTML = "🌙"; // Mostra a lua para voltar ao dark
        } else {
            themeToggle.innerHTML = "☀️"; // Mostra o sol para voltar ao light
        }
        localStorage.setItem("theme", theme);
    });

    // --- Lógica do Menu Hambúrguer (Mobile) ---
    const mobileMenu = document.getElementById("mobile-menu");
    const navLinks = document.querySelector(".nav-links");
    
    if (mobileMenu) {
        mobileMenu.addEventListener("click", () => {
            mobileMenu.classList.toggle("active");
            navLinks.classList.toggle("active");
        });
        
        // fecha o menu ao clicar num link
        document.querySelectorAll('.nav-links a').forEach(n => n.addEventListener('click', () => {
            mobileMenu.classList.remove("active");
            navLinks.classList.remove("active");
        }));
    }
});
