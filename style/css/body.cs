h1, h2, h3, h4, h5, h6 {
    font-family: 'Lora', Georgia, Times, serif;

}


p, div {
    font-family: 'Lora', Helvetica, Arial, sans-serif;
    font-size: 1em !important;

}

.fullnav{
  background-color: #144955 ;
  max-height:70%

}


.navbar-brand{
  position: absolute;
  z-index:1;
    top:0;
border: 1px solid black;
}

.navbar-collapse > ul{
  padding-left: 260px;

}

.navbar-collapse > h1{
  padding-top: 20px;
}

.fullnav > a{
  background-color: white;
}

.nav-item .nav-link {
  color:white;
      font-size: 1.1em !important;
     font-family: 'Lora', Georgia, Times, serif;
}

.nav-item .nav-link:hover{
  color: #FFFFFF !important;
  text-shadow: 6px 6px 12px #000000;
}

 .nav-link.dropdown-toggle a{
  color: #FFFFFF !important;
  text-shadow: 6px 6px 12px #000000;
}





.jumbotron{
  background-color: #FFFFFF;
  z-index: 5;
  box-shadow: 0 8px 16px -6px black;
}

body {
 
  background-color:#F3EAAF;/* Used if the image is unavailable */

   
}





/* Tims Body ;) */

h1 { font-size: 2em; }
h2 { font-size: 1.5em; }
h3 { font-size: 1.17em; }
h4 { font-size: 1.12em; }
h5 { font-size: .83em; }
h6 { font-size: .75em; }

.card-hover .reveal {
    visibility: hidden;
    opacity: 0;
    height: 0;
    padding: 0;

    display: inline block;
    color: #FFFFFF;    }

.card-hover:hover .reveal {
    height: auto;
    visibility: visible;
    opacity: 50;
    transition: opacity 2s ease;

    background-color: rgba(20, 73, 85, 0.7) ;

}

.card{
  text-align: center;
  box-shadow: 0 4px 10px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);

}




.carousel-fade .carousel-item {
 opacity: 0;
 transition-duration: .6s;
 transition-property: opacity;
}

.carousel-fade  .carousel-item.active,
.carousel-fade  .carousel-item-next.carousel-item-left,
.carousel-fade  .carousel-item-prev.carousel-item-right {
  opacity: 1;
}

.carousel-fade .active.carousel-item-left,
.carousel-fade  .active.carousel-item-right {
 opacity: 0;
}

.carousel-fade  .carousel-item-next,
.carousel-fade .carousel-item-prev,
.carousel-fade .carousel-item.active,
.carousel-fade .active.carousel-item-left,
.carousel-fade  .active.carousel-item-prev {
 transform: translateX(0);
 transform: translate3d(0, 0, 0);
}


.headbg{
 background-image: url("../../image/bg.jpg"); /* The image used */
  background-position: center; /* Center the image */
  background-repeat: no-repeat; /* Do not repeat the image */
  background-size: cover; 


  }


.carousel-inner{
    box-shadow: 0 4px 10px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
    text-align: center;
}




.nav-tabs .nav-link.active {
  
    background-color: transparent;
    border-bottom:3px solid #000000;
    border-right: none;
    border-left: none;
    border-top: none;
}

.carousel-inner >.carousel-item img {
    height:600px;

}



a {
  color: #fff;
  text-decoration: none;
}
.me {
  width: 400px;
  margin: 90px auto;
}
.me p,
.me h1 {
  text-transform: uppercase;
  letter-spacing: 3px;
  text-align: center;
}
.me p {
  font-weight: 200;
}
.me span {
  font-weight: bold;
}
.social {
  position: fixed;
  top: 200px;
}
.social ul {
  padding: 0px;
  -webkit-transform: translate(-270px, 0);
  -moz-transform: translate(-270px, 0);
  -ms-transform: translate(-270px, 0);
  -o-transform: translate(-270px, 0);
  transform: translate(-270px, 0);
}
.social ul li {
  display: block;
  margin: 5px;
  background: #144955;
  width: 300px;
  text-align: right;
  padding: 10px;
  -webkit-border-radius: 0 30px 30px 0;
  -moz-border-radius: 0 30px 30px 0;
  border-radius: 0 30px 30px 0;
  -webkit-transition: all 1s;
  -moz-transition: all 1s;
  -ms-transition: all 1s;
  -o-transition: all 1s;
  transition: all 1s;
}
.social ul li:hover {
  -webkit-transform: translate(110px, 0);
  -moz-transform: translate(110px, 0);
  -ms-transform: translate(110px, 0);
  -o-transform: translate(110px, 0);   
  transform: translate(110px, 0);
  background: #4F9CAE;
}
.social ul li:hover a {
  color: #FFFFFF;
}
.social ul li:hover i {
  color: #fff;
  background: #144955;
  -webkit-transition: all 1s;
  -moz-transition: all 1s;
  -ms-transition: all 1s;
  -o-transition: all 1s;
  transition: all 1s;
}
.social ul li i {
  margin-left: 10px;
  color: #07A1C5;
  background: #fff;
  padding: 10px;
  border-radius: 50%;
  width: 20px;
  height: 20px;
  font-size: 20px;
  background: #ffffff;
}


#scroll {
    position:fixed;
    right:10px;
    bottom:10px;
    cursor:pointer;
    width:50px;
    height:50px;
    background-color:#144955;
    text-indent:-9999px;
    display:none;
    -webkit-border-radius:60px;
    -moz-border-radius:60px;
    border-radius:60px
}
#scroll span {
    position:absolute;
    top:50%;
    left:50%;
    margin-left:-8px;
    margin-top:-12px;
    height:0;
    width:0;
    border:8px solid transparent;
    border-bottom-color:#ffffff;
}
#scroll:hover {
    background-color:#e74c3c;
    opacity:1;filter:"alpha(opacity=100)";
    -ms-filter:"alpha(opacity=100)";
}

