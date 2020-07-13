(function ($) {
    $('#btsubmitlogin').on('click', function (e) {
        var email = $('#email').val();
        var pass = $('#pwd').val();

        if (email.length == 0) {
            e.preventDefault();
            document.getElementById('checkemptyemail').innerHTML = 'Vui lòng nhập tài khoảng';
        }
            
        if (pass.length == 0) {
            e.preventDefault();
            document.getElementById('checkemptypwd').innerHTML = 'Vui lòng nhập tài khoảng';
        }
            
    });

    $('#btsubmitsearch').on('click', function (e) {
        var search = $('#inputsearch').val();

        if (search.length == 0) {
            e.preventDefault();
        }

    });
    //$('#email').on('keyup', function (e) {
    //    var email = $('#email').val();
    //    document.getElementById('checkemptyemail').innerHTML = email;
    //});
})(jQuery);
