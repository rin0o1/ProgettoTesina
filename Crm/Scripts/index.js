﻿



$(window).load(function () {
    // Animate loader off screen
    
    RemoveSpinn();
    
});

$(document).on('click', '.crm-menu-button', function () {
    ShowSpin();
});



function ShowSpin() {
    $('.big').toggleClass("hide", false);
    $('.SpineBackground').toggleClass("hide", false);
}

function RemoveSpinn() {
    $('.big').toggleClass("hide", true);
    $('.SpineBackground').toggleClass("hide", true);
}


$(document).ajaxSend(function () {
    ShowSpin();
});

$(document).ajaxComplete(function () {
   RemoveSpinn();
});

$(document).ajaxStop(function () {
    RemoveSpinn();
});
$(document).ajaxError(function () {
    RemoveSpinn();
});


$(document).ajaxError(function () {
    RemoveSpinn();
});
function IsNotStringAcceptable(string) {

    if (string === "") {
        return true;
    }
    else {
        return false;
    }

}

function GetControllerName()
{
    var controlllerName = $('#_ControllerName').val();
    return controlllerName;
}


function GetIdFromAPartial() {

    var id = $('#IdOfThisElement').val();
    return id;
}
function scrollFunction() {
    if (document.body.scrollTop > 300 || document.documentElement.scrollTop > 300) {
        $('#btn_scrolltop').fadeIn(200);
    } else {
        $('#btn_scrolltop').fadeOut(200);
    }

}
(function ($) {
    $.fn.serializeFormJSON = function () {

        var o = {};
        var a = this.serializeArray();
        $.each(a, function () {
            if (o[this.name]) {
                if (!o[this.name].push) {
                    o[this.name] = [o[this.name]];
                }
                o[this.name].push(this.value || '');
            } else {
                o[this.name] = this.value || '';
            }
        });
        return o;
    };
})(jQuery);



function topFunction()
{
    $('html, body').animate({ scrollTop: 0 }, 'slow');
}


