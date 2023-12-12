document.addEventListener("DOMContentLoaded", function () {
    const track = document.getElementById("carouselTrack");
    let slides = [];
    let index = 0;
  
    function addSlide(imageSrc) {
      const slide = document.createElement("div");
      slide.classList.add("carousel-slide");
      const img = document.createElement("img");
      img.src = imageSrc;
      img.alt = "Slide";
      slide.appendChild(img);
      track.appendChild(slide);
      slides.push(slide);
    }
  
    addSlide("assets/prod1.jpg");
    addSlide("assets/prod2.jpg");
    addSlide("assets/prod3.png");  
    addSlide("assets/prod1.jpg");
    addSlide("assets/prod2.jpg");
    addSlide("assets/prod3.png");
    addSlide("assets/prod1.jpg");
    addSlide("assets/prod2.jpg");
    addSlide("assets/prod3.png");  
    addSlide("assets/prod1.jpg");
    addSlide("assets/prod2.jpg");
    addSlide("assets/prod3.png");
    
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
  