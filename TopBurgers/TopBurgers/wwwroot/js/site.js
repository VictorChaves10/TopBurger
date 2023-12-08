document.addEventListener('DOMContentLoaded', function () {
    var flipCards = document.querySelectorAll('.flip-card-lanche');

    flipCards.forEach(function (card) {
        card.addEventListener('click', function () {
            var innerCard = this.querySelector('.flip-card-lanche-inner');

            if (innerCard.style.transform === 'rotateY(180deg)') {
            
                innerCard.style.transform = 'rotateY(0deg)';
            } else {
                
                innerCard.style.transform = 'rotateY(180deg)';
            }
        });
    });
});