class Blob{
    PVector pos;
    float r;
    PVector vel;

    Blob(float x, float y, float r){
        pos = new PVector(x, y);
        ve
        this.r = r;
        vel = new PVector(random(-1, 1), random(-1, 1));
    }

    void show(){
        nofill();
        stroke(255);
        ellipse(pos.x, pos.y, r*2, r*2);
    }

    void update(){
        pos.add(vel);

        if(pos.x < 0 || pos.x > width){
            vel.x *= -1;
        }
    }
}