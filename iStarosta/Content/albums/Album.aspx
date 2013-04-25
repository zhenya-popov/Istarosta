<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="iStarosta.Content.albums.Album" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
		
		<link rel="stylesheet" href="css/supersized.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="theme/supersized.shutter.css" type="text/css" media="screen" />
		
		<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.6.1/jquery.min.js"></script>
		<script type="text/javascript" src="js/jquery.easing.min.js"></script>
		
		<script type="text/javascript" src="js/supersized.3.2.7.min.js"></script>
		<script type="text/javascript" src="theme/supersized.shutter.min.js"></script>
		
		<script type="text/javascript">

		    jQuery(function ($) {

		        $.supersized({

		            // Functionality
		            slideshow: 1, 		// Slideshow on/off
		            autoplay: 0, 		// Slideshow starts playing automatically
		            start_slide: 1, 		// Start slide (0 is random)
		            stop_loop: 0, 		// Pauses slideshow on last slide
		            random: 0, 		// Randomize slide order (Ignores start slide)
		            slide_interval: 3000, 	// Length between transitions
		            transition: 6, 			// 0-None, 1-Fade, 2-Slide Top, 3-Slide Right, 4-Slide Bottom, 5-Slide Left, 6-Carousel Right, 7-Carousel Left
		            transition_speed: 1000, 	// Speed of transition
		            new_window: 1, 		// Image links open in new window/tab
		            pause_hover: 0, 		// Pause slideshow on hover
		            keyboard_nav: 1, 		// Keyboard navigation on/off
		            performance: 1, 		// 0-Normal, 1-Hybrid speed/quality, 2-Optimizes image quality, 3-Optimizes transition speed // (Only works for Firefox/IE, not Webkit)
		            image_protect: 1, 		// Disables image dragging and right click with Javascript

		            // Size & Position						   
		            min_width: 0, 		// Min width allowed (in pixels)
		            min_height: 0, 		// Min height allowed (in pixels)
		            vertical_center: 1, 		// Vertically center background
		            horizontal_center: 1, 		// Horizontally center background
		            fit_always: 0, 		// Image will never exceed browser width or height (Ignores min. dimensions)
		            fit_portrait: 1, 		// Portrait images will not exceed browser height
		            fit_landscape: 0, 		// Landscape images will not exceed browser width

		            // Components							
		            slide_links: 'blank', // Individual links for each slide (Options: false, 'num', 'name', 'blank')
		            thumb_links: 1, 		// Individual thumb links for each slide
		            thumbnail_navigation: 0, 		// Thumbnail navigation
		            slides: [			// Slideshow Images
														{image: 'https://pp.userapi.com/c416621/v416621964/2da/C8CAHssibo8.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/2da/C8CAHssibo8.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/2e3/hBvQn5M2kIw.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/2e3/hBvQn5M2kIw.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/2ec/kZ0VAGVuKi0.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/2ec/kZ0VAGVuKi0.jpg' },
                                                        { image: 'https://pp.userapi.com/c416621/v416621964/2f5/PclYhzszL58.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/2f5/PclYhzszL58.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/2fe/uJxcU2pIxnE.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/2fe/uJxcU2pIxnE.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/307/Rm6iE_goITo.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/307/Rm6iE_goITo.jpg' },
                                                        { image: 'https://pp.userapi.com/c416621/v416621964/310/Grz80ZpyXnI.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/310/Grz80ZpyXnI.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/319/_wyA0jD3h_8.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/319/_wyA0jD3h_8.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/322/JYCcJUYXYHg.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/322/JYCcJUYXYHg.jpg' },
                                                        { image: 'https://pp.userapi.com/c416621/v416621964/32c/Bo8e6ljEqV4.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/32c/Bo8e6ljEqV4.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/335/T2FOZLEK0CM.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/335/T2FOZLEK0CM.jpg' },
														{ image: 'https://pp.userapi.com/c416621/v416621964/33e/VrH6WRVDJDA.jpg', thumb: 'https://pp.userapi.com/c416621/v416621964/33e/VrH6WRVDJDA.jpg' }
												],

		            // Theme Options			   
		            progress_bar: 1, 		// Timer for each slide							
		            mouse_scrub: 0

		        });
		    });
		    
		</script>

</head>

<style type="text/css">
		ul#demo-block{ margin:0 15px 15px 15px; }
			ul#demo-block li{ margin:0 0 10px 0; padding:10px; display:inline; float:left; clear:both; color:#aaa; background:url('img/bg-black.png'); font:11px Helvetica, Arial, sans-serif; }
			ul#demo-block li a{ color:#eee; font-weight:bold; }
	</style>
<body>
    <form id="form1" runat="server">
    <!--Demo styles (you can delete this block)-->
	
	<ul id="demo-block">
		<li><a href="../Photo.aspx">Вернуться к другим альбомам</a></li>
	</ul>
	
	<!--End of styles-->

	<!--Thumbnail Navigation-->
	<div id="prevthumb"></div>
	<div id="nextthumb"></div>
	
	<!--Arrow Navigation-->
	<a id="prevslide" class="load-item"></a>
	<a id="nextslide" class="load-item"></a>
	
	<div id="thumb-tray" class="load-item">
		<div id="thumb-back"></div>
		<div id="thumb-forward"></div>
	</div>
	
	<!--Time Bar-->
	<div id="progress-back" class="load-item">
		<div id="progress-bar"></div>
	</div>
	
	<!--Control Bar-->
	<div id="controls-wrapper" class="load-item">
		<div id="controls">
			
			<a id="play-button"><img id="pauseplay" src="img/pause.png"/></a>
		
			<!--Slide counter-->
			<div id="slidecounter">
				<span class="slidenumber"></span> / <span class="totalslides"></span>
			</div>
			
			<!--Slide captions displayed here-->
			<div id="slidecaption"></div>
			
			<!--Thumb Tray button-->
			<a id="tray-button"><img id="tray-arrow" src="img/button-tray-up.png"/></a>
			
			<!--Navigation-->
			<ul id="slide-list"></ul>
			
		</div>
	</div>
    </form>
</body>
</html>
