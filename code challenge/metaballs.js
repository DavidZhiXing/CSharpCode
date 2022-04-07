let b = new Blob([]);
Blob[] blobs = new Blob[2];
void setup() {
    size(640, 360);
    for (let i = 0; i < blobs.length; i++) {
        blobs[i] = new Blob(random(width), random(height));
    }
}

void draw() {
    background(0);

    loadPixels();
    for (int x = 0; x < width; x++) {
        for (int y = 0; y < height; y++) {
            float d = dist(x, y, width / 2, height / 2);
            int index = x + y * width;
            float col = 1000 * blobs[0].get(x, y);
            pixels[index] = color(255 - d * 5, 0, d * 5);
        }
    }

    updatePixels();

    for (let i = 0; i < blobs.length; i++) {
        blobs[i].update();
        blobs[i].display();
    b.show();
    b.update();
}
