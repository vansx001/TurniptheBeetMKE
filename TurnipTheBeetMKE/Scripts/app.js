$(document).ready(function () {
    "use strict";
    /************** Nav Scripts **************/
    $(window).scroll(function () {
        if ($(window).scrollTop() > 1) {
            $('nav').addClass('sticky-nav');
        } else {
            $('nav').removeClass('sticky-nav');
        }
    });

    $('a').click(function () {
        if ($(this).attr('href') === '#') {
            return false;
        }
    });
});
$(window).load(function () {
    "use strict";
    var navHeight = $('nav').outerHeight();
    $('.inner-link').smoothScroll({
        offset: -navHeight,
        speed: 800
    });
});