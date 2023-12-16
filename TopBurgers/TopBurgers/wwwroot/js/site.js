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


(() => {
    'use strict'
    const forms = document.querySelectorAll('.needs-validation')

    // Loop over them and prevent submission
    Array.from(forms).forEach(form => {
        form.addEventListener('submit', event => {
            if (!form.checkValidity()) {
                event.preventDefault()
                event.stopPropagation()
            }

            form.classList.add('was-validated')
        }, false)
    })
})();