document.getElementById('showImage').addEventListener('click', function(event) {
    event.preventDefault();
    document.body.classList.add('no-scroll');
    document.getElementById('hiddenImageContainer').style.left = '0';
});

document.getElementById('closeButton').addEventListener('click', function() {
    document.body.classList.remove('no-scroll');
    document.getElementById('hiddenImageContainer').style.left = '-100%';
});
