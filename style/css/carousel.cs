.image-jumbotron{
  background-image: url("../../image/housenlot/Alcove3.JPG") no-repeat center center;
  -webkit-background-size: 100% 100%;
    -moz-background-size: 100% 100%;
    -o-background-size: 100% 100%;
    background-size: 100% 100%;
  background-size: cover;

}
 /* Make the image fully responsive */
 .carousel {
  margin-bottom: 60px;
}

.carousel-control {
  top: 76%;
}

.carousel-caption {
  z-index: 10;
}
 .carousel img {
     top: 0;
     left: 0;
     width: 100%;
     height: 400px;
 }

 .carousel .item {
   height: 500px;
   background-color:#bbb;
   overflow:hidden;
 }

#searchForm {
	position:absolute;
  	top:40%;


}


/* RESPONSIVE CSS
-------------------------------------------------- */
@media (max-width: 768px) {

  .carousel-inner>.item>img, .carousel-inner>.item>a>img {
  	max-width:inherit;
  }

  .carousel-caption p {
    margin-bottom: 20px;
    font-size: 21px;
    line-height: 1.4;
  }
}




//item DETAILS
h4 {
    margin: 20px 10px 10px;
}
p {
    margin: 10px;
}

#carousel-example-generic {
    margin: 20px auto;
  //  width: 400px;
}

#carousel-custom {
    margin: 20px auto;
  //  width: 400px;
}
#carousel-custom .carousel-indicators {
    margin: 10px 0 0;
    overflow: auto;
    position: static;
    text-align: left;
    white-space: nowrap;
    width: 100%;
}
#carousel-custom .carousel-indicators li {
    background-color: transparent;
    -webkit-border-radius: 0;
    border-radius: 0;
    display: inline-block;
    height: auto;
    margin: 0 !important;
    width: auto;
}
#carousel-custom .carousel-indicators li img {
    display: block;
    opacity: 0.5;
    width: 80%;
      height: 120px;
}
#carousel-custom .carousel-indicators li.active img {
    opacity: 1;
}
#carousel-custom .carousel-indicators li:hover img {
    opacity: 0.75;
}
