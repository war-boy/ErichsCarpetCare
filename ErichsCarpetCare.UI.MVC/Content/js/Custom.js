
let carBG = document.getElementById('carBG');


carBG.src = "../../Content/images/IMG_2907.jpeg";
var imgList = ["../../Content/images/IMG_2907.jpeg", "../../Content/images/IMG_0180.jpg", "../../Content/images/IMG_1973.JPG", "../../Content/images/IMG_1980.JPG", "../../Content/images/iicrc logo.jpg", "../../Content/images/IMG_0178.jpg"];
let right = document.getElementById("Right_Arrow");
let left = document.getElementById("Left_Arrow");

var x = 0;
console.log("x is = "+ x );
function nextImg() {

    if (x < 5) {
        x++;
    }
    else if (x >= 5) {
        
        x = 0;
    }

    
    carBG.src = imgList[x];
    console.log(x);
}


right.addEventListener('click', nextImg);

function prevImg() {

    if (x <= 0) {
        
        x = 5;
    }
    else if (x > -1 && x <= 5) {
        x--;
    }


   
    carBG.src = imgList[x];
    console.log(x);
}
left.addEventListener('click', prevImg);





//let LeftArrow = document.getElementById('Left_Arrow');
//function goLeft() {
//    console.log("left arrow clicked");
//    carBG.src = "../../Content/images/Erichs Carpet Care (logo).jpg";
//    carBG.style.transition = "1s";
//    carBG.style.left = "0";
//}
//LeftArrow.addEventListener('click', goLeft);


//let rightArrow = document.getElementById('Right_Arrow');
//function goRight() {
//    console.log("right arrow clicked");
//}
//rightArrow.addEventListener('click', goRight);