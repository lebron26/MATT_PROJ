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
   color: #FFFFFF !important;
      font-size: 1.1em !important;
     font-family: 'Lora', Georgia, Times, serif;
}

.nav-item .nav-link:hover{
  text-shadow: 3px 3px 10px #FFFFFF;
}


.breadcrumb{
 background-color:#144955;
 opacity: 0.8;
}

.breadcrumb > .breadcrumb-item a{
color:#E5E5E5;
}

.breadcrumb-item.active {
    color: #FFFFFF;
    text-shadow: 1px 1px 2px #FFFFFF;

}

.dropdown-menu {
  background-color: #1A6070;
}

.dropdown-menu .dropdown-item:hover{
  background-color: #E5E5E5 ;
}


.table-success, .table-success>td, .table-success>th {
    background-color: #144955;
}
.table-success>th
{
  color:#FFFFFF;
}


.table {
  background-color:white;
    box-shadow: 0 8px 8px -6px black;


}

.img-thumbnail{
  background-color: transparent;
  border-color: transparent;
}

.jumbotron{
  background-color: #FFFFFF;
  z-index: 5;
  box-shadow: 0 8px 16px -6px black;
}

body {
 
  background-color:#F3EAAF;/* Used if the image is unavailable */

   
}

.btn-outline-warning  {
 color: #E5E5E5 ;
 border-color: #144955;

}

.btn-outline-warning:hover {
     color: #FFFFFF;
     background-color: transparent; 
     border-color: transparent; 
}

.footer{
  background-color: #144955 ;
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
    color: #FFFFFF;    }

.card-hover:hover .reveal {
    height: auto;
    visibility: visible;
    opacity: 50;
    transition: opacity 1.5s ease;

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




