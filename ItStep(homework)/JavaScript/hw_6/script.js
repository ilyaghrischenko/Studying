function logImageUrls() {
    const images = document.querySelectorAll('.image');
    const urls = Array.from(images).map(img => img.src);
    console.log('URLs of images:', urls);
}

function logImageAlts() {
    const images = document.querySelectorAll('.image');
    const alts = Array.from(images).map(img => img.alt);
    console.log('Alt attributes:', alts);
}

function logBlockClassNames() {
    const blocks = document.querySelectorAll('.image-block');
    const classNames = Array.from(blocks).map(block => block.className);
    console.log('Class names of blocks:', classNames);
}

function addAltToTitle() {
    const blocks = document.querySelectorAll('.image-block');
    blocks.forEach(block => {
        const img = block.querySelector('img');
        block.title = img.alt;
    });
}

function addBackgroundColorToBlocks() {
    const blocks = document.querySelectorAll('.image-block');
    blocks.forEach((block, index) => {
        if (index < 4) {
            block.style.backgroundColor = '#e0f7fa';
        }
    });
}

logImageUrls();
logImageAlts();
logBlockClassNames();
addAltToTitle();
addBackgroundColorToBlocks();
