const newsList = document.getElementById('news-list');
const loading = document.getElementById('loading');
const loadMoreButton = document.getElementById('load-more');

let newsArray = [
    'Новость 1: Это первая новость.',
    'Новость 2: Это вторая новость.',
    'Новость 3: Это третья новость.',
    'Новость 4: Это четвёртая новость.',
    'Новость 5: Это пятая новость.',
    'Новость 6: Это шестая новость.',
    'Новость 7: Это седьмая новость.',
    'Новость 8: Это восьмая новость.',
    'Новость 9: Это девятая новость.',
    'Новость 10: Это десятая новость.'
];

let loadedNewsCount = 0;
const newsPerLoad = 2;

function loadNews() {
    if (loadedNewsCount >= newsArray.length) return;

    loading.style.display = 'block';

    setTimeout(() => {
        for (let i = 0; i < newsPerLoad && loadedNewsCount < newsArray.length; i++) {
            const newsItem = document.createElement('div');
            newsItem.classList.add('news-item');
            newsItem.textContent = newsArray[loadedNewsCount];
            newsList.appendChild(newsItem);
            loadedNewsCount++;
        }
        loading.style.display = 'none';

        // Disable button if all news are loaded
        if (loadedNewsCount >= newsArray.length) {
            loadMoreButton.disabled = true;
            loadMoreButton.textContent = 'Больше новостей нет';
        }
    }, 1000);
}

loadMoreButton.addEventListener('click', loadNews);

// Initial load
loadNews();
