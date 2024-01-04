document.addEventListener("DOMContentLoaded", function () {
    const track = document.getElementById("carouselTrack");
    let slides = [];
    let index = 0;

    function updateCarousel() {
        const size = slides[index].clientWidth;
        track.style.transform = `translateX(${-size * index}px)`;
    }

    function nextSlide() {
        index = (index + 1) % slides.length;
        updateCarousel();
    }

    setInterval(nextSlide, 3000);
});