window.onload = function(){

	var notescode = $(".header-top .logo a");
	try{
		notescode.shuffleLetters();
	}catch(e){
		console.log(e);
	}
	

	var slides = $(".desktop_left  img");
	for(var i=1; i < slides.length; i++){
		$(slides[i]).hide();
	}
	var slideindex = 1;
	setInterval(showPhotos, 3000, slides);
	function showPhotos(slides){
		$(slides[slideindex-1]).hide();
		slideindex++;
		if(slideindex > slides.length){
			slideindex = 1;
		}
		$(slides[slideindex-1]).fadeIn();
	}
		
	// Кнопка меню
	var menu = $('nav');
	var manu_btn = $('.menu-btn');
	manu_btn.on('click',function(e){
		e.preventDefault;
		$(this).toggleClass('menu-btn_active');
		$('.menu').toggleClass('tooltip');
		menu.slideToggle();
	});

	$(window).resize(function(){
		var wid = $(window).width();
		//спрацьовує тільки тоді коли кнопка меню нажималася
		if(wid > 830 && menu.is('[style]'))
		{
			menu.removeAttr('style');
			manu_btn.removeClass('menu-btn_active');
		}
	});


	var $btnTop = $('.btn-top');
	// Появлення кнопки up
	$(window).on("scroll",function(){
		if ( $(window).scrollTop() >= 20 ) {
			$btnTop.fadeIn();
		}else{
			$btnTop.fadeOut();
		}
	});

	// прокрутка в верх
	$btnTop.on("click", function(){
		$('html,body').animate({scrollTop:0},500);
	});

    //login
    //try {
        //var hidden_login = document.getElementsByClassName("hidden_login")[0];
        //var div_in_hidden = hidden_login.getElementsByTagName('div')[0];
        //var body = document.getElementsByTagName('body')[0];
        //var close = document.getElementById('close');
    //    for (var i = 0; i < 2; i++) {
    //        document.getElementsByClassName('popup')[i].onclick = function (event) {
    //            hidden_login.classList.add('show_login');
    //            body.classList.add('overflow_hidden');
    //            close.style.left = event.clientX + 10 + 'px';
    //            close.style.top = event.clientY + 10 + 'px';
    //        }
    //    }
    //    hidden_login.onclick = function (event) {
    //        if (event.target == this) {
    //            hidden_login.classList.remove('show_login');
    //            body.classList.remove('overflow_hidden');
    //        }
    //    }
    //    div_in_hidden.onmouseenter = function () {
    //        close.style.display = 'none';
    //    }
    //    div_in_hidden.onmouseleave = function () {
    //        close.style.display = 'block';
    //    }
    //    hidden_login.onmouseleave = function () {
    //        close.style.display = 'none';
    //    }
    //    hidden_login.onmouseenter = function () {
    //        close.style.display = 'block';
    //    }
    //    hidden_login.onmousemove = function (event) {
    //        if (event.target !== this) return false;
    //        close.style.left = event.clientX + 10 + 'px';
    //        close.style.top = event.clientY + 10 + 'px';
    //    }
        //$('.hidden_login form').submit(function (event) {
        //    event.preventDefault();
        //    $.ajax({
        //        type: 'POST',
        //        url: "Account/Login",
        //        data: new FormData(this),
        //        contentType: false,
        //        cache: false,
        //        processData: false,
        //        success: function (data) {
        //            if (data == "Ви успішно авторизувалися") {
        //                $(".header-top").load('@Url.Action("HeaderTopPartial","Home")');
        //                //location.reload();
        //            }
        //            alert(data);
        //        },
        //    });
        //});
    //} catch (e) {
    //    console.log(e);
    //}

	//sidebar
	//var btn_sidebar = $('.sidebar_of_manual h2');
	//var ul_sidebar = $('.sidebar_of_manual ul');
	//for(var t = 0; t < btn_sidebar.length;t++){
	//	let buffer  = t;
	//	$(btn_sidebar[buffer]).on('click',function(){
	//			$(ul_sidebar[buffer]).slideToggle();
	//		});		
	//}
	
}//end

