$(document).ready(function(){

    //Main Categories' Slider
    var swiper = new Swiper('.swiper-container-1', {
        pagination: '.swiper-pagination',
        paginationClickable: true,
        nextButton: '.swiper-button-next',
        prevButton: '.swiper-button-prev'
    });

    $('.to-top').on('click', function(e) {
        e.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, 'slow');
    })

    function openMenu() {
        $('.side-nav').css({ 'padding': '25px' });
        $('.side-nav').fadeIn(200);
        $('.menu-shade').fadeIn(200);
        $('.side-nav').animate({ 
            display: 'block', 
            left: '0', 
            width: '40%' 
        }, 200);
    }

    function closeMenu() {
        $('.side-nav').animate({ 
            display: 'block', 
            left: '-100', 
            width: '0' 
        }, 300);
        $('.side-nav').fadeOut('slow');        
        setTimeout(function(){
            $('.side-nav').css({ 'padding': '0' });
            $('.menu-shade').fadeOut(200);
        }, 300);
    }

    $('#openMenu').on('click', function() {
        openMenu();
    });

    $('#closeMenu').on('click', function() {
        closeMenu();
    });

    $('.menu-shade').on('click', function() {
        closeMenu();
    });

    $(window).resize(function(){
        
    });

    $(window).on('scroll', function(){
        if ($(window).width() <= 992){	
            if($(window).scrollTop() > $('main').offset().top) {
                $('.scrollable-bar').addClass('scrollable-bar-fix');
            }
            else if($(window).scrollTop() < 50){
                $('.scrollable-bar').removeClass('scrollable-bar-fix');
            }   
        }	
    });


   
});