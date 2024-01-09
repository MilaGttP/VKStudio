function toggleBurgerMenu() {
    const burgerIcon = document.getElementById('burgerIcon');
    const burgerMenu = document.getElementById('burgerMenu');
    const darkBackground = document.getElementById('darkBackground');

    burgerIcon.classList.toggle('open');
    burgerMenu.style.display = burgerMenu.style.display === 'block' ? 'none' : 'block';
    darkBackground.classList.toggle('open');
}

document.addEventListener('click', function (event) {
    const burgerMenu = document.getElementById('burgerMenu');
    const darkBackground = document.getElementById('darkBackground');

    if (!burgerMenu.contains(event.target) && event.target.id !== 'burgerIcon') {
        burgerMenu.style.display = 'none';
        document.getElementById('burgerIcon').classList.remove('open');
        darkBackground.classList.remove('open');
    }
});
