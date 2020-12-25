var food = {} || food;



food.showAboutDescription = function () {
    $.ajax({
        url: 'https://localhost:44348/api/About/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#about').append(` <h6>${v.description}</h6>`);
            })

        }
    });
}

food.showAboutName = function () {
    $.ajax({
        url: 'https://localhost:44348/api/About/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#nameAbout').append(` <span>${v.name}</span>`);
            })

        }
    });
}












food.init = function () {

    food.showAboutDescription();
    food.showAboutName();
  


}

$(document).ready(function () {
    food.init();
});
