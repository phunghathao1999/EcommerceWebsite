$(function () {
    $('#btsubmitadvancedsearch').on('click', function (e) {
        var checkbox = document.getElementsByName('manufacturer');
        var result = "";

        for (var i = 0; i < checkbox.length; i++) {
            if (checkbox[i].checked === true) {
                result += checkbox[i].value;
            }
        }
        alert(result);

        $.ajax({
            type: 'GET',
            url: '/Customer/Laptop?handler=AdvancedSearch',
            contentType: 'application/json;charset=utf-8',
            headers: {
                "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            dataType:'json',
            data: {
                Manufacturer: result
            },
            success: function (respone) {
                alert(respone);
                $('#reloadpagination').load();
            },
            failure: function (result) {
                alert("fail");
            }
        });
    });
    $('.paginationlaptop').on('click', function (e) {
        var current = $('.paginationlaptop').attr('value');
        alert(current);
        $.ajax({
            type: 'GET',
            url: '/Customer/Laptop',
            contentType: 'application/json;charset=utf-8',
            dataType: 'int',
            data: {
                current: current
            },
            success: function (respone) {
                alert("THanh cong");
                location.reload();
            },
            failure: function (result) {
                alert("fail");
            }
        });
    });
});
    
