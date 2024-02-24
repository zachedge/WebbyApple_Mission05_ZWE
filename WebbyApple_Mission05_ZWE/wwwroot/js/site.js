$('.nav-link').click(function (event) {
    event.preventDefault(); 

    var controller = $(this).attr('asp-controller');
    var action = $(this).attr('asp-action'); 
    var targetPage = '/' + controller + '/' + action;

    window.location.href = targetPage; 
});
