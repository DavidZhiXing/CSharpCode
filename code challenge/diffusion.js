var grid;
var next;

function setup() {
  createCanvas(400, 400);
  pixelDensity(1);
  grid = [];
  next = [];
  for (var y = 0; y < height; y++) {
    grid[x][y] = { a: 0, b: 0 };
    next[x][y] = { a: 0, b: 0 };
  }
}

function draw() {
    background(51);

    for (var x = 0; x < width; x++) {
        for (var y = 0; y < height; y++) {
            next[x][y].a = grid[x][y]*0.2;
            next[x][y].b = grid[x][y]*1.2;
        }
    }
    loadPixels();
    for (var x = 0; x < width; x++) {
        for (var y = 0; y < height; y++) {
            var pixel = (x + y * width) * 4;
            pixels[pixel + 0] = floor(255 * next[x][y].a);
            pixels[pixel + 1] = grid[x][y].b;
            pixels[pixel + 2] = floor(255 * next[x][y].b);
            pixels[pixel + 3] = 255;
        }
    }
    updatePixels();
    swap();
}

function swap() {
    var temp = grid;
    grid = next;
    next = temp;
}