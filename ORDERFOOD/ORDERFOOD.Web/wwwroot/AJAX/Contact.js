var contact = {} || contact;





/* CONTACT*/
contact.showContactName = function () {
    $.ajax({
        url: 'https://localhost:44348/api/Contact/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#nameContact').append(` <p>${v.name}</p>`);
            })

        }
    });
}

contact.showEvaluate = function () {
    $.ajax({
        url: 'https://localhost:44348/api/Contact/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#descriptionevaluate').append(` <h6>${v.evaluate}</h6>`);
            })

        }
    });
}









contact.init = function () {

   
    contact.showContactName();
    contact.showEvaluate();


}

$(document).ready(function () {
    contact.init();
});
