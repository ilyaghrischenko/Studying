const images = [
    'images/pic01.png',
    'images/pic02.png',
    'images/pic03.png',
    'images/pic04.png',
    'images/pic05.png',
    'images/pic06.png',
    'images/pic07.png',
    'images/pic08.png'
];

let currentIndex = 0;

const galleryImage = document.getElementById('galleryImage');
const prevButton = document.getElementById('prevButton');
const nextButton = document.getElementById('nextButton');

function updateGallery() {
    galleryImage.src = images[currentIndex];
    
    prevButton.disabled = currentIndex === 0;
    nextButton.disabled = currentIndex === images.length - 1;
}

prevButton.addEventListener('click', function() {
    if (currentIndex > 0) {
        currentIndex--;
        updateGallery();
    }
});

nextButton.addEventListener('click', function() {
    if (currentIndex < images.length - 1) {
        currentIndex++;
        updateGallery();
    }
});

updateGallery();
