$(function(){

    $('#login_form_link').click(function(e) {
        $("#login-form").delay(100).fadeIn(100);
        $("#register-form").fadeOut(100);
        $('#register_form_link').removeClass('active');
        $(this).addClass('active');
        e.preventDefault();
        return true;
    });
    $('#register_form_link').click(function(e) {
        $("#register-form").delay(100).fadeIn(100);
        $("#login-form").fadeOut(100);
        $('#login_form_link').removeClass('active');
        $(this).addClass('active');
        e.preventDefault();
        return true;
    }); 
});
