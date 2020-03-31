const puzzleText = document.getElementById('puzzleText');
const boxes = document.querySelectorAll('.box');
const message = document.getElementById('message');

let isPlaying = true;
let countDown;
let timer = 5;
let colors = generateRandomColors();
let selectedColor;

function generateRandomColors() {
    let arr = [];
    for (let i = 0; i < boxes.length; i++) {
        arr.push(randomColor());
    }
    return arr;
}

function randomColor() {
    let red = Math.floor(Math.random() * 256);
    let green = Math.floor(Math.random() * 256);
    let blue = Math.floor(Math.random() * 256);

    //return 'rgb(' + red + ', ' + green + ', ' + blue + ')';

    return `rgb(${red}, ${green}, ${blue})`;
}

function setPuzzleText(colorArr) {
    selectedColor = Math.floor(Math.random() * colorArr.length);
    puzzleText.textContent = colorArr[selectedColor];
}

function changeColor(colorArr) {
    for (let i = 0; i < boxes.length; i++) {
        boxes[i].style.background = colorArr[i];
    }
}

//reset gry
function resetGame() {
    clearInterval(countDown);
    timer = 5;
    colors = generateRandomColors();
    setPuzzleText(colors);
    changeColor(colors);
    message.textContent = 'Pick a color!';
    isPlaying = true;
}

function setWinner(color) {
    for (let i = 0; i < boxes.length; i++) {
        boxes[i].style.opacity = '1';
        boxes[i].style.background = color;
    }
}

changeColor(colors);

for (let i = 0; i < boxes.length; i++) {
    boxes[i].addEventListener('click', function (e) {
        if (isPlaying) {
            if (e.target.style.backgroundColor === colors[selectedColor])
            {
                isPlaying = false;
                message.textContent = 'Brawo!';
                setWinner(colors[selectedColor]);

                setTimeout(() => {
                    resetGame();
                }, 7000);

                countDown = setInterval(function () {
                    puzzleText.textContent = `Next round will start in ${timer} secound`;
                    timer--;
                }, 1000);

            }
            else
            {
                boxes[i].style.opacity = '0';
                message.textContent = 'Try again...';
            }
        }
    });
}

setPuzzleText(colors);